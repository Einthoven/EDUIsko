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
    public partial class Pomodoro1 : UserControl
    {
        private int timeleft;
        public Pomodoro1()
        {
            InitializeComponent();
        }

        private void PomodoroButton_Click(object sender, EventArgs e)
        {
            this.timeleft = 25 * 60;
            Minute1.Text = (this.timeleft/ 60).ToString("00");
            Seconds1.Text = (this.timeleft % 60).ToString("00");
            PomodoroTimer1.Start();
        }

        private void PomodoroTimer1_Tick(object sender, EventArgs e)
        {
            if (this.timeleft == 0) {
                PomodoroTimer1.Stop();
                MessageBox.Show("TIme's up!");
            }
            else {
                this.timeleft--;
                Minute1.Text = (this.timeleft / 60).ToString("00");
                Seconds1.Text = (this.timeleft % 60).ToString("00");
            }
        }

        private void Start1_Click(object sender, EventArgs e)
        {
            PomodoroTimer1.Start();
        }

        private void Stop1_Click(object sender, EventArgs e)
        {
            PomodoroTimer1?.Stop();
        }

        private void ShortBreak_Click(object sender, EventArgs e)
        {
            this.timeleft = 1 * 60;
            Minute1.Text = (this.timeleft / 60).ToString("00");
            Seconds1.Text = (this.timeleft % 60).ToString("00");
            PomodoroTimer1.Start();
        }

        private void LongBreak_Click(object sender, EventArgs e)
        {
            this.timeleft = 15 * 60;
            Minute1.Text = (this.timeleft / 60).ToString("00");
            Seconds1.Text = (this.timeleft % 60).ToString("00");
            PomodoroTimer1.Start();
        }

        private void Reset1_Click(object sender, EventArgs e)
        {
            PomodoroTimer1.Stop();
            Minute1.Text = "00";
            Seconds1.Text = "00";
            this.timeleft = 0;
        }
    }
}
