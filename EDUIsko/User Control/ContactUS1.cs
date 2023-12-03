using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUIsko.User_Control
{
    public partial class ContactUS1 : UserControl
    {
        public ContactUS1()
        {
            InitializeComponent();
        }

        private void Facebook_Click(object sender, EventArgs e)
        {
            string facebookUrl = "https://www.facebook.com/KARYLE.EXO";

            Process.Start(facebookUrl);
        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            string twitterURL = "https://x.com/ae_klry?t=a0qsIexlCdDnEwq4JCf12w&s=09";

            Process.Start(twitterURL);
        }

        private void Instagram_Click(object sender, EventArgs e)
        {
            string InstagramURL = "https://instagram.com/https.kryl?igshid=NGVhN2U2NjQ0Yg==";

            Process.Start(InstagramURL);
        }
    }
}
