using CourseWork.Controllers;
using CourseWork.Persistance;
using CourseWork.Presentation;
using System;
using System.Windows.Forms;

namespace CourseWork.UI
{
    public partial class SettingsForm : UserControl
    {
        readonly SettingsController _controller;

        public SettingsForm()
        {
            InitializeComponent();

            _controller = new SettingsController(expensesListView, profitListView, profilePathTExtBox, profileInfoLabel);
            _controller.UpdateAllCategoryListViews();
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            if (profitCategoryNameTextBox.Text.Length > 0)
            {
                _controller.AddProfitCategory(profitCategoryNameTextBox.Text);
            }
            else
            {
                MessageBox.Show("Название не должно быть пустым");
            }
        }

        private void categoryDeleteBtn_Click(object sender, EventArgs e)
        {
            string[] ids = new string[profitListView.SelectedItems.Count];
            for (int i = 0; i < ids.Length; i++)
            {
                ids[i] = profitListView.SelectedItems[i].Tag.ToString();
            }

            CategoriesDataBase.RemoveProfitCategoryMultiple(ids);
        }

        private void categoryEditBtn_Click(object sender, EventArgs e)
        {
            if (profitListView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Должна быть выделена только одна категория.");
                return;
            }

            var editForm = new CategoryEditForm(CategoriesDataBase.CustomCategories.CustomProfitCategories[profitListView.SelectedItems[0].Tag.ToString()]);
            editForm.OnEdited += ProfitCategoryEditCallback;
            editForm.ShowDialog();
        }

        private void profileChangeBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON (*.json)|*.json";
            openFileDialog.ShowDialog();
            openFileDialog.FileOk += _controller.HandleProfileChange(openFileDialog.FileName);
        }
                

        private void operationsList_Leave(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                _controller.AddExpensesCategory(textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(expensesListView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Должна быть выделена только одна категория.");
                return;
            }

            var editForm = new CategoryEditForm(CategoriesDataBase.CustomCategories.CustomExpenseCategories[expensesListView.SelectedItems[0].Tag.ToString()]);
            editForm.OnEdited += ExpenseCategoryEditCallback;
            editForm.ShowDialog();
        }

        void ExpenseCategoryEditCallback()
        {
            CategoriesDataBase.SaveCustomCategories();
            CategoriesDataBase.UpdateExpenseCategories();
        }

        void ProfitCategoryEditCallback()
        {
            CategoriesDataBase.SaveCustomCategories();
            CategoriesDataBase.UpdateProfitCategories();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] ids = new string[expensesListView.SelectedItems.Count];
            for (int i = 0; i < ids.Length; i++)
            {
                ids[i] = expensesListView.SelectedItems[i].Tag.ToString();
            }

            CategoriesDataBase.RemoveExpenseCategoryMultiple(ids);
        }
    }
}
