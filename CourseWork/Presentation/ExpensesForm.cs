using CourseWork.Controllers;
using CourseWork.Interfaces;
using CourseWork.Models;
using CourseWork.Persistance;
using CourseWork.Presentation;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ExpensesForm : UserControl, ITab
    {
        DashboardController<Budjet> _operationWindowController;

        readonly Button[] _periodBtns;

        Button _currPickedPeiodBtn;

        public ExpensesForm()
        {
            InitializeComponent();

            SetController();

            _periodBtns = new Button[]{
                day_period_btn,
                button4,
                button7,
                button8,
                button9
            };
            _currPickedPeiodBtn = button4;

            SettingsController.OnProfileChanged += HandleProfileChange;
        }

        void HandleProfileChange()
        {
            _operationWindowController._operations = Config.Db.Db.ExpensesList;
            _operationWindowController.Initialize();
        }

        void SetController()
        {
            _operationWindowController = new DashboardController<Budjet>(
                ValueLabel,
                categoryDropDown,
                categoryDropDown,
                operationsList,
                Config.Db.Db.ExpensesList,
                CategoriesDataBase.AllExpenseCategories,
                DashBoard.Series[0].Points,
                targetsBox,
                targetBar,
                targetValueLAbel,
                targetMaxValueLabel,
                Config.Db.Db.BudjetList,
                targetsComboBox2,
                "Расходы"
                );
            _operationWindowController.Initialize();

            CategoriesDataBase.OnExpensesCategoriesChanged += _operationWindowController.SetNeedUpdate;
            BudjetController.OnBudjetsChanged += _operationWindowController.UpdateTargets;
        }

        void PickPeriod(int id)
        {
            _currPickedPeiodBtn.Font = new Font(_currPickedPeiodBtn.Font, FontStyle.Regular);
            _currPickedPeiodBtn = _periodBtns[id];
            _currPickedPeiodBtn.Font = new Font(_currPickedPeiodBtn.Font, FontStyle.Underline);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (expenseTextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле с суммой не должно быть пустым");
                return;
            }

            _operationWindowController.AddValue(
                double.Parse(expenseTextBox.Text), 
                categoryDropDown.SelectedValue.ToString(), 
                dateTimePicker1.Value, 
                targetsComboBox2.SelectedValue.ToString());
        }

        private void Expenses_Load(object sender, EventArgs e)
        {

        }

        private void day_period_btn_Click(object sender, EventArgs e)
        {
            _operationWindowController.ChangePeriod(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1));
            PickPeriod(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _operationWindowController.ChangePeriod(DateTime.Now.AddMonths(-1), DateTime.Now.AddDays(1));
            PickPeriod(1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _operationWindowController.ChangePeriod(DateTime.Now.AddYears(-1), DateTime.Now.AddDays(1));
            PickPeriod(2);
        }

        private void expenseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }

        private void expenseTextBox_Click(object sender, EventArgs e)
        {
            if (expenseTextBox.Text == "Сумма")
                expenseTextBox.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void operationListSortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _operationWindowController.UpdateOperationsList(operationListSortBox.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _operationWindowController.EditOperation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _operationWindowController.DeleteOperation();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var dataPickWindow = new DataPeriodPick();
            dataPickWindow.OnDatePicked += _operationWindowController.ChangePeriod;
            dataPickWindow.ShowDialog();
            PickPeriod(4);
        }

        public void OpenTab()
        {
            _operationWindowController.OpenTabUpdate();
        }

        private void targetsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _operationWindowController.UpdateCurrentTargetValue();
        }

        private void categoryDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            _operationWindowController.TryChooseBudjet(categoryDropDown.SelectedValue.ToString());
        }
    }
}
