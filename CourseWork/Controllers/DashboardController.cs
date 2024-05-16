using CourseWork.Models;
using CourseWork.Persistance;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using CourseWork.Extensions;
using System.Drawing;
using CourseWork.Presentation;
using CourseWork.Interfaces;
using CourseWork.Properties;

namespace CourseWork.Controllers
{
    public class DashboardController <T> where T: ITarget
    {
        readonly Label _valueLabel;
        readonly ComboBox _categoryDropdown;
        readonly ComboBox _customCategoryDropdown;
        readonly ListView _operationsListView;

        readonly ComboBox _targetsComboBox;
        readonly ComboBox _targetsComboBox2;
        readonly ProgressBar _targetProgressBar;
        readonly Label _targetValueLabel;
        readonly Label _targetMaxValueLabel;

        public List<Operation> _operations;
        readonly Dictionary<string, Category> _categories;
        readonly DataPointCollection _points;
        readonly Dictionary<string, T> _targets;

        readonly string _valueLabelPrefix;

        public double ValueSum;

        public DateTime PeriodStart;
        public DateTime PeriodEnd;

        int _operationsListSortId = 0;

        Dictionary<string, string> _categoryDropdownPairs = new Dictionary<string, string>();
        Dictionary<string, string> _targetsDropdownPairs = new Dictionary<string, string>();

        bool _needUpdate;


        public DashboardController(
            Label valueLabel, ComboBox categoryDropdown, 
            ComboBox customCategoryDropdown, ListView operationsListView, 
            List<Operation> operations, Dictionary<string, Category> categories, 
            DataPointCollection points, ComboBox targetsComboBox, 
            ProgressBar targetProgressBar, Label targetValueLabel, 
            Label targetMaxValueLabel,
            Dictionary<string, T> targets,
            ComboBox targetsComboBox2,
            string valueLabelPrefix
            )
        {
            _valueLabel = valueLabel;
            _categoryDropdown = categoryDropdown;
            _customCategoryDropdown = customCategoryDropdown;
            _operationsListView = operationsListView;

            _operations = operations;
            _categories = categories;
            _points = points;

            _targetsComboBox = targetsComboBox;
            _targetsComboBox2 = targetsComboBox2;
            _targetProgressBar = targetProgressBar;
            _targetMaxValueLabel = targetMaxValueLabel;
            _targetValueLabel = targetValueLabel;
            _targets = targets;

            _valueLabelPrefix = valueLabelPrefix;

            PeriodStart = DateTime.Today.AddMonths(-1);
            PeriodEnd = DateTime.Today.AddDays(1);

            SettingsController.OnProfileChanged += Initialize;
        }


        public void Initialize()
        {
            UpdateCategories();
            UpdateTargets();
            UpdateDashboard();

            _categoryDropdown.DataSource = new BindingSource(_categoryDropdownPairs, null);
            _categoryDropdown.DisplayMember = "Value";
            _categoryDropdown.ValueMember = "Key";

            UpdateCurrentTargetValue();
        }

        public void ChangeDataBase(List<Operation> operations)
        {
            _operations = operations;
            Initialize();
        }

        public void AddValue(double value, string categoryId, DateTime date, string targetKey)
        {
            var target = new KeyValuePair<string, double>();
            if (targetKey != "none")
            {
                double targetValue = 0;
                var targetBudjet = _targets[targetKey] as Budjet;
                if (targetBudjet != null)
                {
                    targetValue = targetBudjet.PeriodValue;
                }

                target = new KeyValuePair<string, double>(targetKey, targetValue);

                if (!string.IsNullOrEmpty(target.Key))
                {
                    _targets[target.Key].Value += value;
                    UpdateCurrentTargetValue();
                }
            }

            var expense = new Operation(value, date, categoryId, target);
            Config.Db.AddToList<Operation>(_operations, expense);
            UpdateDashboard();
        }

        public void UpdateDashboard()
        {
            ValueSum = 0;
            _points.Clear();
            bool needToEdit = false;

            foreach (var op in _operations)
            {
                if(op.CreateDate >= PeriodStart && op.CreateDate <= PeriodEnd)
                {
                    ValueSum += op.Value;
                    string opCategory;
                    try
                    {
                        opCategory = _categories[op.CategoryId].Title;
                    }catch(Exception ex)
                    {
                        op.CategoryId = "0";
                        opCategory = _categories[op.CategoryId].Title;
                        needToEdit = true;
                    }

                    var point = _points.Find(x => x.Label == opCategory);
                    if (point == null)
                    {
                        point = new DataPoint();
                        point.Label = opCategory;
                        _points.Add(point);
                    }
                    point.YValues[0] += op.Value;
                    
                }
            }

            UpdateValueText();
            UpdateOperationsList(_operationsListSortId);
            if (needToEdit)
            {
                Config.Db.SaveChanges();
            }
        }

        public void RemoveValue() 
        {
            UpdateValueText();
        }

        public void UpdateValueText()
        {
            _valueLabel.Text = $"{_valueLabelPrefix} за период\n{ValueSum} ₽";
        }

        void UpdateCategories()
        {
            _categoryDropdownPairs.Clear();
            foreach (var cat in _categories)
            {
                _categoryDropdownPairs.Add(cat.Key, cat.Value.Title);
            }
        }

        public void UpdateCustomCategoryDropDown()
        {
            _customCategoryDropdown.Items.Clear();
        }

