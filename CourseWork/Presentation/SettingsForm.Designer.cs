namespace CourseWork.UI
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.profileInfoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expensesListView = new System.Windows.Forms.ListView();
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryDeleteBtn = new System.Windows.Forms.Button();
            this.categoryEditBtn = new System.Windows.Forms.Button();
            this.profitCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.profilePathTExtBox = new System.Windows.Forms.TextBox();
            this.profileChangeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.profitListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки";
            // 
            // profileInfoLabel
            // 
            this.profileInfoLabel.AutoSize = true;
            this.profileInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileInfoLabel.ForeColor = System.Drawing.Color.White;
            this.profileInfoLabel.Location = new System.Drawing.Point(13, 50);
            this.profileInfoLabel.Name = "profileInfoLabel";
            this.profileInfoLabel.Size = new System.Drawing.Size(185, 26);
            this.profileInfoLabel.TabIndex = 1;
            this.profileInfoLabel.Text = "Профиль: default";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пользовательские категории";
            // 
            // expensesListView
            // 
            this.expensesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.expensesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.category,
            this.sum,
            this.date});
            this.expensesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.expensesListView.HideSelection = false;
            this.expensesListView.Location = new System.Drawing.Point(18, 246);
            this.expensesListView.Name = "expensesListView";
            this.expensesListView.Size = new System.Drawing.Size(372, 180);
            this.expensesListView.TabIndex = 37;
            this.expensesListView.UseCompatibleStateImageBehavior = false;
            this.expensesListView.View = System.Windows.Forms.View.List;
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
            // categoryDeleteBtn
            // 
            this.categoryDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.categoryDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.categoryDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.categoryDeleteBtn.Location = new System.Drawing.Point(413, 464);
            this.categoryDeleteBtn.Name = "categoryDeleteBtn";
            this.categoryDeleteBtn.Size = new System.Drawing.Size(179, 26);
            this.categoryDeleteBtn.TabIndex = 41;
            this.categoryDeleteBtn.Text = "Удалить";
            this.categoryDeleteBtn.UseVisualStyleBackColor = false;
            this.categoryDeleteBtn.Click += new System.EventHandler(this.categoryDeleteBtn_Click);
            // 
            // categoryEditBtn
            // 
            this.categoryEditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.categoryEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.categoryEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryEditBtn.ForeColor = System.Drawing.Color.White;
            this.categoryEditBtn.Location = new System.Drawing.Point(598, 464);
            this.categoryEditBtn.Name = "categoryEditBtn";
            this.categoryEditBtn.Size = new System.Drawing.Size(189, 26);
            this.categoryEditBtn.TabIndex = 40;
            this.categoryEditBtn.Text = "Изменить";
            this.categoryEditBtn.UseVisualStyleBackColor = false;
            this.categoryEditBtn.Click += new System.EventHandler(this.categoryEditBtn_Click);
            // 
            // profitCategoryNameTextBox
            // 
            this.profitCategoryNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.profitCategoryNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profitCategoryNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profitCategoryNameTextBox.ForeColor = System.Drawing.Color.White;
            this.profitCategoryNameTextBox.Location = new System.Drawing.Point(413, 432);
            this.profitCategoryNameTextBox.Name = "profitCategoryNameTextBox";
            this.profitCategoryNameTextBox.Size = new System.Drawing.Size(179, 26);
            this.profitCategoryNameTextBox.TabIndex = 42;
            this.profitCategoryNameTextBox.Text = "Название";
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.addCategoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.addCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.addCategoryBtn.Location = new System.Drawing.Point(598, 432);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(189, 26);
            this.addCategoryBtn.TabIndex = 43;
            this.addCategoryBtn.Text = "Добавить";
            this.addCategoryBtn.UseVisualStyleBackColor = false;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // profilePathTExtBox
            // 
            this.profilePathTExtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.profilePathTExtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePathTExtBox.Enabled = false;
            this.profilePathTExtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profilePathTExtBox.ForeColor = System.Drawing.Color.White;
            this.profilePathTExtBox.Location = new System.Drawing.Point(18, 88);
            this.profilePathTExtBox.Name = "profilePathTExtBox";
            this.profilePathTExtBox.Size = new System.Drawing.Size(600, 26);
            this.profilePathTExtBox.TabIndex = 44;
            this.profilePathTExtBox.Text = "profiles/default.json";
            // 
            // profileChangeBtn
            // 
            this.profileChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.profileChangeBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.profileChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileChangeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileChangeBtn.ForeColor = System.Drawing.Color.White;
            this.profileChangeBtn.Location = new System.Drawing.Point(18, 120);
            this.profileChangeBtn.Name = "profileChangeBtn";
            this.profileChangeBtn.Size = new System.Drawing.Size(196, 26);
            this.profileChangeBtn.TabIndex = 45;
            this.profileChangeBtn.Text = "Сменить";
            this.profileChangeBtn.UseVisualStyleBackColor = false;
            this.profileChangeBtn.Click += new System.EventHandler(this.profileChangeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "Для расходов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(409, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Для доходов";
            // 
            // profitListView
            // 
            this.profitListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.profitListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.profitListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.profitListView.HideSelection = false;
            this.profitListView.Location = new System.Drawing.Point(413, 246);
            this.profitListView.Name = "profitListView";
            this.profitListView.Size = new System.Drawing.Size(374, 180);
            this.profitListView.TabIndex = 47;
            this.profitListView.UseCompatibleStateImageBehavior = false;
            this.profitListView.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Категория";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Сумма";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата";
            this.columnHeader3.Width = 110;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(201, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 26);
            this.button1.TabIndex = 52;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(18, 432);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 26);
            this.textBox1.TabIndex = 51;
            this.textBox1.Text = "Название";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(18, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 26);
            this.button2.TabIndex = 50;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(201, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 26);
            this.button3.TabIndex = 49;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.profitListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.profileChangeBtn);
            this.Controls.Add(this.profilePathTExtBox);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.profitCategoryNameTextBox);
            this.Controls.Add(this.categoryDeleteBtn);
            this.Controls.Add(this.categoryEditBtn);
            this.Controls.Add(this.expensesListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profileInfoLabel);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Size = new System.Drawing.Size(801, 506);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label profileInfoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView expensesListView;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader sum;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button categoryDeleteBtn;
        private System.Windows.Forms.Button categoryEditBtn;
        private System.Windows.Forms.TextBox profitCategoryNameTextBox;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.TextBox profilePathTExtBox;
        private System.Windows.Forms.Button profileChangeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView profitListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
