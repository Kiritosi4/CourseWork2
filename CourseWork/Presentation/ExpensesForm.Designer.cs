namespace CourseWork
{
    partial class ExpensesForm
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "1,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "2,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "3,0,0,0");
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Продукты", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))), new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "250 руб.", System.Drawing.SystemColors.Info, System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))), new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "25.02.2024", System.Drawing.SystemColors.Info, System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))), new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Здоровье",
            "400 руб.",
            " 26.02.2024"}, -1, System.Drawing.SystemColors.Menu, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            this.categoryDropDown = new System.Windows.Forms.ComboBox();
            this.DashBoard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.targetBar = new CourseWork.CustomProgressBar();
            this.targetsBox = new System.Windows.Forms.ComboBox();
            this.targetMaxValueLabel = new System.Windows.Forms.Label();
            this.targetValueLAbel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.expenseTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operationsList = new System.Windows.Forms.ListView();
            this.targetsComboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.operationListSortBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new CourseWork.RoundedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.day_period_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.roundedPanel1 = new CourseWork.RoundedPanel();
            this.ValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoard)).BeginInit();
            this.panel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryDropDown
            // 
            this.categoryDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.categoryDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryDropDown.ForeColor = System.Drawing.Color.White;
            this.categoryDropDown.FormattingEnabled = true;
            this.categoryDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.categoryDropDown.Location = new System.Drawing.Point(453, 173);
            this.categoryDropDown.Name = "categoryDropDown";
            this.categoryDropDown.Size = new System.Drawing.Size(149, 24);
            this.categoryDropDown.TabIndex = 27;
            this.categoryDropDown.SelectedIndexChanged += new System.EventHandler(this.categoryDropDown_SelectedIndexChanged);
            // 
            // DashBoard
            // 
            this.DashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DashBoard.BorderlineColor = System.Drawing.Color.Gray;
            this.DashBoard.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.DashBoard.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.DashBoard.BorderSkin.PageColor = System.Drawing.Color.Red;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            chartArea1.Name = "ChartArea1";
            this.DashBoard.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.DashBoard.Legends.Add(legend1);
            this.DashBoard.Location = new System.Drawing.Point(12, 17);
            this.DashBoard.Name = "DashBoard";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Black;
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            dataPoint1.Label = "Продукты";
            dataPoint1.LabelBackColor = System.Drawing.Color.White;
            dataPoint1.LabelBorderColor = System.Drawing.Color.Black;
            dataPoint2.Label = "Транспорт";
            dataPoint2.LabelBackColor = System.Drawing.Color.White;
            dataPoint2.LabelBorderColor = System.Drawing.Color.Black;
            dataPoint3.Label = "Коммуналка";
            dataPoint3.LabelBackColor = System.Drawing.Color.White;
            dataPoint3.LabelBorderColor = System.Drawing.Color.Black;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.YValuesPerPoint = 4;
            this.DashBoard.Series.Add(series1);
            this.DashBoard.Size = new System.Drawing.Size(387, 256);
            this.DashBoard.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(406, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Бюджет";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.targetBar);
            this.panel1.Controls.Add(this.targetsBox);
            this.panel1.Controls.Add(this.targetMaxValueLabel);
            this.panel1.Controls.Add(this.targetValueLAbel);
            this.panel1.Location = new System.Drawing.Point(405, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 184);
            this.panel1.TabIndex = 24;
            // 
            // targetBar
            // 
            this.targetBar.BarHeight = 25;
            this.targetBar.ChannelColor = System.Drawing.Color.Gray;
            this.targetBar.ForeColor = System.Drawing.Color.White;
            this.targetBar.Location = new System.Drawing.Point(15, 39);
            this.targetBar.Name = "targetBar";
            this.targetBar.Size = new System.Drawing.Size(352, 23);
            this.targetBar.SliderColor = System.Drawing.Color.RoyalBlue;
            this.targetBar.TabIndex = 37;
            this.targetBar.Value = 75;
            // 
            // targetsBox
            // 
            this.targetsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.targetsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.targetsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetsBox.ForeColor = System.Drawing.Color.White;
            this.targetsBox.FormattingEnabled = true;
            this.targetsBox.Location = new System.Drawing.Point(15, 9);
            this.targetsBox.Name = "targetsBox";
            this.targetsBox.Size = new System.Drawing.Size(352, 24);
            this.targetsBox.TabIndex = 19;
            this.targetsBox.SelectedIndexChanged += new System.EventHandler(this.targetsBox_SelectedIndexChanged);
            // 
            // targetMaxValueLabel
            // 
            this.targetMaxValueLabel.AutoSize = true;
            this.targetMaxValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetMaxValueLabel.ForeColor = System.Drawing.Color.White;
            this.targetMaxValueLabel.Location = new System.Drawing.Point(316, 65);
            this.targetMaxValueLabel.Name = "targetMaxValueLabel";
            this.targetMaxValueLabel.Size = new System.Drawing.Size(51, 20);
            this.targetMaxValueLabel.TabIndex = 12;
            this.targetMaxValueLabel.Text = "0 руб.";
            // 
            // targetValueLAbel
            // 
            this.targetValueLAbel.AutoSize = true;
            this.targetValueLAbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetValueLAbel.ForeColor = System.Drawing.Color.White;
            this.targetValueLAbel.Location = new System.Drawing.Point(11, 65);
            this.targetValueLAbel.Name = "targetValueLAbel";
            this.targetValueLAbel.Size = new System.Drawing.Size(51, 20);
            this.targetValueLAbel.TabIndex = 11;
            this.targetValueLAbel.Text = "0 руб.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "История расходов";
            // 
            // expenseTextBox
            // 
            this.expenseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.expenseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expenseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expenseTextBox.ForeColor = System.Drawing.Color.White;
            this.expenseTextBox.Location = new System.Drawing.Point(533, 128);
            this.expenseTextBox.Name = "expenseTextBox";
            this.expenseTextBox.Size = new System.Drawing.Size(149, 31);
            this.expenseTextBox.TabIndex = 21;
            this.expenseTextBox.Text = "Сумма";
            this.expenseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expenseTextBox.Click += new System.EventHandler(this.expenseTextBox_Click);
            this.expenseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expenseTextBox_KeyPress);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CourseWork.Properties.Resources.minus;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(585, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 42);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(688, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 26);
            this.label7.TabIndex = 35;
            this.label7.Text = "₽";
            // 
            // category
            // 
            this.category.Text = "Категория";
            this.category.Width = 150;
            // 
            // sum
            // 
            this.sum.Text = "Сумма";
            this.sum.Width = 120;
            // 
            // date
            // 
            this.date.Text = "Дата";
            this.date.Width = 110;
            // 
            // operationsList
            // 
            this.operationsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.operationsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.category,
            this.sum,
            this.date});
            this.operationsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.operationsList.HideSelection = false;
            listViewItem1.Tag = "252332";
            this.operationsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.operationsList.Location = new System.Drawing.Point(12, 310);
            this.operationsList.Name = "operationsList";
            this.operationsList.Size = new System.Drawing.Size(387, 154);
            this.operationsList.TabIndex = 36;
            this.operationsList.UseCompatibleStateImageBehavior = false;
            this.operationsList.View = System.Windows.Forms.View.Details;
            // 
            // targetsComboBox2
            // 
            this.targetsComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.targetsComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.targetsComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetsComboBox2.ForeColor = System.Drawing.Color.White;
            this.targetsComboBox2.FormattingEnabled = true;
            this.targetsComboBox2.Location = new System.Drawing.Point(608, 216);
            this.targetsComboBox2.Name = "targetsComboBox2";
            this.targetsComboBox2.Size = new System.Drawing.Size(143, 24);
            this.targetsComboBox2.TabIndex = 37;
            this.targetsComboBox2.Text = "Бюджет не выбран";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(608, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 23);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // operationListSortBox
            // 
            this.operationListSortBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.operationListSortBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operationListSortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationListSortBox.ForeColor = System.Drawing.Color.White;
            this.operationListSortBox.FormattingEnabled = true;
            this.operationListSortBox.Items.AddRange(new object[] {
            "Новые",
            "Старые",
            "По убыванию суммы",
            "По возврастанию суммы",
            "По категории"});
            this.operationListSortBox.Location = new System.Drawing.Point(240, 280);
            this.operationListSortBox.Name = "operationListSortBox";
            this.operationListSortBox.Size = new System.Drawing.Size(159, 24);
            this.operationListSortBox.TabIndex = 38;
            this.operationListSortBox.Text = "Новые";
            this.operationListSortBox.SelectedIndexChanged += new System.EventHandler(this.operationListSortBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(214, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 24);
            this.button1.TabIndex = 34;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 24);
            this.button3.TabIndex = 39;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(505, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Добавить в";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.roundedPanel2.BorderRadius = 15;
            this.roundedPanel2.Controls.Add(this.label6);
            this.roundedPanel2.Controls.Add(this.day_period_btn);
            this.roundedPanel2.Controls.Add(this.button4);
            this.roundedPanel2.Controls.Add(this.button9);
            this.roundedPanel2.Controls.Add(this.button7);
            this.roundedPanel2.Controls.Add(this.button8);
            this.roundedPanel2.ForeColor = System.Drawing.Color.White;
            this.roundedPanel2.Location = new System.Drawing.Point(405, 17);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(386, 35);
            this.roundedPanel2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Период:";
            // 
            // day_period_btn
            // 
            this.day_period_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.day_period_btn.FlatAppearance.BorderSize = 0;
            this.day_period_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_period_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day_period_btn.ForeColor = System.Drawing.Color.White;
            this.day_period_btn.Location = new System.Drawing.Point(76, 0);
            this.day_period_btn.Name = "day_period_btn";
            this.day_period_btn.Size = new System.Drawing.Size(66, 35);
            this.day_period_btn.TabIndex = 29;
            this.day_period_btn.Text = "День";
            this.day_period_btn.UseVisualStyleBackColor = false;
            this.day_period_btn.Click += new System.EventHandler(this.day_period_btn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(139, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 35);
            this.button4.TabIndex = 30;
            this.button4.Text = "Месяц";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(309, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 29);
            this.button9.TabIndex = 33;
            this.button9.Text = "Другой";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(203, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 35);
            this.button7.TabIndex = 31;
            this.button7.Text = "Год";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(258, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 35);
            this.button8.TabIndex = 32;
            this.button8.Text = "Все";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.Controls.Add(this.ValueLabel);
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(481, 62);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(250, 55);
            this.roundedPanel1.TabIndex = 34;
            // 
            // ValueLabel
            // 
            this.ValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueLabel.AutoEllipsis = true;
            this.ValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.ValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueLabel.ForeColor = System.Drawing.Color.White;
            this.ValueLabel.Location = new System.Drawing.Point(6, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(241, 55);
            this.ValueLabel.TabIndex = 20;
            this.ValueLabel.Text = "Расходы за период\r\n123.5 ₽\r\n\r\n";
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operationListSortBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.targetsComboBox2);
            this.Controls.Add(this.operationsList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.categoryDropDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DashBoard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expenseTextBox);
            this.Name = "ExpensesForm";
            this.Size = new System.Drawing.Size(801, 506);
            this.Load += new System.EventHandler(this.Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DashBoard)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryDropDown;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button day_period_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart DashBoard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox targetsBox;
        private System.Windows.Forms.Label targetMaxValueLabel;
        private System.Windows.Forms.Label targetValueLAbel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox expenseTextBox;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader sum;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ListView operationsList;
        private CustomProgressBar targetBar;
        private System.Windows.Forms.ComboBox targetsComboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox operationListSortBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}