        public void UpdateTargets()
        {
            _targetsDropdownPairs.Clear();
            _targetsDropdownPairs.Add("none", "-");
            foreach (var target in _targets)
            {
                _targetsDropdownPairs.Add(target.Key, target.Value.Title);
            }

            try
            {
                _targetsComboBox.DataSource = new BindingSource(_targetsDropdownPairs, null);
                _targetsComboBox.DisplayMember = "Value";
                _targetsComboBox.ValueMember = "Key";

                _targetsComboBox2.DataSource = new BindingSource(_targetsDropdownPairs, null);
                _targetsComboBox2.DisplayMember = "Value";
                _targetsComboBox2.ValueMember = "Key";
            }
            catch (Exception ex) { }

            UpdateCurrentTargetValue();
        }

        public void UpdateCurrentTargetValue()
        {
            if (_targetsComboBox.SelectedValue == null)
                return;

            _targets.TryGetValue(_targetsComboBox.SelectedValue.ToString(), out var target);
            if (target == null)
            {
                _targetsComboBox.SelectedItem = null;
                _targetValueLabel.Text = "0 руб.";
                _targetMaxValueLabel.Text = "0\nруб.";
                _targetProgressBar.Value = 0;
            }
            else
            {
                _targetValueLabel.Text = $"{target.Value} руб.";
                _targetMaxValueLabel.Text = $"{target.MaxValue}\nруб.";

                if (target.MaxValue > 0)
                    _targetProgressBar.Value = (int)Math.Min(Math.Round(target.Value / target.MaxValue * 100), _targetProgressBar.Maximum);
            }
        }

        public void TryChooseBudjet(string categoryId)
        {
            if (_targets.Count > 0 && _targets.First().Value is Budjet)
            {
                foreach (var budjet in _targets)
                {
                    Budjet budjetVal = budjet.Value as Budjet;
                    if (budjetVal.CategoryId == categoryId)
                    {
                        _targetsComboBox.SelectedValue = budjet.Key;
                        _targetsComboBox2.SelectedValue = budjet.Key;
                        UpdateCurrentTargetValue();
                        break;
                    }
                }
            }
        }

        public void ChangePeriod(DateTime start, DateTime end)
        {
            PeriodStart = start;
            PeriodEnd = end;
            UpdateDashboard();
        }

        public void UpdateOperationsList(int sortId)
        {
            sortId = sortId > -1 ? sortId : 0;
            _operationsListSortId = sortId;
            //var sortedOperations = new List<Operation>(_operations);
            List<OperationWithTag> sortedOperations = new List<OperationWithTag>();
            for(int i = 0; i < _operations.Count; i++)
            {
                sortedOperations.Add(new OperationWithTag
                {
                    Tag = i,
                    Value = _operations[i]
                });
            }

            switch (sortId)
            {
                case 0:
                    sortedOperations.Sort((x, y) => x.Value.CreateDate.CompareTo(y.Value.CreateDate));
                    sortedOperations.Reverse();
                    break;
                case 1:
                    sortedOperations.Sort((x, y) => x.Value.CreateDate.CompareTo(y.Value.CreateDate));
                    break;
                case 2:
                    sortedOperations.Sort((x, y) => x.Value.Value.CompareTo(y.Value.Value));
                    sortedOperations.Reverse();
                    break;
                case 3:
                    sortedOperations.Sort((x, y) => x.Value.Value.CompareTo(y.Value.Value));
                    break;
                case 4:
                    sortedOperations.Sort((x, y) => x.Value.CategoryId.CompareTo(y.Value.CategoryId));
                    break;
                default:
                    sortedOperations.Sort((x, y) => x.Value.CreateDate.CompareTo(y.Value.CreateDate));
                    break;
            }

            _operationsListView.Items.Clear();
            foreach (var operation in sortedOperations)
            {
                if (operation.Value.CreateDate >= PeriodStart && operation.Value.CreateDate <= PeriodEnd)
                {
                    var item = new ListViewItem(_categories[operation.Value.CategoryId].Title);
                    item.Tag = operation.Tag;
                    item.ForeColor = Color.White;

                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, operation.Value.Value.ToString()));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, operation.Value.CreateDate.ToString()));

                    _operationsListView.Items.Add(item);
                }
            }

        }

        public void EditOperation()
        {
            if(_operationsListView.SelectedItems.Count > 1 || _operationsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите только 1 элемент.");
                return;
            }

            Dictionary<string, ITarget> castedTargetDict = _targets.ToDictionary(kv => kv.Key, kv => (ITarget)kv.Value);
            var editForm = new OperationEditWindow(_operations[(int)_operationsListView.SelectedItems[0].Tag], _categoryDropdownPairs, castedTargetDict);
            editForm.OnEdited += OperationEditCallback;
            editForm.ShowDialog();
        }

        void OperationEditCallback()
        {
            Config.Db.SaveChanges();
            UpdateDashboard();
        }

        public void DeleteOperation()
        {
            if(_operationsListView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выберите только 1 элемент");
                return;
            }

            var operation = _operations[(int)_operationsListView.SelectedItems[0].Tag];
            if (operation.Target.Key != null && _targets.ContainsKey(operation.Target.Key))
            {
                Budjet budjet = _targets[operation.Target.Key] as Budjet;
                if (budjet != null) 
                {
                    if (budjet.PeriodValue == operation.Target.Value)
                    {
                        _targets[operation.Target.Key].Value -= operation.Value;
                    }
                }
                else
                {
                    _targets[operation.Target.Key].Value -= operation.Value;
                }
            }

            Config.Db.RemoveFromListById<Operation>(_operations, (int)_operationsListView.SelectedItems[0].Tag);
            UpdateDashboard();
            UpdateCurrentTargetValue();
        }

        public void OpenTabUpdate()
        {
            if (_needUpdate)
            {
                Initialize();
                _needUpdate = false;
            }
        }

        public void SetNeedUpdate()
        {
            _needUpdate = true;
        }
    }
}
