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
            string facebookUrl = "https://www.facebook.com/profile.php?id=61551647981109&mibextid=9R9pXO";

            Process.Start(facebookUrl);
        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            string twitterURL = "https://twitter.com/EduIsko21362";

            Process.Start(twitterURL);
        }

        private void Instagram_Click(object sender, EventArgs e)
        {
            string InstagramURL = "https://www.instagram.com/eduisko/";

            Process.Start(InstagramURL);
        }
    }
}
