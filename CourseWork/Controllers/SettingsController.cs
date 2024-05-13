using CourseWork.Models;
using CourseWork.Persistance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Controllers
{
    public class SettingsController
    {
        readonly ListView _expensesCategoryListView;
        readonly ListView _profitCategoryListView;

        readonly TextBox _profileTextBox;
        readonly Label _profileInfoLabel;

        public static event Action OnProfileChanged;


        public SettingsController(ListView expensesCategoryListView, ListView profitCategoryListView, TextBox profileTextBox, Label profileInfoLabel)
        {
            _expensesCategoryListView = expensesCategoryListView;
            _profitCategoryListView = profitCategoryListView;
            _profileTextBox = profileTextBox;
            _profileInfoLabel = profileInfoLabel;

            Initialize();
        }

        void Initialize()
        {
            CategoriesDataBase.OnExpensesCategoriesChanged += UpdateExpensesListView;
            CategoriesDataBase.OnProfitCategoriesChanged += UpdateProfitListView;

            if (string.IsNullOrEmpty(Config.ConfigDb.CurrentDbPath))
            {
                _profileTextBox.Text = Config.DefaultDbPath;
                _profileInfoLabel.Text = "Профиль: default";
            }
            else
            {
                ChangeProfileLabelsToCurrPath();
            }
        }

        void ChangeProfileLabelsToCurrPath()
        {
            _profileTextBox.Text = Config.ConfigDb.CurrentDbPath;
            string[] splittedPath = Config.ConfigDb.CurrentDbPath.Split('\\');
            _profileInfoLabel.Text = $"Профиль: {splittedPath.Last()}";
        }

        public void ChangeProfile(string path)
        {

        }

        public void UpdateCategoryListView(ListView view, Dictionary<string, Category> dict)
        {
            view.Items.Clear();
            foreach (var category in dict) 
            {
                var item = new ListViewItem(category.Value.Title);
                item.ForeColor = Color.White;
                item.Tag = category.Key;
                view.Items.Add(item);
            }
        }

        public void UpdateExpensesListView()
        {
            UpdateCategoryListView(_expensesCategoryListView, CategoriesDataBase.CustomCategories.CustomExpenseCategories);
        }

        public void UpdateProfitListView()
        {
            UpdateCategoryListView(_profitCategoryListView, CategoriesDataBase.CustomCategories.CustomProfitCategories);
        }

        public void UpdateAllCategoryListViews()
        {
            UpdateExpensesListView();
            UpdateProfitListView();
        }

        public void AddExpensesCategory(string title)
        {
            CategoriesDataBase.AddExpenseCategory(new Category(title, ""));
        }

        public void RemoveExpensesCategory(string id)
        {
            CategoriesDataBase.RemoveExpenseCategory(id);
        }


        public void EditExpensesCategory(string id, Category cat)
        {
            CategoriesDataBase.EditExpenseCategory(id, cat);
        }

        public void AddProfitCategory(string title)
        {
            CategoriesDataBase.AddProfitCategory(new Category(title, ""));
        }

        public void RemoveProfitCategory(string id)
        {
            CategoriesDataBase.RemoveProfitCategory(id);
        }

        public void EditProfitCategory(string id, Category cat)
        {
            CategoriesDataBase.EditProfitCategory(id, cat);
        }

        public CancelEventHandler HandleProfileChange(string path)
        {
            if(string.IsNullOrEmpty(path)) 
                return null;

            Config.ConfigDb.CurrentDbPath = path;
            if (Config.Db.TryLoadDb())
            {
                Config.SaveCfg();
                ChangeProfileLabelsToCurrPath();
                OnProfileChanged?.Invoke();
            }
            else
            {
                Config.ConfigDb.CurrentDbPath = string.Empty;
            }

            return null;
        }

    }
}
