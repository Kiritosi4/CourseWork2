using CourseWork.Controllers;
using CourseWork.Interfaces;
using System;
using System.Windows.Forms;

namespace CourseWork.Presentation
{
    public partial class TargetsForm : UserControl, ITab
    {
        readonly TargetController _controller;

        public TargetsForm()
        {
            InitializeComponent();

            _controller = new TargetController(targetsListView);
            SettingsController.OnProfileChanged += HandleProfileChange;
        }

        void HandleProfileChange()
        {
            _controller.Targets = Config.Db.Db.TargetList;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            targetsListView.SelectedItems.Clear();
        }  

        private void targetsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (targetsListView.SelectedItems.Count == 0)
            {
                editBtn.Enabled = false;
                delBtn.Enabled = false;
            }
            else
            {
                editBtn.Enabled = true;
                delBtn.Enabled = true;

                var selectedBudjet = _controller.GetTarget(targetsListView.SelectedItems[0].Tag.ToString());

                titleBox.Text = selectedBudjet.Title;
                textBox2.Text = selectedBudjet.Value.ToString();
                textBox3.Text = selectedBudjet.MaxValue.ToString();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleBox.Text))
            {
                MessageBox.Show("Название не должно быть пустым");
            }

            _controller.EditValue(
                targetsListView.SelectedItems[0].Tag.ToString(),
                titleBox.Text,
                double.Parse(textBox2.Text),
                double.Parse(textBox3.Text)
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
                double.Parse(textBox2.Text)
                );

            editBtn.Enabled = true;
            delBtn.Enabled = true;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            _controller.RemoveValue(targetsListView.SelectedItems[0].Tag.ToString());
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
