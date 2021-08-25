using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_COS
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int years_all = 0;
        int months_all = 0;
        int days_all = 0;
        int overall = 0;
        int cells = 1;
        public void reset() {
            years_all = 0;
            months_all = 0;
            days_all = 0;
            overall = 0;
        }

        public void subtract_dates(DateTimePicker x, DateTimePicker y) {
            DateTimePicker date_1 = x;
            DateTimePicker date_2 = y;
            DateTime date1_1 = DateTime.Parse(date_1.Value.ToString());
            DateTime date1_2 = DateTime.Parse(date_2.Value.ToString());
            int years = date1_2.Year - date1_1.Year;
            int months = date1_2.Month - date1_1.Month;
            int days = date1_2.Day - date1_1.Day;
            years_all += years;
            months_all += months;
            days_all += days;
            Years.Text = Convert.ToString(years_all);
            Months.Text = Convert.ToString(months_all);
            Days.Text = Convert.ToString(days_all);
            TimeSpan diff_1 = date_2.Value - date_1.Value;
            overall += diff_1.Days;
            textBox1.Text = Convert.ToString(overall);
            if(months_all > 13) {
                years_all += 1;
                months_all -= 12;
            }
            if(days_all > 30) {
                months_all += 1;
                days_all -= 30;
            }
        } 
        public void substract_dates_single(DateTimePicker x, DateTimePicker y,TextBox a, TextBox b, TextBox c) {
            DateTimePicker date_1 = x;
            DateTimePicker date_2 = y;
            DateTime date1_1 = DateTime.Parse(date_1.Value.ToString());
            DateTime date1_2 = DateTime.Parse(date_2.Value.ToString());
            int years = date1_2.Year - date1_1.Year;
            int months = date1_2.Month - date1_1.Month;
            int days = date1_2.Day - date1_1.Day;
            if (months > 13)
            {
                years += 1;
                months -= 12;
            }
            if (days > 30)
            {
                months_all += 1;
                days -= 30;
            }
            a.Text = Convert.ToString(years);
            b.Text = Convert.ToString(months);
            c.Text = Convert.ToString(days);
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            reset();
            subtract_dates(Date1_1, Date1_2);
            substract_dates_single(Date1_1, Date1_2, Date1_years, Date1_months, Date1_days);
            subtract_dates(Date2_1, Date2_2);
            substract_dates_single(Date2_1, Date2_2, Date2_years, Date2_months, Date2_days);
            subtract_dates(Date3_1, Date3_2);
            substract_dates_single(Date3_1, Date3_2, Date3_years, Date3_months, Date3_days);
            subtract_dates(Date4_1, Date4_2);
            substract_dates_single(Date4_1, Date4_2, Date4_years, Date4_months, Date4_days);
            subtract_dates(Date5_1, Date5_2);
            substract_dates_single(Date5_1, Date5_2, Date5_years, Date5_months, Date5_days);
            subtract_dates(Date6_1, Date6_2);
            substract_dates_single(Date6_1, Date6_2, Date6_years, Date6_months, Date6_days);
            subtract_dates(Date7_1, Date7_2);
            substract_dates_single(Date7_1, Date7_2, Date7_years, Date7_months, Date7_days);
            subtract_dates(Date8_1, Date8_2);
            substract_dates_single(Date8_1, Date8_2, Date8_years, Date8_months, Date8_days);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public void hidden(Label a, Label b, Label c, TextBox d, TextBox e, TextBox f) {
            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            d.Visible = false;
            e.Visible = false;
            f.Visible = false;
        }
        public void visible(Label a, Label b, Label c, TextBox d, TextBox e, TextBox f)
        {
            a.Visible = true;
            b.Visible = true;
            c.Visible = true;
            d.Visible = true;
            e.Visible = true;
            f.Visible = true;
        }
        private void Add_cells_Click(object sender, EventArgs e)
        {           
            cells += 1;
            switch (cells) {
                case 2:
                Date2_1.Visible = true;
                Date2_2.Visible = true;
                visible(Date2_years_label, Date2_months_label, Date2_days_label, Date2_years, Date2_months, Date2_days);
                Remove_cells.Enabled = true;
                break;
                case 3:
                Date3_1.Visible = true;
                Date3_2.Visible = true;
                visible(Date3_years_label, Date3_months_label, Date3_days_label, Date3_years, Date3_months, Date3_days);
                break;
                case 4:
                Date4_1.Visible = true;
                Date4_2.Visible = true;
                visible(Date4_years_label, Date4_months_label, Date4_days_label, Date4_years, Date4_months, Date4_days);
                break;
                case 5:
                Date5_1.Visible = true;
                Date5_2.Visible = true;
                visible(Date5_years_label, Date5_months_label, Date5_days_label, Date5_years, Date5_months, Date5_days);
                break;
                case 6:
                Date6_1.Visible = true;
                Date6_2.Visible = true;
                visible(Date6_years_label, Date6_months_label, Date6_days_label, Date6_years, Date6_months, Date6_days);
                break;
                case 7:
                Date7_1.Visible = true;
                Date7_2.Visible = true;
                visible(Date7_years_label, Date7_months_label, Date7_days_label, Date7_years, Date7_months, Date7_days);
                break;
                case 8:
                Date8_1.Visible = true;
                Date8_2.Visible = true;
                visible(Date8_years_label, Date8_months_label, Date8_days_label, Date8_years, Date8_months, Date8_days);
                Add_cells.Enabled = false;
                break;              
            }
            
        }
        
        private void Remove_cells_Click(object sender, EventArgs e)
        {
            cells -= 1;
            DateTime def = DateTime.Now;
            switch (cells)
            {         
                case 1:
                Date2_1.Visible = false;
                hidden(Date2_years_label, Date2_months_label, Date2_days_label, Date2_years, Date2_months, Date2_days);
                Date2_1.Value = def;
                Date2_2.Visible = false;
                Date2_2.Value = def;
                Remove_cells.Enabled = false;
                break;
                case 2:
                Date3_1.Visible = false;
                hidden(Date3_years_label, Date3_months_label, Date3_days_label, Date3_years, Date3_months, Date3_days);
                Date3_1.Value = def;
                Date3_2.Visible = false;
                Date3_2.Value = def;
                break;
                case 3:
                Date4_1.Visible = false;
                hidden(Date4_years_label, Date4_months_label, Date4_days_label, Date4_years, Date4_months, Date4_days);
                Date4_1.Value = def;
                Date4_2.Visible = false;
                Date4_2.Value = def;
                break;
                case 4:
                Date5_1.Visible = false;
                hidden(Date5_years_label, Date5_months_label, Date5_days_label, Date5_years, Date5_months, Date5_days);
                Date5_1.Value = def;
                Date5_2.Visible = false;
                Date5_2.Value = def;
                break;
                case 5:
                Date6_1.Visible = false;
                hidden(Date6_years_label, Date6_months_label, Date6_days_label, Date6_years, Date6_months, Date6_days);
                Date6_1.Value = def;
                Date6_2.Visible = false;
                Date6_2.Value = def;
                break;
                case 6:
                Date7_1.Visible = false;
                hidden(Date7_years_label, Date7_months_label, Date7_days_label, Date7_years, Date7_months, Date7_days);
                Date7_1.Value = def;
                Date7_2.Visible = false;
                Date7_2.Value = def;
                break;
                case 7:
                Date8_1.Visible = false;
                hidden(Date8_years_label, Date8_months_label, Date8_days_label, Date8_years, Date8_months, Date8_days);
                Date8_1.Value = def;
                Date8_2.Visible = false;
                Date8_2.Value = def;
                Add_cells.Enabled = true;
                break;                
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Loc_rus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loc_eng();
        }
        public void Loc_eng() {
            Start_date.Text = "Start date";
            Start_date.Location = new Point(70, 9);
            End_date.Text = "End date";
            End_date.Location = new Point(310, 9);
            Years_label.Text = "Years";
            Years_label.Location = new Point(540, 72);
            Months_label.Text = "Months";
            Months_label.Location = new Point(610, 72);
            Days_label.Text = "Days";
            Days_label.Location = new Point(700, 72);
            Add_cells.Text = "Add field";
            Remove_cells.Text = "Remove field";
            Calculate.Text = "Calculate";
            Days_overall.Text = "Total number of days";
            Full_name.Text = "Full name";
            Full_name.Location = new Point(605, 14);
            Date1_years_label.Text = "Years";
            Date1_months_label.Text = "Months";
            Date1_days_label.Text = "Days";
            Date2_days_label.Text = "Days";
            Date2_years_label.Text = "Years";
            Date2_months_label.Text = "Months";
            Date3_days_label.Text = "Days";
            Date3_years_label.Text = "Years";
            Date3_months_label.Text = "Months";
            Date4_days_label.Text = "Days";
            Date4_years_label.Text = "Years";
            Date4_months_label.Text = "Months";
            Date5_days_label.Text = "Days";
            Date5_years_label.Text = "Years";
            Date5_months_label.Text = "Months";
            Date6_days_label.Text = "Days";
            Date6_years_label.Text = "Years";
            Date6_months_label.Text = "Months";
            Date7_years_label.Text = "Years";
            Date7_months_label.Text = "Months";
            Date7_days_label.Text = "Days";
            Date8_years_label.Text = "Years";
            Date8_months_label.Text = "Months";
            Date8_days_label.Text = "Days";


        }
        public void Loc_rus()
        {
            Start_date.Text = "Дата приема на работу";
            Start_date.Location = new Point(15, 9);
            End_date.Text = "Дата увольнения";
            End_date.Location = new Point(278, 9);
            Years_label.Text = "Лет";
            Years_label.Location = new Point(547, 72);
            Months_label.Text = "Месяцев";
            Months_label.Location = new Point(600, 72);
            Days_label.Text = "Дней";
            Days_label.Location = new Point(696, 72);
            Add_cells.Text = "Добавить поле";
            Remove_cells.Text = "Удалить поле";
            Calculate.Text = "Рассчитать";
            Days_overall.Text = "Общее кол-во дней";
            Full_name.Text = "ФИО";
            Full_name.Location = new Point(622, 14);
            Date1_years_label.Text = "Лет";
            Date1_months_label.Text = "Месяцев";
            Date1_days_label.Text = "Дней";
            Date2_years_label.Text = "Лет";
            Date2_months_label.Text = "Месяцев";
            Date2_days_label.Text = "Дней";
            Date3_years_label.Text = "Лет";
            Date3_months_label.Text = "Месяцев";
            Date3_days_label.Text = "Дней";
            Date4_years_label.Text = "Лет";
            Date4_months_label.Text = "Месяцев";
            Date4_days_label.Text = "Дней";
            Date5_years_label.Text = "Лет";
            Date5_months_label.Text = "Месяцев";
            Date5_days_label.Text = "Дней";
            Date6_years_label.Text = "Лет";
            Date6_months_label.Text = "Месяцев";
            Date6_days_label.Text = "Дней";
            Date7_years_label.Text = "Лет";
            Date7_months_label.Text = "Месяцев";
            Date7_days_label.Text = "Дней";
            Date8_years_label.Text = "Лет";
            Date8_months_label.Text = "Месяцев";
            Date8_days_label.Text = "Дней";
        }

        private void Months_label_Click(object sender, EventArgs e)
        {

        }
    }
}
