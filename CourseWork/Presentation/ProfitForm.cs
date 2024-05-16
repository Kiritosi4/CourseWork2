using CourseWork.Controllers;
using CourseWork.Interfaces;
using CourseWork.Models;
using CourseWork.Persistance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Presentation
{
    public partial class ProfitForm : UserControl, ITab
    {
        readonly DashboardController<Target> _operationWindowController;

        readonly Button[] _periodBtns;

        Button _currPickedPeiodBtn;

        public ProfitForm()
        {
            InitializeComponent();

            _operationWindowController = new DashboardController<Target>(
                ValueLabel,
                categoryDropDown,
                categoryDropDown,
                operationsList,
                Config.Db.Db.ProfitList,
                CategoriesDataBase.AllProfitCategories,
                DashBoard.Series[0].Points,
                targetsBox,
                targetBar,
                targetValueLAbel,
                targetMaxValueLabel,
                Config.Db.Db.TargetList,
                targetsComboBox2,
                "Доходы"
                );

            _operationWindowController.Initialize();

            CategoriesDataBase.OnProfitCategoriesChanged += _operationWindowController.SetNeedUpdate;
            TargetController.OnTargetsChanged += _operationWindowController.UpdateTargets;

            _periodBtns = new Button[]{
                day_period_btn,
                button4,
                button7,
                button8,
                button9
            };
            _currPickedPeiodBtn = button4;

            SettingsController.OnProfileChanged += HandleProfitChange;
        }

        void HandleProfitChange()
        {
            _operationWindowController._operations = Config.Db.Db.ProfitList;
            _operationWindowController.Initialize();
        }

        void PickPeriod(int id)
        {
            _currPickedPeiodBtn.Font = new Font(_currPickedPeiodBtn.Font, FontStyle.Regular);
            _currPickedPeiodBtn = _periodBtns[id];
            _currPickedPeiodBtn.Font = new Font(_currPickedPeiodBtn.Font, FontStyle.Underline);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (profitTextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле с суммой не должно быть пустым");
                return;
            }

            _operationWindowController.AddValue(
                double.Parse(profitTextBox.Text),
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

        private void profitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }

        private void profitTextBox_Click(object sender, EventArgs e)
        {
            if (profitTextBox.Text == "Сумма")
                profitTextBox.Text = string.Empty;
        }
    }
}
