using EDUIsko.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUIsko
{
    public partial class Calendar1 : UserControl
    {
        int month, year;
        public Calendar1()
        {
            InitializeComponent();
        }

        private void Calendar1_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {

                Dayblank ucblank = new Dayblank();
                dayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                DayForCalendar ucdays = new DayForCalendar();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void Next1_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            if (month == 12)
            {
                month = 0;
                year++;
            }
            month++;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {

                Dayblank ucblank = new Dayblank();
                dayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                DayForCalendar ucdays = new DayForCalendar();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            if(month == 1)
            {
                month = 13;
                year--;
            }
            month--;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {

                Dayblank ucblank = new Dayblank();
                dayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                DayForCalendar ucdays = new DayForCalendar();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }
    }
}
