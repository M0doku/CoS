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
        public void subtract_dates(DateTimePicker x, DateTimePicker y) {
            DateTimePicker date_1 = x;
            DateTime date1 = DateTime.Parse(date_1.Value.ToString());
            DateTime date2 = DateTime.Parse(Date_2.Value.ToString());
            int years = date2.Year - date1.Year;
            int months = date2.Month - date1.Month;
            int days = date2.Day - date1.Day;
            Years.Text = Convert.ToString(years);
            Months.Text = Convert.ToString(months);
            Days.Text = Convert.ToString(days);
            DateTimePicker date_2 = y;
            TimeSpan diff = date_2.Value - date_1.Value;
            int overall = diff.Days;
            textBox1.Text = Convert.ToString(overall);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subtract_dates(Date_1, Date_2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
