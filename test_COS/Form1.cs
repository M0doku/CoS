using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace test_COS
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        DataTable data = new DataTable();
        
        public Form1()
        {
            InitializeComponent();
            First_years.Text = "0";
            First_months.Text = "0";
            First_days.Text = "0";
            Years.Text = "0";
            Months.Text = "0";
            Days.Text = "0";
            ped_years.Text = "0";
            ped_months.Text = "0";
            ped_days.Text = "0";
            this.DoubleBuffered = true;
            this.BackgroundImageLayout = ImageLayout.Center;
            DataRowCollection row_collection = data.Rows;
            Initilizatedata_table();
        }
        public void theme_1() {
            Form1.ActiveForm.BackgroundImage = Image.FromFile("C:\\Users\\Modoku\\Desktop\\CoS\\1.jpg");
        }
        public void theme_2() {
            Form1.ActiveForm.BackgroundImage = Image.FromFile("C:\\Users\\Modoku\\Desktop\\CoS\\2.jpg");
        }
        public void theme_3()
        {
            Form1.ActiveForm.BackgroundImage = Image.FromFile("C:\\Users\\Modoku\\Desktop\\CoS\\3.jpg");
        }
        public void standart_theme() {
            Form1.ActiveForm.BackgroundImage = null;
        }
        int years_all = 0;
        int months_all = 0;
        int days_all = 0;
        int overall = 0;
        int cells = 1;
        int cells_alt = 1;
        int days = 0;
        int months = 0;
        int years = 0;
        int years_all1 = 0;
        int months_all1 = 0;
        int days_all1 = 0;
        int rows = 0;
        public void reset() {
            years_all = 0;
            months_all = 0;
            days_all = 0;
            overall = 0;
        }
        public void reset_ped_stag(){
            First_years.Text = "0";
            First_months.Text = "0";
            First_days.Text = "0";
           
        }

        public void first_dates(System.Windows.Forms.TextBox a, System.Windows.Forms.TextBox b, System.Windows.Forms.TextBox c)
        {
            int first_years = int.Parse(First_years.Text);
            int first_months = int.Parse(First_months.Text);
            int first_days = int.Parse(First_days.Text);
            years_all = years_all + first_years;
            months_all = months_all + first_months;
            days_all = days_all + first_days;
            overall = overall + Convert.ToInt32(years_all * 360 + months_all * 30 + days_all);
            
        }
        public void ped_stag(System.Windows.Forms.TextBox a, System.Windows.Forms.TextBox b, System.Windows.Forms.TextBox c) {
            DateTime def = DateTime.Now;
            int years_ped = 0;
            int months_ped = 0;
            int days_ped = 0;
            int years_all_copy = 0;
            if (First_dates_checkbox.Checked == true && Convert.ToDateTime(alt_Date1_1.Value.Date) == def.Date)
            {
               
                    
                    years_ped = Convert.ToInt32(First_years.Text);
                    months_ped = Convert.ToInt32(First_months.Text);
                    days_ped = Convert.ToInt32(First_days.Text);
            
            
            }
            else 
            {
                int def_int = 0;
                string def_str = Convert.ToString(def_int);
                a.Text = def_str; b.Text = def_str; c.Text = def_str;
            }
            reset();
           
           
            years_all_copy = Convert.ToInt32(Years.Text);
            int months_all_copy = Convert.ToInt32(Months.Text);
            int days_all_copy = Convert.ToInt32(Days.Text);
            int years_copy = Convert.ToInt32(ped_years.Text);
            int months_copy = Convert.ToInt32(ped_months.Text);
            int days_copy = Convert.ToInt32(ped_days.Text);
            
            
            years_all1 = years_all - years_all + years_all + years_copy + years_ped;
            months_all1 = months_all - months_all + months_all + months_copy + months_ped;
            days_all1 = days_all - days_all + days_all + days_copy + days_ped;
            if(months_all1 > 12) {
                years_all1 += 1;
                months_all1 -= 12;
            }
            if(days_all1 > 30) {
                months_all1 += 1;
                days_all1 -= 30;
            }
            
            Years.Text = Convert.ToString(years_all1);
            Months.Text = Convert.ToString(months_all1);
            Days.Text = Convert.ToString(days_all1);
        }
        public void subtract_dates(DateTimePicker x, DateTimePicker y, System.Windows.Forms.TextBox a, System.Windows.Forms.TextBox b, System.Windows.Forms.TextBox c) {
            DateTimePicker date_1 = x;
            DateTimePicker date_2 = y;
            DateTime date1_1 = DateTime.Parse(date_1.Value.ToString());
            DateTime date1_2 = DateTime.Parse(date_2.Value.ToString());
            int months = 0;
            int years = 0;
            string Name = a.Name;
            if (date1_2.Month < date1_1.Month && date1_1.Year == date1_2.Year - 1)
            {
                months = date1_2.Month + 12 - date1_1.Month;
                years = 0;
            }
            else {
                months = date1_2.Month - date1_1.Month;
            }
            years = date1_2.Year - date1_1.Year;
            if (date1_2.Month < date1_1.Month)
            {
                months = date1_2.Month + 12 - date1_1.Month;
                years -= 1;
            }

            int days = date1_2.Day - date1_1.Day;
            if (date1_2.Day < date1_1.Day)
            {
                if (months > 0)
                {
                    days = (date1_2.Day - date1_1.Day) + 30;
                    months -= 1;
                   
                }
                else
                {
                    days = (date1_2.Day - date1_1.Day) + 30;
                }
            }
            else
            {
                days = date1_2.Day - date1_1.Day;
            }
            if (months > 13)
            {
                years += 1;
                months -= 12;
            }
            if (days > 30)
            {
                months += 1;
                days -= 30;
            }
            if(months_all + months > 12) {
                years_all += 1;
                months_all -= 12;
            }
            if(days_all + days > 30) {
                months_all += 1;
                days_all -= 30;
            }
            years_all += years;
            months_all += months;
            days_all += days;

            
           
                a.Text = Convert.ToString(years_all);
                b.Text = Convert.ToString(months_all);
                c.Text = Convert.ToString(days_all);
           
           
        } 
        public void all_days(System.Windows.Forms.TextBox a,System.Windows.Forms.TextBox b, System.Windows.Forms.TextBox c) {
            int years_o = Convert.ToInt32(a.Text);
            int months_o = Convert.ToInt32(b.Text);
            int days_o = Convert.ToInt32(c.Text);
            textBox1.Text = Convert.ToString((years_o * 360)+ (months_o * 30) + days_o);
        }
        public void substract_dates_single(DateTimePicker x, DateTimePicker y,System.Windows.Forms.TextBox a, System.Windows.Forms.TextBox b, System.Windows.Forms.TextBox c) {
            DateTimePicker date_1 = x;
            DateTimePicker date_2 = y;
            DateTime date1_1 = DateTime.Parse(date_1.Value.ToString());
            DateTime date1_2 = DateTime.Parse(date_2.Value.ToString());
            months = 0;
            years = 0;
            days = 0;
            if (date1_2.Month < date1_1.Month && date1_1.Year == date1_2.Year - 1)
            {
                months = date1_2.Month + 12 - date1_1.Month;
                years = 0;
            }
            else
            {
                months = date1_2.Month - date1_1.Month;
            }
            years = date1_2.Year - date1_1.Year;
            if (date1_2.Month < date1_1.Month)
            {
                months = date1_2.Month + 12 - date1_1.Month;
                years -= 1;
            }
           
            if (date1_2.Day < date1_1.Day)
            {
                if (months > 0)
                {
                    days = (date1_2.Day - date1_1.Day) + 30;
                    months -= 1;
                    
                }
                else {
                    days = (date1_2.Day - date1_1.Day) + 30;
                }
            }
            else
            {
                days = date1_2.Day - date1_1.Day;
            }
            if (months > 13)
            {
                years += 1;
                months -= 12;
            }
            if (days > 30)
            {
                months += 1;
                days -= 30;
            }
          
            a.Text = Convert.ToString(years);
            b.Text = Convert.ToString(months);
            c.Text = Convert.ToString(days);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            
            //ОБЩИЙ СТАЖ
            //Первый столбец подсчета общего стажа 
            reset();
            subtract_dates(Date1_1, Date1_2, Years, Months, Days);
            substract_dates_single(Date1_1, Date1_2, Date1_years, Date1_months, Date1_days);
            subtract_dates(Date2_1, Date2_2, Years, Months, Days);
            substract_dates_single(Date2_1, Date2_2, Date2_years, Date2_months, Date2_days);
            subtract_dates(Date3_1, Date3_2, Years, Months, Days);
            substract_dates_single(Date3_1, Date3_2, Date3_years, Date3_months, Date3_days);
            subtract_dates(Date4_1, Date4_2, Years, Months, Days);
            substract_dates_single(Date4_1, Date4_2, Date4_years, Date4_months, Date4_days);
            subtract_dates(Date5_1, Date5_2, Years, Months, Days);
            substract_dates_single(Date5_1, Date5_2, Date5_years, Date5_months, Date5_days);
            subtract_dates(Date6_1, Date6_2, Years, Months, Days);
            substract_dates_single(Date6_1, Date6_2, Date6_years, Date6_months, Date6_days);
            subtract_dates(Date7_1, Date7_2, Years, Months, Days);
            substract_dates_single(Date7_1, Date7_2, Date7_years, Date7_months, Date7_days);
            subtract_dates(Date8_1, Date8_2, Years, Months, Days);
            substract_dates_single(Date8_1, Date8_2, Date8_years, Date8_months, Date8_days);
            //Педагогический стаж
            reset();
            subtract_dates(Date1_1, Date1_2, ped_years, ped_months, ped_days);
            subtract_dates(Date2_1, Date2_2, ped_years, ped_months, ped_days);
            subtract_dates(Date3_1, Date3_2, ped_years, ped_months, ped_days);
            subtract_dates(Date4_1, Date4_2, ped_years, ped_months, ped_days);
            subtract_dates(Date5_1, Date5_2, ped_years, ped_months, ped_days);
            subtract_dates(Date6_1, Date6_2, ped_years, ped_months, ped_days);
            subtract_dates(Date7_1, Date7_2, ped_years, ped_months, ped_days);
            subtract_dates(Date8_1, Date8_2, ped_years, ped_months, ped_days);
            
            //Второй столбец подсчета общего стажа
            if (First_dates_checkbox.Checked == false) {
                
                subtract_dates(alt_Date1_1, alt_Date1_2, Years, Months, Days);
                substract_dates_single(alt_Date1_1, alt_Date1_2, alt_Date1_years, alt_Date1_months, alt_Date1_days);
                subtract_dates(alt_Date2_1, alt_Date2_2, Years, Months, Days);
                substract_dates_single(alt_Date2_1, alt_Date2_2, alt_Date2_years, alt_Date2_months, alt_Date2_days);
                subtract_dates(alt_Date3_1, alt_Date3_2, Years, Months, Days);
                substract_dates_single(alt_Date3_1, alt_Date3_2, alt_Date3_years, alt_Date3_months, alt_Date3_days);
                subtract_dates(alt_Date4_1, alt_Date4_2, Years, Months, Days);
                substract_dates_single(alt_Date4_1, alt_Date4_2, alt_Date4_years, alt_Date4_months, alt_Date4_days);
                subtract_dates(alt_Date5_1, alt_Date5_2, Years, Months, Days);
                substract_dates_single(alt_Date5_1, alt_Date5_2, alt_Date5_years, alt_Date5_months, alt_Date5_days);
                subtract_dates(alt_Date6_1, alt_Date6_2, Years, Months, Days);
                substract_dates_single(alt_Date6_1, alt_Date6_2, alt_Date6_years, alt_Date6_months, alt_Date6_days);
                subtract_dates(alt_Date7_1, alt_Date7_2, Years, Months, Days);
                substract_dates_single(alt_Date7_1, alt_Date7_2, alt_Date7_years, alt_Date7_months, alt_Date7_days);
                subtract_dates(alt_Date8_1, alt_Date8_2, Years, Months, Days);
                substract_dates_single(alt_Date8_1, alt_Date8_2, alt_Date8_years, alt_Date8_months, alt_Date8_days);
                //Первоначальный стаж


                reset();
                subtract_dates(alt_Date1_1, alt_Date1_2, First_years, First_months, First_days);
                subtract_dates(alt_Date2_1, alt_Date2_2, First_years, First_months, First_days);
                subtract_dates(alt_Date3_1, alt_Date3_2, First_years, First_months, First_days);
                subtract_dates(alt_Date4_1, alt_Date4_2, First_years, First_months, First_days);
                subtract_dates(alt_Date5_1, alt_Date5_2, First_years, First_months, First_days);
                subtract_dates(alt_Date6_1, alt_Date6_2, First_years, First_months, First_days);
                subtract_dates(alt_Date7_1, alt_Date7_2, First_years, First_months, First_days);
                subtract_dates(alt_Date8_1, alt_Date8_2, First_years, First_months, First_days);
                reset();
            }
            else if(First_dates_checkbox.Checked == true) {
                
                ped_stag(First_years, First_months, First_days);
            }
            all_days(Years, Months, Days);


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
        public void hidden(Label a, Label b, Label c, System.Windows.Forms.TextBox d, System.Windows.Forms.TextBox e, System.Windows.Forms.TextBox f) {
            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            d.Visible = false;
            e.Visible = false;
            f.Visible = false;
        }
        public void visible(Label a, Label b, Label c, System.Windows.Forms.TextBox d, System.Windows.Forms.TextBox e, System.Windows.Forms.TextBox f)
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
                number_2.Visible = true;
                visible(Date2_years_label, Date2_months_label, Date2_days_label, Date2_years, Date2_months, Date2_days);
                Remove_cells.Enabled = true;
                break;
                case 3:
                Date3_1.Visible = true;
                Date3_2.Visible = true;
                number_3.Visible = true;
                visible(Date3_years_label, Date3_months_label, Date3_days_label, Date3_years, Date3_months, Date3_days);
                break;
                case 4:
                Date4_1.Visible = true;
                Date4_2.Visible = true;
                number_4.Visible = true;
                visible(Date4_years_label, Date4_months_label, Date4_days_label, Date4_years, Date4_months, Date4_days);
                break;
                case 5:
                Date5_1.Visible = true;
                Date5_2.Visible = true;
                number_5.Visible = true;
                visible(Date5_years_label, Date5_months_label, Date5_days_label, Date5_years, Date5_months, Date5_days);
                break;
                case 6:
                Date6_1.Visible = true;
                Date6_2.Visible = true;
                number_6.Visible = true;
                visible(Date6_years_label, Date6_months_label, Date6_days_label, Date6_years, Date6_months, Date6_days);
                break;
                case 7:
                Date7_1.Visible = true;
                Date7_2.Visible = true;
                number_7.Visible = true;
                visible(Date7_years_label, Date7_months_label, Date7_days_label, Date7_years, Date7_months, Date7_days);
                break;
                case 8:
                Date8_1.Visible = true;
                Date8_2.Visible = true;
                number_8.Visible = true;
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
                number_2.Visible = false;
                Date2_2.Value = def;
                Remove_cells.Enabled = false;
                break;
                case 2:
                Date3_1.Visible = false;
                hidden(Date3_years_label, Date3_months_label, Date3_days_label, Date3_years, Date3_months, Date3_days);
                Date3_1.Value = def;
                Date3_2.Visible = false;
                number_3.Visible = false;
                Date3_2.Value = def;
                break;
                case 3:
                Date4_1.Visible = false;
                hidden(Date4_years_label, Date4_months_label, Date4_days_label, Date4_years, Date4_months, Date4_days);
                Date4_1.Value = def;
                Date4_2.Visible = false;
                number_4.Visible = false;
                Date4_2.Value = def;
                break;
                case 4:
                Date5_1.Visible = false;
                hidden(Date5_years_label, Date5_months_label, Date5_days_label, Date5_years, Date5_months, Date5_days);
                Date5_1.Value = def;
                Date5_2.Visible = false;
                number_5.Visible = false;
                Date5_2.Value = def;
                break;
                case 5:
                Date6_1.Visible = false;
                hidden(Date6_years_label, Date6_months_label, Date6_days_label, Date6_years, Date6_months, Date6_days);
                Date6_1.Value = def;
                Date6_2.Visible = false;
                number_6.Visible = false;
                Date6_2.Value = def;
                break;
                case 6:
                Date7_1.Visible = false;
                hidden(Date7_years_label, Date7_months_label, Date7_days_label, Date7_years, Date7_months, Date7_days);
                Date7_1.Value = def;
                Date7_2.Visible = false;
                number_7.Visible = false;
                Date7_2.Value = def;
                break;
                case 7:
                Date8_1.Visible = false;
                hidden(Date8_years_label, Date8_months_label, Date8_days_label, Date8_years, Date8_months, Date8_days);
                Date8_1.Value = def;
                Date8_2.Visible = false;
                number_8.Visible = false;
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
            Years_label.Location = new Point(540, 201);
            Months_label.Text = "Months";
            Months_label.Location = new Point(610, 201);
            Days_label.Text = "Days";
            Days_label.Location = new Point(700, 201);
            original_years_label.Text = "Years";
            original_years_label.Location = new Point(540, 103);
            original_months_label.Text = "Months";
            original_months_label.Location = new Point(610, 103);
            original_days_label.Text = "Days";
            original_days_label.Location = new Point(700, 103);
            original_date.Text = "Initial expirience";
            original_date.Location = new Point(568, 75);
            total_expirience.Text = "The total expirience is:";
            total_expirience.Location = new Point(545, 167);
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
            Years_label.Location = new Point(547, 201);
            Months_label.Text = "Месяцев";
            Months_label.Location = new Point(600, 201);
            Days_label.Text = "Дней";
            Days_label.Location = new Point(696, 201);
            original_years_label.Text = "Лет";
            original_years_label.Location = new Point(547, 103);
            original_months_label.Text = "Месяцев";
            original_months_label.Location = new Point(600, 103);
            original_days_label.Text = "Дней";
            original_days_label.Location = new Point(696, 103);
            original_date.Text = "Первоначальный стаж";
            original_date.Location = new Point(542, 75);
            total_expirience.Text = "Общий стаж составляет:";
            total_expirience.Location = new Point(536, 167);
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
        
        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void First_years_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            theme_1();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            theme_2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            theme_3();
        }

        private void Standart_theme_button_Click(object sender, EventArgs e)
        {
            standart_theme();
        }

        private void End_date_Click(object sender, EventArgs e)
        {

        }

        private void alt_Add_cells_Click(object sender, EventArgs e)
        {
            cells_alt += 1;
            switch (cells_alt)
            {
                case 2:
                alt_Date2_1.Visible = true;
                alt_Date2_2.Visible = true;
                alt_number_2.Visible = true;
                visible(alt_Date2_years_label, alt_Date2_months_label, alt_Date2_days_label, alt_Date2_years, alt_Date2_months, alt_Date2_days);
                alt_Remove_cells.Enabled = true;
                break;
                case 3:
                alt_Date3_1.Visible = true;
                alt_Date3_2.Visible = true;
                alt_number_3.Visible = true;
                visible(alt_Date3_years_label, alt_Date3_months_label, alt_Date3_days_label, alt_Date3_years, alt_Date3_months, alt_Date3_days);
                break;
                case 4:
                alt_Date4_1.Visible = true;
                alt_Date4_2.Visible = true;
                alt_number_4.Visible = true;
                visible(alt_Date4_years_label, alt_Date4_months_label, alt_Date4_days_label, alt_Date4_years, alt_Date4_months, alt_Date4_days);
                break;
                case 5:
                alt_Date5_1.Visible = true;
                alt_Date5_2.Visible = true;
                alt_number_5.Visible = true;
                visible(alt_Date5_years_label, alt_Date5_months_label, alt_Date5_days_label, alt_Date5_years, alt_Date5_months, alt_Date5_days);
                break;
                case 6:
                alt_Date6_1.Visible = true;
                alt_Date6_2.Visible = true;
                alt_number_6.Visible = true;
                visible(alt_Date6_years_label, alt_Date6_months_label, alt_Date6_days_label, alt_Date6_years, alt_Date6_months, alt_Date6_days);
                break;
                case 7:
                alt_Date7_1.Visible = true;
                alt_Date7_2.Visible = true;
                alt_number_7.Visible = true;
                visible(alt_Date7_years_label, alt_Date7_months_label, alt_Date7_days_label, alt_Date7_years, alt_Date7_months, alt_Date7_days);
                break;
                case 8:
                alt_Date8_1.Visible = true;
                alt_Date8_2.Visible = true;
                alt_number_8.Visible = true;
                visible(alt_Date8_years_label, alt_Date8_months_label, alt_Date8_days_label, alt_Date8_years, alt_Date8_months, alt_Date8_days);
                alt_Add_cells.Enabled = false;
                break;
            }
        }

        private void alt_Remove_cells_Click(object sender, EventArgs e)
        {
            cells_alt -= 1;
            DateTime def = DateTime.Now;
            switch (cells_alt)
            {
                case 1:
                alt_Date2_1.Visible = false;
                hidden(alt_Date2_years_label, alt_Date2_months_label, alt_Date2_days_label, alt_Date2_years, alt_Date2_months, alt_Date2_days);
                alt_Date2_1.Value = def;
                alt_Date2_2.Visible = false;
                alt_number_2.Visible = false;
                alt_Date2_2.Value = def;
                alt_Remove_cells.Enabled = false;
                break;
                case 2:
                alt_Date3_1.Visible = false;
                hidden(alt_Date3_years_label, alt_Date3_months_label, alt_Date3_days_label, alt_Date3_years, alt_Date3_months, alt_Date3_days);
                alt_Date3_1.Value = def;
                alt_Date3_2.Visible = false;
                alt_number_3.Visible = false;
                alt_Date3_2.Value = def;
                break;
                case 3:
                alt_Date4_1.Visible = false;
                hidden(alt_Date4_years_label, alt_Date4_months_label, alt_Date4_days_label, alt_Date4_years, alt_Date4_months, alt_Date4_days);
                alt_Date4_1.Value = def;
                alt_Date4_2.Visible = false;
                alt_number_4.Visible = false;
                alt_Date4_2.Value = def;
                break;
                case 4:
                alt_Date5_1.Visible = false;
                hidden(alt_Date5_years_label, alt_Date5_months_label, alt_Date5_days_label, alt_Date5_years, alt_Date5_months, alt_Date5_days);
                alt_Date5_1.Value = def;
                alt_Date5_2.Visible = false;
                alt_number_5.Visible = false;
                alt_Date5_2.Value = def;
                break;
                case 5:
                alt_Date6_1.Visible = false;
                hidden(alt_Date6_years_label, alt_Date6_months_label, alt_Date6_days_label, alt_Date6_years, alt_Date6_months, alt_Date6_days);
                alt_Date6_1.Value = def;
                alt_Date6_2.Visible = false;
                alt_number_6.Visible = false;
                alt_Date6_2.Value = def;
                break;
                case 6:
                alt_Date7_1.Visible = false;
                hidden(alt_Date7_years_label, alt_Date7_months_label, alt_Date7_days_label, alt_Date7_years, alt_Date7_months, alt_Date7_days);
                alt_Date7_1.Value = def;
                alt_Date7_2.Visible = false;
                alt_number_7.Visible = false;
                alt_Date7_2.Value = def;
                break;
                case 7:
                alt_Date8_1.Visible = false;
                hidden(alt_Date8_years_label, alt_Date8_months_label, alt_Date8_days_label, alt_Date8_years, alt_Date8_months, alt_Date8_days);
                alt_Date8_1.Value = def;
                alt_Date8_2.Visible = false;
                alt_number_8.Visible = false;
                alt_Date8_2.Value = def;
                alt_Add_cells.Enabled = true;
                break;
            }
        }

        private void First_dates_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (First_dates_checkbox.Checked == true )
            {
                alt_Date1_1.Enabled = false;
                alt_Date1_2.Enabled = false;
                alt_Add_cells.Enabled = false;
                First_years.ReadOnly = false; 
                First_months.ReadOnly = false;
                First_days.ReadOnly = false;
                int def_int = 0;
                string def_str = Convert.ToString(def_int);
                DateTime def = DateTime.Now;
                alt_Date1_1.Value = def; alt_Date1_2.Value = def;
                alt_Date2_1.Value = def; alt_Date2_2.Value = def;
                alt_Date3_1.Value = def; alt_Date3_2.Value = def;
                alt_Date4_1.Value = def; alt_Date4_2.Value = def;
                alt_Date5_1.Value = def; alt_Date5_2.Value = def;
                alt_Date6_1.Value = def; alt_Date6_2.Value = def;
                alt_Date7_1.Value = def; alt_Date7_2.Value = def;
                alt_Date8_1.Value = def; alt_Date8_2.Value = def;
                
                alt_Date1_years.Text = def_str; alt_Date1_months.Text = def_str; alt_Date1_days.Text = def_str;
                alt_Date2_years.Text = def_str; alt_Date2_months.Text = def_str; alt_Date2_days.Text = def_str;
                alt_Date3_years.Text = def_str; alt_Date3_months.Text = def_str; alt_Date3_days.Text = def_str;
                alt_Date4_years.Text = def_str; alt_Date4_months.Text = def_str; alt_Date4_days.Text = def_str;
                alt_Date5_years.Text = def_str; alt_Date5_months.Text = def_str; alt_Date5_days.Text = def_str;
                alt_Date6_years.Text = def_str; alt_Date6_months.Text = def_str; alt_Date6_days.Text = def_str;
                alt_Date7_years.Text = def_str; alt_Date7_months.Text = def_str; alt_Date7_days.Text = def_str;
                alt_Date8_years.Text = def_str; alt_Date8_months.Text = def_str; alt_Date8_days.Text = def_str;
                First_years.Text = "0"; First_months.Text = "0"; First_days.Text = "0";
            }
            else if(First_dates_checkbox.Checked == true &&((First_years.Text != "0") || (First_months.Text != "0") || (First_days.Text != "0"))) {
             
            }
            else if (First_dates_checkbox.Checked == false)
            {
                int def_int = 0;
                string def_str = Convert.ToString(def_int);
                alt_Date1_1.Enabled = true;
                alt_Date1_2.Enabled = true;
                alt_Add_cells.Enabled = true;
                First_years.ReadOnly = true;
                First_months.ReadOnly = true;
                First_days.ReadOnly = true;
               
               
            }
        }

        private void Excel_export_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sample Sheet");
                worksheet.Cell("A1").Value = "ФИО";
                worksheet.Cell("B1").Value = "Должность";
                worksheet.Cell("C1").Value = "Педагогический стаж";
                worksheet.Cell("D1").Value = "Не педагогический стаж";
                worksheet.Cell("E1").Value = "Общий стаж";
                for (int i = 1; i < data_table.Rows.Count + 1; i++)
                {
                    for (int j = 0; j < data_table.ColumnCount; j++)
                    {
                        worksheet.Cell(i + 1, j + 1).Value = data_table.Rows[i - 1].Cells[j ].Value;
                    }
                }
                
                workbook.SaveAs("WorkExpirience.xlsx");
                
            }
        }
        private void FullName_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void Initilizatedata_table() {
            
            DataColumn Name = new DataColumn();
            Name.DataType = System.Type.GetType("System.String");
            Name.ColumnName = "ФИО";
            data.Columns.Add(Name);
            DataColumn post = new DataColumn();
            post.DataType = System.Type.GetType("System.String");
            post.ColumnName = "Должность";
            data.Columns.Add(post);
            DataColumn ped_stag = new DataColumn();
            ped_stag.DataType = System.Type.GetType("System.String");
            ped_stag.ColumnName = "Педагогический стаж";
            data.Columns.Add(ped_stag);
            DataColumn ne_ped_stag = new DataColumn();
            ne_ped_stag.DataType = System.Type.GetType("System.String");
            ne_ped_stag.ColumnName = "Не педагогический стаж";
            data.Columns.Add(ne_ped_stag);
            DataColumn overall_stag = new DataColumn();
            overall_stag.DataType = System.Type.GetType("System.String");
            overall_stag.ColumnName = "Общий стаж";
            data.Columns.Add(overall_stag);
            data_table.DataSource = data;
        }
        public void add_rows()
        {
            
            DataRow row;
            int rows_count = data_table.RowCount;
            row = data.NewRow();
            row["ФИО"] = (FullName_text.Text);
            row["Должность"] = (Post_text.Text);
            row["Педагогический стаж"] = ($"{ped_years.Text} л, {ped_months.Text} м, {ped_days.Text} д");
            row["Не педагогический стаж"] = ($"{First_years.Text} л, {First_months.Text} м, {First_days.Text} д");
            row["Общий стаж"] = ($"{Years.Text} л, {Months.Text} м, {Days.Text} д");
            data.Rows.Add(row);



            data_table.DataSource = data;
        }
        private void add_data_Click(object sender, EventArgs e)
        {
        

            add_rows();
            
           
            
            rows += 1;
            if (rows > 0) {
                Excel_export.Enabled = true;
            }
        }

        private void delete_data_Click(object sender, EventArgs e)
        {

            if (rows < 1)
            {
                rows = 0;

            }
            else
            {
                rows = data.Rows.Count;
                data_table.Rows.RemoveAt(rows - 1);

                rows -= 1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_all_Click(object sender, EventArgs e)
        {
            FullName_text.Text = "";
            Post_text.Text = "";
            int def_int = 0;
            string def_str = Convert.ToString(def_int);
            DateTime def = DateTime.Now;
            alt_Date1_1.Value = def; alt_Date1_2.Value = def;
            alt_Date2_1.Value = def; alt_Date2_2.Value = def;
            alt_Date3_1.Value = def; alt_Date3_2.Value = def;
            alt_Date4_1.Value = def; alt_Date4_2.Value = def;
            alt_Date5_1.Value = def; alt_Date5_2.Value = def;
            alt_Date6_1.Value = def; alt_Date6_2.Value = def;
            alt_Date7_1.Value = def; alt_Date7_2.Value = def;
            alt_Date8_1.Value = def; alt_Date8_2.Value = def;
            Date1_1.Value = def; Date1_2.Value = def;
            Date2_1.Value = def; Date2_2.Value = def;
            Date3_1.Value = def; Date3_2.Value = def;
            Date4_1.Value = def; Date4_2.Value = def;
            Date5_1.Value = def; Date5_2.Value = def;
            Date6_1.Value = def; Date6_2.Value = def;
            Date7_1.Value = def; Date7_2.Value = def;
            Date8_1.Value = def; Date8_2.Value = def;

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            SaveFileDialog save_excel = new SaveFileDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            open_excel.ShowDialog();
        }
        
        private void open_excel_FileOk(object sender, CancelEventArgs e)
        {
            
            string Filepath = open_excel.FileName;
            using (XLWorkbook workbook = new XLWorkbook(Filepath)) {
                IXLWorksheet workSheet = workbook.Worksheet(1);
                DataTable Excel_file = new DataTable();
                bool FirstRow = true;
             
                foreach (IXLRow row in workSheet.Rows()) {
                if(FirstRow) {
                        
                foreach(IXLCell cell in row.Cells()) {
                        Excel_file.Columns.Add(cell.Value.ToString());
                }
                     FirstRow = false;
                }
                else {
                        Excel_file.Rows.Add();
                        int i = 0;
                        foreach(IXLCell cell in row.Cells()) {
                            Excel_file.Rows[Excel_file.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }
                }
                    
                    data_table.DataSource = Excel_file;
                    data = Excel_file;
                    }
            }
        }

        private void Date8_days_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date1_days_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date2_years_label_Click(object sender, EventArgs e)
        {

        }
        public void chg(int j) {
            for (int i = 0; i < rows; i++)
            {

                string value_date = data_table[j, i].Value.ToString();

                value_date = value_date.Replace("л", "");
                value_date = value_date.Replace("м", "");
                value_date = value_date.Replace("д", "");
                value_date = value_date.Replace(",", "");
                string year_p = "";
                year_p = value_date.Remove(2);

                if (Convert.ToInt32(year_p) < 10)
                {
                    year_p = year_p.Remove(1);
                }

                string month_p = "";
                if (year_p.Length == 2)
                {
                    month_p = value_date.Remove(0, 4);
                    month_p = month_p.Remove(2);
                }
                else if (year_p.Length == 1)
                {
                    month_p = value_date.Remove(0, 3);
                    month_p = month_p.Remove(2);
                }
                if (Convert.ToInt32(month_p) < 10)
                {
                    month_p = month_p.Remove(1);
                }
                string day_p = "";
                if (year_p.Length == 2 && month_p.Length == 2)
                {
                    day_p = value_date.Remove(0, 8);
                    day_p = day_p.Remove(2);
                }
                else if (year_p.Length == 1 && month_p.Length == 1)
                {
                    day_p = value_date.Remove(0, 6);
                    if (Convert.ToInt32(day_p) > 10)
                    {
                        day_p = day_p.Remove(2);
                    }
                    else if (Convert.ToInt32(day_p) < 10)
                    {
                        day_p = day_p.Remove(1);
                    }
                }
                else if (year_p.Length == 2 || month_p.Length == 2)
                {
                    day_p = value_date.Remove(0, 7);
                    if (Convert.ToInt32(day_p) > 10)
                    {
                        day_p = day_p.Remove(2);
                    }
                    else if (Convert.ToInt32(day_p) < 10)
                    {
                        day_p = day_p.Remove(1);
                    }
                }






                int year_a = Convert.ToInt32(year_p);
                int month_a = Convert.ToInt32(month_p);
                int day_a = Convert.ToInt32(day_p);
                month_a = month_a + Convert.ToInt32(months_add_box.Text);
                if (month_a > 12)
                {
                    year_a += 1;
                    month_a -= 12;
                }
                data_table[j, i].Value = ($"{year_a} л, {month_a} м, {day_a} д ");
               
                }
        }
        private void add_months_button_Click(object sender, EventArgs e)
        {

            chg(2);
            chg(4);
            months_add_box.Text = "0";
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
