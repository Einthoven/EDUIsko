namespace EDUIsko.User_Control
{
    partial class ContactUS1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Instagram = new System.Windows.Forms.PictureBox();
            this.Twitter = new System.Windows.Forms.PictureBox();
            this.Facebook = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Instagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facebook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(275, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 51);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Us";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(58, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 179);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 89);
            this.label2.TabIndex = 0;
            this.label2.Text = "You can contact us in our social media accounts if you ever found any unforeseen " +
    "bugs, or if you have any suggestion to improve EDUIsko.\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 89);
            this.label3.TabIndex = 1;
            this.label3.Text = "We strive to respond to all inquiries within 24 hours";
            // 
            // Instagram
            // 
            this.Instagram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Instagram.Image = global::EDUIsko.Properties.Resources.insta;
            this.Instagram.Location = new System.Drawing.Point(472, 318);
            this.Instagram.Name = "Instagram";
            this.Instagram.Size = new System.Drawing.Size(111, 70);
            this.Instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Instagram.TabIndex = 2;
            this.Instagram.TabStop = false;
            this.Instagram.Click += new System.EventHandler(this.Instagram_Click);
            // 
            // Twitter
            // 
            this.Twitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Twitter.Image = global::EDUIsko.Properties.Resources.twt;
            this.Twitter.Location = new System.Drawing.Point(317, 318);
            this.Twitter.Name = "Twitter";
            this.Twitter.Size = new System.Drawing.Size(111, 70);
            this.Twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Twitter.TabIndex = 1;
            this.Twitter.TabStop = false;
            this.Twitter.Click += new System.EventHandler(this.Twitter_Click);
            // 
            // Facebook
            // 
            this.Facebook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Facebook.Image = global::EDUIsko.Properties.Resources.fb;
            this.Facebook.Location = new System.Drawing.Point(169, 318);
            this.Facebook.Name = "Facebook";
            this.Facebook.Size = new System.Drawing.Size(111, 70);
            this.Facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Facebook.TabIndex = 0;
            this.Facebook.TabStop = false;
            this.Facebook.Click += new System.EventHandler(this.Facebook_Click);
            // 
            // ContactUS1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Instagram);
            this.Controls.Add(this.Twitter);
            this.Controls.Add(this.Facebook);
            this.Name = "ContactUS1";
            this.Size = new System.Drawing.Size(770, 437);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Instagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facebook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Facebook;
        private System.Windows.Forms.PictureBox Twitter;
        private System.Windows.Forms.PictureBox Instagram;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
