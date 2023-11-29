using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUIsko.User_Control
{
    public partial class DayForCalendar : UserControl
    {
        public DayForCalendar()
        {
            InitializeComponent();
        }

        private void DayForCalendar_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            DateLeft.Text = numday + "";
        }
    }
}
