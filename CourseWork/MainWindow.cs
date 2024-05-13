using CourseWork.Persistance;
using CourseWork.Presentation;
using CourseWork.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{


    public partial class MainWindow : Form
    {
        Point _mousePoint;
        TabController _tabController;

        public MainWindow()
        {
            InitializeComponent();

            UserControl[] tabs = new UserControl[] {
                new ExpensesForm(),
                new ProfitForm(),
                new Budjets(),
                new TargetsForm(),
                new SettingsForm()
                
            };
            _tabController = new TabController(tabView, tabs);
            _tabController.OpenTab(0);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Bar_MouseDown(object sender, MouseEventArgs e)
        {
            _mousePoint = new Point(-e.X, -e.Y);
        }

        private void Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(_mousePoint.X, _mousePoint.Y);
                Location = mousePos;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void expensesButton_Click(object sender, EventArgs e)
        {
            _tabController.OpenTab(0);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            _tabController.OpenTab(4);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _tabController.OpenTab(2);
        }

        private void profitButton_Click(object sender, EventArgs e)
        {
            _tabController.OpenTab(1);
        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            _tabController.OpenTab(3);
        }
    }
}
