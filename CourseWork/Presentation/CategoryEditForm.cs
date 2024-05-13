using CourseWork.Models;
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
    public partial class CategoryEditForm : Form
    {
        readonly Category _category;

        public event Action OnEdited;


        public CategoryEditForm(Category cat)
        {
            _category = cat;
            InitializeComponent();

            titleBox.Text = cat.Title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (titleBox.Text.Length > 0)
            {
                _category.Title = titleBox.Text;
                OnEdited?.Invoke();
            }
            else
            {
                MessageBox.Show("Название не должно быть пустым");
            }

            Close();
        }
    }
}
