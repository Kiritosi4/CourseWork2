using CourseWork.Models;
using System.Collections.Generic;

namespace CourseWork.Persistance
{
    public class CategoriesDbContext
    {
        public Dictionary<string, Category> CustomExpenseCategories { get; set; } = new Dictionary<string, Category>();
        public Dictionary<string ,Category> CustomProfitCategories { get; set; } = new Dictionary<string, Category>();
    }
}
