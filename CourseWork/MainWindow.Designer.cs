namespace CourseWork
{
    partial class MainWindow
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.profitButton = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.targetButton = new System.Windows.Forms.Button();
            this.expensesButton = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.tabView = new System.Windows.Forms.Panel();
            this.Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Bar.Controls.Add(this.button1);
            this.Bar.Controls.Add(this.profitButton);
            this.Bar.Controls.Add(this.minimize_btn);
            this.Bar.Controls.Add(this.settingsButton);
            this.Bar.Controls.Add(this.targetButton);
            this.Bar.Controls.Add(this.expensesButton);
            this.Bar.Controls.Add(this.close_btn);
            this.Bar.Location = new System.Drawing.Point(-4, -5);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(807, 49);
            this.Bar.TabIndex = 11;
            this.Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseDown);
            this.Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::CourseWork.Properties.Resources.budjet_25;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(300, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Бюджет";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // profitButton
            // 
            this.profitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.profitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profitButton.FlatAppearance.BorderSize = 0;
            this.profitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profitButton.Image = global::CourseWork.Properties.Resources.profit_25;
            this.profitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profitButton.Location = new System.Drawing.Point(152, 3);
            this.profitButton.Name = "profitButton";
            this.profitButton.Size = new System.Drawing.Size(144, 46);
            this.profitButton.TabIndex = 17;
            this.profitButton.Text = "Доходы";
            this.profitButton.UseVisualStyleBackColor = false;
            this.profitButton.Click += new System.EventHandler(this.profitButton_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("AXIS Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.Location = new System.Drawing.Point(751, 3);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(25, 25);
            this.minimize_btn.TabIndex = 16;
            this.minimize_btn.Text = "_";
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.Image = global::CourseWork.Properties.Resources.gear_25;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(564, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(158, 46);
            this.settingsButton.TabIndex = 15;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // targetButton
            // 
            this.targetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.targetButton.FlatAppearance.BorderSize = 0;
            this.targetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.targetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetButton.Image = global::CourseWork.Properties.Resources.target_25;
            this.targetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.targetButton.Location = new System.Drawing.Point(439, 3);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(121, 46);
            this.targetButton.TabIndex = 14;
            this.targetButton.Text = "Цели";
            this.targetButton.UseVisualStyleBackColor = false;
            this.targetButton.Click += new System.EventHandler(this.targetButton_Click);
            // 
            // expensesButton
            // 
            this.expensesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.expensesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.expensesButton.FlatAppearance.BorderSize = 0;
            this.expensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expensesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expensesButton.Image = global::CourseWork.Properties.Resources.money_25;
            this.expensesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expensesButton.Location = new System.Drawing.Point(3, 3);
            this.expensesButton.Name = "expensesButton";
            this.expensesButton.Size = new System.Drawing.Size(145, 46);
            this.expensesButton.TabIndex = 13;
            this.expensesButton.Text = "Расходы";
            this.expensesButton.UseVisualStyleBackColor = false;
            this.expensesButton.Click += new System.EventHandler(this.expensesButton_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("AXIS Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(779, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(25, 25);
            this.close_btn.TabIndex = 12;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // tabView
            // 
            this.tabView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabView.Location = new System.Drawing.Point(-1, 41);
            this.tabView.Name = "tabView";
            this.tabView.Size = new System.Drawing.Size(804, 506);
            this.tabView.TabIndex = 12;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 546);
            this.ControlBox = false;
            this.Controls.Add(this.tabView);
            this.Controls.Add(this.Bar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Учет финансов";
            this.Bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Bar;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button expensesButton;
        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button profitButton;
        private System.Windows.Forms.Panel tabView;
        private System.Windows.Forms.Button button1;
    }
}

