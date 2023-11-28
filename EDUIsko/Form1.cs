using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUIsko
{
    public partial class Form1 : Form
    {
        bool Slide;
        bool UserControlSlide;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (Slide)
            {
                sideBarContainer.Width -= 10;
                home11.Left -= 9;
                notes11.Left -= 9;
                    if (sideBarContainer.Width == sideBarContainer.MinimumSize.Width)
                {
                    Slide = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBarContainer.Width += 10;
                home11.Left += 9;
                notes11.Left += 9;
                if (sideBarContainer.Width == sideBarContainer.MaximumSize.Width) {
                    Slide = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void Home_Click(object sender, EventArgs e)
        {

            home11.BringToFront();
            sideBarContainer.BringToFront();
        }

        private void NotePad_Click(object sender, EventArgs e)
        {
            notes11.BringToFront();
            sideBarContainer.BringToFront();
        }

        private void sideBarContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    }

