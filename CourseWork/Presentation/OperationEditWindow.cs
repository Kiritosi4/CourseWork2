using CourseWork.Interfaces;
using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork.Presentation
{
    public partial class OperationEditWindow : Form
    {
        readonly Operation _operation;
        readonly Dictionary<string, ITarget> _targets;
        public event Action OnEdited;

        public OperationEditWindow(Operation op, Dictionary<string, string> catsPairs, Dictionary<string, ITarget> targets)
        {
            _operation = op;
            _targets = targets;

            InitializeComponent();

            expenseTextBox.Text = _operation.Value.ToString();
            dateTimePicker1.Value = _operation.CreateDate;

            categoryDropDown.DataSource = new BindingSource(catsPairs, null);
            categoryDropDown.DisplayMember = "Value";
            categoryDropDown.ValueMember = "Key";

            categoryDropDown.SelectedValue = _operation.CategoryId;
            categoryDropDown.SelectedText = catsPairs[_operation.CategoryId];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newValue = int.Parse(expenseTextBox.Text);

            if (_operation.Target.Key != null && _targets.ContainsKey(_operation.Target.Key))
            {
                Budjet budjet = _targets[_operation.Target.Key] as Budjet;
                if (budjet != null)
                {
                    if (budjet.PeriodValue == _operation.Value)
                    {
                        _targets[_operation.Target.Key].Value += (newValue - _operation.Value);
                    }
                }
                else
                {
                    _targets[_operation.Target.Key].Value += (newValue - _operation.Value);
                }
                
            }

            _operation.Value = newValue;
            _operation.CategoryId = categoryDropDown.SelectedValue.ToString();
            _operation.CreateDate = dateTimePicker1.Value;

            OnEdited?.Invoke();
            Close();
        }

        private void expenseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }
    }
}
