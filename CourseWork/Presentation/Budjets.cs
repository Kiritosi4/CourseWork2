using CourseWork.Controllers;
using CourseWork.Interfaces;
using System;
using System.Windows.Forms;

namespace CourseWork.Presentation
{
    public partial class Budjets : UserControl, ITab
    {
        readonly BudjetController _controller;

        public Budjets()
        {
            InitializeComponent();

            _controller = new BudjetController(budjetsListView, catBox);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            budjetsListView.SelectedItems.Clear();
        }

        private void budjetsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(budjetsListView.SelectedItems.Count == 0) 
            {
                editBtn.Enabled = false;
                delBtn.Enabled = false;
            }
            else
            {
                editBtn.Enabled = true;
                delBtn.Enabled = true;

                var selectedBudjet = _controller.GetBudjet(budjetsListView.SelectedItems[0].Tag.ToString());

                titleBox.Text = selectedBudjet.Title;
                textBox2.Text = selectedBudjet.Value.ToString();
                textBox3.Text = selectedBudjet.MaxValue.ToString();

                try
                {
                    catBox.SelectedText = selectedBudjet.Title;
                    catBox.SelectedValue = selectedBudjet.CategoryId;
                }
                catch
                {

                }

                periodBox.SelectedIndex = selectedBudjet.PeriodId;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleBox.Text))
            {
                MessageBox.Show("Название не должно быть пустым");
            }

            _controller.EditValue(
                budjetsListView.SelectedItems[0].Tag.ToString(), 
                titleBox.Text, 
                double.Parse(textBox2.Text), 
                double.Parse(textBox3.Text), 
                catBox.SelectedValue.ToString(), 
                periodBox.SelectedIndex
                );

            editBtn.Enabled = true;
            delBtn.Enabled = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleBox.Text))
            {
                MessageBox.Show("Название не должно быть пустым");
            }

            _controller.AddValue(
                titleBox.Text, 
                double.Parse(textBox3.Text), 
                double.Parse(textBox2.Text), 
                catBox.SelectedValue.ToString(), 
                periodBox.SelectedIndex
                );

            editBtn.Enabled = true;
            delBtn.Enabled = true;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            _controller.RemoveValue(budjetsListView.SelectedItems[0].Tag.ToString());
            editBtn.Enabled = false;
            delBtn.Enabled = false;
        }

        public void OpenTab()
        {
            _controller.OpenTabUpdate();
            editBtn.Enabled = false;
            delBtn.Enabled = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }
    }
}
