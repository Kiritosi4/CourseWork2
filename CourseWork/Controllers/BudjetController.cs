using CourseWork.Models;
using CourseWork.Persistance;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork.Controllers
{
    public class BudjetController
    {
        readonly ListView _budjetsListView;
        readonly ComboBox _categoriesDropDown;
        readonly Dictionary<string, Budjet> _budjets;

        readonly Dictionary<string, Category> _categories;
        string[] _periodNames = new string[]
        {
            "День",
            "Месяц",
            "Год",
            "Бессрочно"
        };
        Dictionary<string, string> _categoryDropdownPairs = new Dictionary<string, string>();

        public static event Action OnBudjetsChanged;

        public BudjetController(ListView budjetsListView, ComboBox categoriesDropDown)
        {
            _budjetsListView = budjetsListView;
            _categoriesDropDown = categoriesDropDown;

            _budjets = Config.Db.Db.BudjetList;
            _categories = CategoriesDataBase.AllExpenseCategories;

            Initialize();
        }


        public void Initialize()
        {
            OpenTabUpdate();

            _categoriesDropDown.DataSource = new BindingSource(_categoryDropdownPairs, null);
            _categoriesDropDown.DisplayMember = "Value";
            _categoriesDropDown.ValueMember = "Key";
        }

        public void UpdateCategoryPairs()
        {
            _categoryDropdownPairs.Clear();

            foreach (var category in _categories)
            {
                _categoryDropdownPairs.Add(category.Key, category.Value.Title);
            }
        }

        public void UpdateBudjets()
        {
            foreach (var budjet in _budjets)
            {
                budjet.Value.Update();
            }
        }

        public void UpdateListView()
        {
            _budjetsListView.Items.Clear();

            foreach(var budjet in _budjets)
            {
                var item = new ListViewItem(budjet.Value.Title);
                item.Tag = budjet.Key;
                item.ForeColor = Color.White;

                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, budjet.Value.Value.ToString()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, budjet.Value.MaxValue.ToString()));

                _categories.TryGetValue(budjet.Value.CategoryId, out var category);
                string categoryColumn = category == null ? string.Empty : category.Title.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, categoryColumn));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, _periodNames[budjet.Value.PeriodId]));

                _budjetsListView.Items.Add(item);
            }
        }

        public void OpenTabUpdate()
        {
            UpdateBudjets();
            UpdateCategoryPairs();
            UpdateListView();
        }

        public void AddValue(string name, double value, double maxValue, string catId, int periodId)
        {
            Config.Db.AddToDict<Budjet>(_budjets, Guid.NewGuid().ToString(), new Budjet(name, value, maxValue, catId, Math.Max(periodId, 0)));
            UpdateListView();
            OnBudjetsChanged?.Invoke();
        }

        public void RemoveValue(string id)
        {
            Config.Db.RemoveFromDict<Budjet>(_budjets, id);
            UpdateListView();
            OnBudjetsChanged?.Invoke();
        }

        public void EditValue(string key, string name, double value, double maxValue, string catId, int periodId)
        {
            var budjet = Config.Db.Db.BudjetList[key];
            budjet.Title = name;
            budjet.Value = value;
            budjet.MaxValue = maxValue;
            budjet.CategoryId = catId;
            budjet.PeriodId = periodId;

            Config.Db.SaveChanges();
            UpdateListView();
            OnBudjetsChanged?.Invoke();
        }

        public Budjet GetBudjet(string id)
        {
            return _budjets[id];
        }
    }
}
