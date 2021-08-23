namespace test_COS
{
    partial class Form1
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
            this.Date1_1 = new System.Windows.Forms.DateTimePicker();
            this.Date1_2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Years = new System.Windows.Forms.TextBox();
            this.Months = new System.Windows.Forms.TextBox();
            this.Days = new System.Windows.Forms.TextBox();
            this.Years_label = new System.Windows.Forms.Label();
            this.Months_label = new System.Windows.Forms.Label();
            this.Days_label = new System.Windows.Forms.Label();
            this.Days_overall = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_cells = new System.Windows.Forms.Button();
            this.Date2_1 = new System.Windows.Forms.DateTimePicker();
            this.Date2_2 = new System.Windows.Forms.DateTimePicker();
            this.Date3_2 = new System.Windows.Forms.DateTimePicker();
            this.Date3_1 = new System.Windows.Forms.DateTimePicker();
            this.Date4_2 = new System.Windows.Forms.DateTimePicker();
            this.Date4_1 = new System.Windows.Forms.DateTimePicker();
            this.Date5_2 = new System.Windows.Forms.DateTimePicker();
            this.Date5_1 = new System.Windows.Forms.DateTimePicker();
            this.Date6_2 = new System.Windows.Forms.DateTimePicker();
            this.Date6_1 = new System.Windows.Forms.DateTimePicker();
            this.Date7_2 = new System.Windows.Forms.DateTimePicker();
            this.Date7_1 = new System.Windows.Forms.DateTimePicker();
            this.Date8_2 = new System.Windows.Forms.DateTimePicker();
            this.Date8_1 = new System.Windows.Forms.DateTimePicker();
            this.Remove_cells = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Date1_1
            // 
            this.Date1_1.Location = new System.Drawing.Point(20, 65);
            this.Date1_1.Name = "Date1_1";
            this.Date1_1.Size = new System.Drawing.Size(200, 20);
            this.Date1_1.TabIndex = 0;
            // 
            // Date1_2
            // 
            this.Date1_2.Location = new System.Drawing.Point(260, 65);
            this.Date1_2.Name = "Date1_2";
            this.Date1_2.Size = new System.Drawing.Size(200, 20);
            this.Date1_2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(601, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Years
            // 
            this.Years.Location = new System.Drawing.Point(553, 81);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(37, 20);
            this.Years.TabIndex = 4;
            // 
            // Months
            // 
            this.Months.Location = new System.Drawing.Point(627, 81);
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(36, 20);
            this.Months.TabIndex = 5;
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(705, 81);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(40, 20);
            this.Days.TabIndex = 6;
            // 
            // Years_label
            // 
            this.Years_label.AutoSize = true;
            this.Years_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Years_label.Location = new System.Drawing.Point(547, 53);
            this.Years_label.Name = "Years_label";
            this.Years_label.Size = new System.Drawing.Size(43, 25);
            this.Years_label.TabIndex = 7;
            this.Years_label.Text = "Лет";
            // 
            // Months_label
            // 
            this.Months_label.AutoSize = true;
            this.Months_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Months_label.Location = new System.Drawing.Point(596, 53);
            this.Months_label.Name = "Months_label";
            this.Months_label.Size = new System.Drawing.Size(89, 25);
            this.Months_label.TabIndex = 8;
            this.Months_label.Text = "Месяцев";
            // 
            // Days_label
            // 
            this.Days_label.AutoSize = true;
            this.Days_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Days_label.Location = new System.Drawing.Point(700, 53);
            this.Days_label.Name = "Days_label";
            this.Days_label.Size = new System.Drawing.Size(57, 25);
            this.Days_label.TabIndex = 9;
            this.Days_label.Text = "Дней";
            // 
            // Days_overall
            // 
            this.Days_overall.AutoSize = true;
            this.Days_overall.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Days_overall.Location = new System.Drawing.Point(585, 182);
            this.Days_overall.Name = "Days_overall";
            this.Days_overall.Size = new System.Drawing.Size(128, 17);
            this.Days_overall.TabIndex = 10;
            this.Days_overall.Text = "Общее кол-во дней";
            this.Days_overall.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Дата приема на работу";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(283, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Дата увольнения";
            // 
            // Add_cells
            // 
            this.Add_cells.Location = new System.Drawing.Point(20, 415);
            this.Add_cells.Name = "Add_cells";
            this.Add_cells.Size = new System.Drawing.Size(113, 23);
            this.Add_cells.TabIndex = 13;
            this.Add_cells.Text = "Добавить поле";
            this.Add_cells.UseVisualStyleBackColor = true;
            this.Add_cells.Click += new System.EventHandler(this.Add_cells_Click);
            // 
            // Date2_1
            // 
            this.Date2_1.Location = new System.Drawing.Point(20, 101);
            this.Date2_1.Name = "Date2_1";
            this.Date2_1.Size = new System.Drawing.Size(200, 20);
            this.Date2_1.TabIndex = 14;
            this.Date2_1.Visible = false;
            // 
            // Date2_2
            // 
            this.Date2_2.Location = new System.Drawing.Point(260, 100);
            this.Date2_2.Name = "Date2_2";
            this.Date2_2.Size = new System.Drawing.Size(200, 20);
            this.Date2_2.TabIndex = 15;
            this.Date2_2.Visible = false;
            // 
            // Date3_2
            // 
            this.Date3_2.Location = new System.Drawing.Point(260, 138);
            this.Date3_2.Name = "Date3_2";
            this.Date3_2.Size = new System.Drawing.Size(200, 20);
            this.Date3_2.TabIndex = 17;
            this.Date3_2.Visible = false;
            // 
            // Date3_1
            // 
            this.Date3_1.Location = new System.Drawing.Point(20, 139);
            this.Date3_1.Name = "Date3_1";
            this.Date3_1.Size = new System.Drawing.Size(200, 20);
            this.Date3_1.TabIndex = 16;
            this.Date3_1.Visible = false;
            // 
            // Date4_2
            // 
            this.Date4_2.Location = new System.Drawing.Point(260, 178);
            this.Date4_2.Name = "Date4_2";
            this.Date4_2.Size = new System.Drawing.Size(200, 20);
            this.Date4_2.TabIndex = 19;
            this.Date4_2.Visible = false;
            // 
            // Date4_1
            // 
            this.Date4_1.Location = new System.Drawing.Point(20, 179);
            this.Date4_1.Name = "Date4_1";
            this.Date4_1.Size = new System.Drawing.Size(200, 20);
            this.Date4_1.TabIndex = 18;
            this.Date4_1.Visible = false;
            // 
            // Date5_2
            // 
            this.Date5_2.Location = new System.Drawing.Point(260, 220);
            this.Date5_2.Name = "Date5_2";
            this.Date5_2.Size = new System.Drawing.Size(200, 20);
            this.Date5_2.TabIndex = 21;
            this.Date5_2.Visible = false;
            // 
            // Date5_1
            // 
            this.Date5_1.Location = new System.Drawing.Point(20, 221);
            this.Date5_1.Name = "Date5_1";
            this.Date5_1.Size = new System.Drawing.Size(200, 20);
            this.Date5_1.TabIndex = 20;
            this.Date5_1.Visible = false;
            // 
            // Date6_2
            // 
            this.Date6_2.Location = new System.Drawing.Point(260, 259);
            this.Date6_2.Name = "Date6_2";
            this.Date6_2.Size = new System.Drawing.Size(200, 20);
            this.Date6_2.TabIndex = 23;
            this.Date6_2.Visible = false;
            // 
            // Date6_1
            // 
            this.Date6_1.Location = new System.Drawing.Point(20, 260);
            this.Date6_1.Name = "Date6_1";
            this.Date6_1.Size = new System.Drawing.Size(200, 20);
            this.Date6_1.TabIndex = 22;
            this.Date6_1.Visible = false;
            // 
            // Date7_2
            // 
            this.Date7_2.Location = new System.Drawing.Point(260, 297);
            this.Date7_2.Name = "Date7_2";
            this.Date7_2.Size = new System.Drawing.Size(200, 20);
            this.Date7_2.TabIndex = 25;
            this.Date7_2.Visible = false;
            // 
            // Date7_1
            // 
            this.Date7_1.Location = new System.Drawing.Point(20, 298);
            this.Date7_1.Name = "Date7_1";
            this.Date7_1.Size = new System.Drawing.Size(200, 20);
            this.Date7_1.TabIndex = 24;
            this.Date7_1.Visible = false;
            // 
            // Date8_2
            // 
            this.Date8_2.Location = new System.Drawing.Point(260, 336);
            this.Date8_2.Name = "Date8_2";
            this.Date8_2.Size = new System.Drawing.Size(200, 20);
            this.Date8_2.TabIndex = 27;
            this.Date8_2.Visible = false;
            // 
            // Date8_1
            // 
            this.Date8_1.Location = new System.Drawing.Point(20, 337);
            this.Date8_1.Name = "Date8_1";
            this.Date8_1.Size = new System.Drawing.Size(200, 20);
            this.Date8_1.TabIndex = 26;
            this.Date8_1.Visible = false;
            // 
            // Remove_cells
            // 
            this.Remove_cells.Enabled = false;
            this.Remove_cells.Location = new System.Drawing.Point(139, 415);
            this.Remove_cells.Name = "Remove_cells";
            this.Remove_cells.Size = new System.Drawing.Size(96, 23);
            this.Remove_cells.TabIndex = 28;
            this.Remove_cells.Text = "Удалить поле";
            this.Remove_cells.UseVisualStyleBackColor = true;
            this.Remove_cells.Click += new System.EventHandler(this.Remove_cells_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Remove_cells);
            this.Controls.Add(this.Date8_2);
            this.Controls.Add(this.Date8_1);
            this.Controls.Add(this.Date7_2);
            this.Controls.Add(this.Date7_1);
            this.Controls.Add(this.Date6_2);
            this.Controls.Add(this.Date6_1);
            this.Controls.Add(this.Date5_2);
            this.Controls.Add(this.Date5_1);
            this.Controls.Add(this.Date4_2);
            this.Controls.Add(this.Date4_1);
            this.Controls.Add(this.Date3_2);
            this.Controls.Add(this.Date3_1);
            this.Controls.Add(this.Date2_2);
            this.Controls.Add(this.Date2_1);
            this.Controls.Add(this.Add_cells);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Days_overall);
            this.Controls.Add(this.Days_label);
            this.Controls.Add(this.Months_label);
            this.Controls.Add(this.Years_label);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.Months);
            this.Controls.Add(this.Years);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Date1_2);
            this.Controls.Add(this.Date1_1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "CoS(Расчет трудового стажа)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date1_1;
        private System.Windows.Forms.DateTimePicker Date1_2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Years;
        private System.Windows.Forms.TextBox Months;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.Label Years_label;
        private System.Windows.Forms.Label Months_label;
        private System.Windows.Forms.Label Days_label;
        private System.Windows.Forms.Label Days_overall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_cells;
        private System.Windows.Forms.DateTimePicker Date2_1;
        private System.Windows.Forms.DateTimePicker Date2_2;
        private System.Windows.Forms.DateTimePicker Date3_2;
        private System.Windows.Forms.DateTimePicker Date3_1;
        private System.Windows.Forms.DateTimePicker Date4_2;
        private System.Windows.Forms.DateTimePicker Date4_1;
        private System.Windows.Forms.DateTimePicker Date5_2;
        private System.Windows.Forms.DateTimePicker Date5_1;
        private System.Windows.Forms.DateTimePicker Date6_2;
        private System.Windows.Forms.DateTimePicker Date6_1;
        private System.Windows.Forms.DateTimePicker Date7_2;
        private System.Windows.Forms.DateTimePicker Date7_1;
        private System.Windows.Forms.DateTimePicker Date8_2;
        private System.Windows.Forms.DateTimePicker Date8_1;
        private System.Windows.Forms.Button Remove_cells;
    }
}

