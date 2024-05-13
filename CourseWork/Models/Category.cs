

namespace CourseWork.Models
{
    public class Category
    {
        public string Title { get; set; }
        public string IconPath { get; set; }

        public Category(string title, string iconPath)
        {
            Title = title;
            IconPath = iconPath;
        }
    }
}
