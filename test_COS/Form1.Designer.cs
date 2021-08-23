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
            this.Date_1 = new System.Windows.Forms.DateTimePicker();
            this.Date_2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Years = new System.Windows.Forms.TextBox();
            this.Months = new System.Windows.Forms.TextBox();
            this.Days = new System.Windows.Forms.TextBox();
            this.Years_label = new System.Windows.Forms.Label();
            this.Months_label = new System.Windows.Forms.Label();
            this.Days_label = new System.Windows.Forms.Label();
            this.Days_overall = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Date_1
            // 
            this.Date_1.Location = new System.Drawing.Point(79, 27);
            this.Date_1.Name = "Date_1";
            this.Date_1.Size = new System.Drawing.Size(200, 20);
            this.Date_1.TabIndex = 0;
            // 
            // Date_2
            // 
            this.Date_2.Location = new System.Drawing.Point(467, 27);
            this.Date_2.Name = "Date_2";
            this.Date_2.Size = new System.Drawing.Size(200, 20);
            this.Date_2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Years
            // 
            this.Years.Location = new System.Drawing.Point(116, 111);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(100, 20);
            this.Years.TabIndex = 4;
            // 
            // Months
            // 
            this.Months.Location = new System.Drawing.Point(331, 111);
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(100, 20);
            this.Months.TabIndex = 5;
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(514, 111);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(100, 20);
            this.Days.TabIndex = 6;
            // 
            // Years_label
            // 
            this.Years_label.AutoSize = true;
            this.Years_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Years_label.Location = new System.Drawing.Point(139, 70);
            this.Years_label.Name = "Years_label";
            this.Years_label.Size = new System.Drawing.Size(43, 25);
            this.Years_label.TabIndex = 7;
            this.Years_label.Text = "Лет";
            // 
            // Months_label
            // 
            this.Months_label.AutoSize = true;
            this.Months_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Months_label.Location = new System.Drawing.Point(332, 70);
            this.Months_label.Name = "Months_label";
            this.Months_label.Size = new System.Drawing.Size(89, 25);
            this.Months_label.TabIndex = 8;
            this.Months_label.Text = "Месяцев";
            // 
            // Days_label
            // 
            this.Days_label.AutoSize = true;
            this.Days_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Days_label.Location = new System.Drawing.Point(531, 70);
            this.Days_label.Name = "Days_label";
            this.Days_label.Size = new System.Drawing.Size(57, 25);
            this.Days_label.TabIndex = 9;
            this.Days_label.Text = "Дней";
            // 
            // Days_overall
            // 
            this.Days_overall.AutoSize = true;
            this.Days_overall.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Days_overall.Location = new System.Drawing.Point(316, 321);
            this.Days_overall.Name = "Days_overall";
            this.Days_overall.Size = new System.Drawing.Size(128, 17);
            this.Days_overall.TabIndex = 10;
            this.Days_overall.Text = "Общее кол-во дней";
            this.Days_overall.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Days_overall);
            this.Controls.Add(this.Days_label);
            this.Controls.Add(this.Months_label);
            this.Controls.Add(this.Years_label);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.Months);
            this.Controls.Add(this.Years);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Date_2);
            this.Controls.Add(this.Date_1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "CoS(Расчет трудового стажа)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date_1;
        private System.Windows.Forms.DateTimePicker Date_2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Years;
        private System.Windows.Forms.TextBox Months;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.Label Years_label;
        private System.Windows.Forms.Label Months_label;
        private System.Windows.Forms.Label Days_label;
        private System.Windows.Forms.Label Days_overall;
    }
}

