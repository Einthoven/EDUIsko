namespace EDUIsko
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sideBarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NotePad = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.home11 = new EDUIsko.Home1();
            this.notes11 = new EDUIsko.Notes1();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sideBarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarContainer
            // 
            this.sideBarContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.sideBarContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideBarContainer.Controls.Add(this.panel1);
            this.sideBarContainer.Controls.Add(this.panel2);
            this.sideBarContainer.Controls.Add(this.panel3);
            this.sideBarContainer.Controls.Add(this.panel4);
            this.sideBarContainer.Controls.Add(this.panel5);
            this.sideBarContainer.Controls.Add(this.panel6);
            this.sideBarContainer.Controls.Add(this.panel8);
            this.sideBarContainer.Location = new System.Drawing.Point(0, 2);
            this.sideBarContainer.MaximumSize = new System.Drawing.Size(200, 1080);
            this.sideBarContainer.MinimumSize = new System.Drawing.Size(75, 450);
            this.sideBarContainer.Name = "sideBarContainer";
            this.sideBarContainer.Size = new System.Drawing.Size(200, 493);
            this.sideBarContainer.TabIndex = 0;
            this.sideBarContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBarContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 71);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EDUIsko.Properties.Resources.home40;
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Home);
            this.panel2.Location = new System.Drawing.Point(3, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 54);
            this.panel2.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Image = global::EDUIsko.Properties.Resources.home40;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(-10, -2);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.Home.Size = new System.Drawing.Size(217, 58);
            this.Home.TabIndex = 2;
            this.Home.Text = "              Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NotePad);
            this.panel3.Location = new System.Drawing.Point(3, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 54);
            this.panel3.TabIndex = 2;
            // 
            // NotePad
            // 
            this.NotePad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotePad.Image = global::EDUIsko.Properties.Resources.home40;
            this.NotePad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotePad.Location = new System.Drawing.Point(-10, -2);
            this.NotePad.Name = "NotePad";
            this.NotePad.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.NotePad.Size = new System.Drawing.Size(217, 58);
            this.NotePad.TabIndex = 2;
            this.NotePad.Text = "                              NotePad";
            this.NotePad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotePad.UseVisualStyleBackColor = true;
            this.NotePad.Click += new System.EventHandler(this.NotePad_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(3, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 54);
            this.panel4.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::EDUIsko.Properties.Resources.home40;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-10, -2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(217, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "                              Expenses";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(3, 260);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 54);
            this.panel5.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::EDUIsko.Properties.Resources.home40;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-10, -2);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(217, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "                              Calendar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            this.panel6.Location = new System.Drawing.Point(3, 320);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 54);
            this.panel6.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::EDUIsko.Properties.Resources.home40;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-10, -2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(217, 58);
            this.button4.TabIndex = 2;
            this.button4.Text = "                              Pomodoro";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(75, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(770, 56);
            this.panel7.TabIndex = 1;
            // 
            // home11
            // 
            this.home11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home11.BackColor = System.Drawing.SystemColors.Control;
            this.home11.Location = new System.Drawing.Point(75, 58);
            this.home11.Name = "home11";
            this.home11.Size = new System.Drawing.Size(770, 437);
            this.home11.TabIndex = 2;
            // 
            // notes11
            // 
            this.notes11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notes11.BackColor = System.Drawing.SystemColors.Control;
            this.notes11.Location = new System.Drawing.Point(75, 58);
            this.notes11.Name = "notes11";
            this.notes11.Size = new System.Drawing.Size(770, 437);
            this.notes11.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button1);
            this.panel8.Location = new System.Drawing.Point(3, 380);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(197, 54);
            this.panel8.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::EDUIsko.Properties.Resources.home40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-10, -2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(217, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "                              Contact US";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(848, 493);
            this.Controls.Add(this.sideBarContainer);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.home11);
            this.Controls.Add(this.notes11);
            this.Name = "Form1";
            this.Text = "EDUIsko";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideBarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sideBarContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button NotePad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private Home1 home11;
        private Notes1 notes11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
    }
}

