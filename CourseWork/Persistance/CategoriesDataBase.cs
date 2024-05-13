using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Persistance
{
    public static class CategoriesDataBase
    {
        public static CategoriesDbContext CustomCategories = new CategoriesDbContext();

        public static List<Category> DefaultExpenseCategories = new List<Category> 
        {
            new Category("Прочее", ""),
            new Category("Продукты", ""),
            new Category("Здоровье", ""),
            new Category("Транспорт", ""),
            new Category("Развлечения", ""),
            new Category("Коммуналка", ""),
            new Category("Спорт", ""),
            new Category("Питомцы", ""),
            new Category("Образование", ""),
            new Category("Рестораны", ""),
            new Category("Одежда", ""),
            new Category("Подарки", "")
        };

        public static List<Category> DefaultProfitCategories = new List<Category>
        {
            new Category("Прочее", ""),
            new Category("Зарплата", ""),
            new Category("Стипендия", ""),
            new Category("Пенсия", ""),
            new Category("Процент со вклада", ""),
            new Category("Дивиденды", "")
        };

        public static Dictionary<string, Category> AllExpenseCategories = new Dictionary<string, Category>();
        public static Dictionary<string, Category> AllProfitCategories = new Dictionary<string, Category>();

        public static string[] AllExpenseCategoriesKeys;
        public static string[] AllProfitCategoriesKeys;

        public static event Action OnExpensesCategoriesChanged;
        public static event Action OnProfitCategoriesChanged;


        public static void TryLoadCustomCategories()
        {
            try
            {
                using (FileStream fs = new FileStream(Config.CategoriesDbPath, FileMode.OpenOrCreate))
                {
                    CustomCategories = JsonSerializer.Deserialize<CategoriesDbContext>(fs);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Не удалось загрузить пользовательские категории.\n{e.Message}");
            }

            UpdateCategories();
        }

        public async static void SaveCustomCategories()
        {
            using (FileStream fs = File.Create(Config.CategoriesDbPath))
            {
                await JsonSerializer.SerializeAsync<CategoriesDbContext>(fs, CustomCategories);
            }
        }

        static void UpdateCategoriesDict(List<Category> defaultCategoriesList, Dictionary<string, Category> customCategories, Dictionary<string, Category> result)
        {
            result.Clear();

            for (int i = 0; i < defaultCategoriesList.Count; i++)
            {
                result.Add(i.ToString(), defaultCategoriesList[i]);
            }

            if(customCategories != null) {
                foreach (var category in customCategories)
                {
                    result.Add(category.Key, category.Value);
                }
            }

            AllExpenseCategoriesKeys = AllExpenseCategories.Keys.ToArray();
            AllProfitCategoriesKeys = AllProfitCategories.Keys.ToArray();

        }

        public static void UpdateExpenseCategories()
        {
            UpdateCategoriesDict(DefaultExpenseCategories, CustomCategories.CustomExpenseCategories, AllExpenseCategories);
            OnExpensesCategoriesChanged?.Invoke();
        }

        public static void UpdateProfitCategories()
        {
            UpdateCategoriesDict(DefaultProfitCategories, CustomCategories.CustomProfitCategories, AllProfitCategories);
            OnProfitCategoriesChanged?.Invoke();
        }

        public static void UpdateCategories()
        {
            UpdateExpenseCategories();
            UpdateProfitCategories();
        }

        public static void AddCategoryTo(Dictionary<string, Category> dict, string key, Category val)
        {
            dict.Add(key, val);
            SaveCustomCategories();
        }

        public static void RemoveCategoryFrom(Dictionary<string, Category> dict, string key, bool save = true)
        {
            try
            {
                dict.Remove(key);
                if(save)
                    SaveCustomCategories();
            }
            catch
            {
                MessageBox.Show("Не найдена категория для удаления");
            }
        }

        public static void EditCategoryFrom(Dictionary<string, Category> dict, string key, Category cat)
        {
            try
            {
                dict[key] = cat;
                SaveCustomCategories();
            }
            catch
            {
                MessageBox.Show("Не найдена категория для редактирования");
            }
        }

        public static void AddExpenseCategory(Category cat)
        {
            AddCategoryTo(CustomCategories.CustomExpenseCategories, Guid.NewGuid().ToString(), cat);
            UpdateExpenseCategories();
        }

        public static void AddProfitCategory(Category cat)
        {
            AddCategoryTo(CustomCategories.CustomProfitCategories, Guid.NewGuid().ToString(), cat);
            UpdateProfitCategories();
        }

        public static void RemoveExpenseCategory(string id)
        {
            RemoveCategoryFrom(CustomCategories.CustomExpenseCategories, id);
            UpdateExpenseCategories();
        }

        public static void RemoveProfitCategory(string id)
        {
            RemoveCategoryFrom(CustomCategories.CustomProfitCategories, id);
            UpdateProfitCategories();
        }

        public static void RemoveExpenseCategoryMultiple(string[] ids)
        {
            foreach (string id in ids)
            {
                RemoveCategoryFrom(CustomCategories.CustomExpenseCategories, id, false);
            }
            SaveCustomCategories();
            UpdateExpenseCategories();
        }

        public static void RemoveProfitCategoryMultiple(string[] ids)
        {
            foreach (string id in ids)
            {
                RemoveCategoryFrom(CustomCategories.CustomProfitCategories, id, false);
            }
            SaveCustomCategories();
            UpdateProfitCategories();
        }

        public static void EditExpenseCategory(string id, Category cat)
        {
            EditCategoryFrom(CustomCategories.CustomExpenseCategories, id, cat);
            UpdateExpenseCategories();
        }

        public static void EditProfitCategory(string id, Category cat)
        {
            EditCategoryFrom(CustomCategories.CustomProfitCategories, id, cat);
            UpdateProfitCategories();
        }

        public static void CallAllevents()
        {
            OnExpensesCategoriesChanged?.Invoke();
            OnProfitCategoriesChanged?.Invoke();
        }
    }
}
