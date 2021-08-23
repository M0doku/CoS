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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
            subtract_dates(Date1_1, Date1_2);
            subtract_dates(Date2_1, Date2_2);
            subtract_dates(Date3_1, Date3_2);
            subtract_dates(Date4_1, Date4_2);
            subtract_dates(Date5_1, Date5_2);
            subtract_dates(Date6_1, Date6_2);
            subtract_dates(Date7_1, Date7_2);
            subtract_dates(Date8_1, Date8_2);
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

        private void Add_cells_Click(object sender, EventArgs e)
        {           
            cells += 1;
            switch (cells) {
                case 2:
                Date2_1.Visible = true;
                Date2_2.Visible = true;
                Remove_cells.Enabled = true;
                break;
                case 3:
                Date3_1.Visible = true;
                Date3_2.Visible = true;
                break;
                case 4:
                Date4_1.Visible = true;
                Date4_2.Visible = true;
                break;
                case 5:
                Date5_1.Visible = true;
                Date5_2.Visible = true;
                break;
                case 6:
                Date6_1.Visible = true;
                Date6_2.Visible = true;
                break;
                case 7:
                Date7_1.Visible = true;
                Date7_2.Visible = true;             
                break;
                case 8:
                Date8_1.Visible = true;
                Date8_2.Visible = true;
                Add_cells.Enabled = false;
                break;              
            }
            
        }

        private void Remove_cells_Click(object sender, EventArgs e)
        {
            cells -= 1;
            switch (cells)
            {         
                case 1:
                Date2_1.Visible = false;
                Date2_2.Visible = false;
                Remove_cells.Enabled = false;
                break;
                case 2:
                Date3_1.Visible = false;
                Date3_2.Visible = false;
                break;
                case 3:
                Date4_1.Visible = false;
                Date4_2.Visible = false;
                break;
                case 4:
                Date5_1.Visible = false;
                Date5_2.Visible = false;
                break;
                case 5:
                Date6_1.Visible = false;
                Date6_2.Visible = false;
                break;
                case 6:
                Date7_1.Visible = false;
                Date7_2.Visible = false;
                break;
                case 7:
                Date8_1.Visible = false;
                Date8_2.Visible = false;
                Add_cells.Enabled = true;
                break;                
            }
           
        }
    }
}
