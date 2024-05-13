namespace CourseWork.Presentation
{
    partial class OperationEditWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.expenseTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.categoryDropDown = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(216, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 26);
            this.label7.TabIndex = 37;
            this.label7.Text = "₽";
            // 
            // expenseTextBox
            // 
            this.expenseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.expenseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expenseTextBox.ForeColor = System.Drawing.Color.White;
            this.expenseTextBox.Location = new System.Drawing.Point(61, 40);
            this.expenseTextBox.Name = "expenseTextBox";
            this.expenseTextBox.Size = new System.Drawing.Size(149, 24);
            this.expenseTextBox.TabIndex = 36;
            this.expenseTextBox.Text = "Сумма";
            this.expenseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expenseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expenseTextBox_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 31);
            this.button1.TabIndex = 38;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryDropDown
            // 
            this.categoryDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.categoryDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryDropDown.ForeColor = System.Drawing.Color.White;
            this.categoryDropDown.FormattingEnabled = true;
            this.categoryDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.categoryDropDown.Location = new System.Drawing.Point(61, 84);
            this.categoryDropDown.Name = "categoryDropDown";
            this.categoryDropDown.Size = new System.Drawing.Size(149, 24);
            this.categoryDropDown.TabIndex = 39;
            this.categoryDropDown.Text = "Категория";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(61, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 23);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // OperationEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(281, 227);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.categoryDropDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.expenseTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperationEditWindow";
            this.ShowIcon = false;
            this.Text = "OperationEditWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox expenseTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox categoryDropDown;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}