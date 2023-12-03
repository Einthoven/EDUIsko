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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sideBarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Pomodoro = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.contactUS11 = new EDUIsko.User_Control.ContactUS1();
            this.home11 = new EDUIsko.Home1();
            this.notes11 = new EDUIsko.Notes1();
            this.calendar11 = new EDUIsko.Calendar1();
            this.expenses1 = new EDUIsko.Expenses();
            this.pomodoro11 = new EDUIsko.User_Control.Pomodoro1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Button();
            this.NotePad = new System.Windows.Forms.Button();
            this.Expenses = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.Button();
            this.ContactUS = new System.Windows.Forms.Button();
            this.sideBarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.sideBarContainer.Size = new System.Drawing.Size(75, 493);
            this.sideBarContainer.TabIndex = 0;
            this.sideBarContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBarContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 105);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Home);
            this.panel2.Location = new System.Drawing.Point(3, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 54);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NotePad);
            this.panel3.Location = new System.Drawing.Point(3, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 54);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Expenses);
            this.panel4.Location = new System.Drawing.Point(3, 234);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 54);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Calendar);
            this.panel5.Location = new System.Drawing.Point(3, 294);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 54);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Pomodoro);
            this.panel6.Location = new System.Drawing.Point(3, 354);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 54);
            this.panel6.TabIndex = 2;
            // 
            // Pomodoro
            // 
            this.Pomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pomodoro.Image = global::EDUIsko.Properties.Resources.timer_40;
            this.Pomodoro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pomodoro.Location = new System.Drawing.Point(-10, -2);
            this.Pomodoro.Name = "Pomodoro";
            this.Pomodoro.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.Pomodoro.Size = new System.Drawing.Size(217, 58);
            this.Pomodoro.TabIndex = 2;
            this.Pomodoro.Text = "                              Pomodoro";
            this.Pomodoro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pomodoro.UseVisualStyleBackColor = true;
            this.Pomodoro.Click += new System.EventHandler(this.Pomodoro_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.ContactUS);
            this.panel8.Location = new System.Drawing.Point(3, 414);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(197, 54);
            this.panel8.TabIndex = 3;
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
            // contactUS11
            // 
            this.contactUS11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactUS11.Location = new System.Drawing.Point(75, 58);
            this.contactUS11.Name = "contactUS11";
            this.contactUS11.Size = new System.Drawing.Size(770, 437);
            this.contactUS11.TabIndex = 7;
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
            // calendar11
            // 
            this.calendar11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar11.Location = new System.Drawing.Point(75, 58);
            this.calendar11.Name = "calendar11";
            this.calendar11.Size = new System.Drawing.Size(770, 437);
            this.calendar11.TabIndex = 4;
            // 
            // expenses1
            // 
            this.expenses1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expenses1.Location = new System.Drawing.Point(75, 58);
            this.expenses1.Name = "expenses1";
            this.expenses1.Size = new System.Drawing.Size(770, 437);
            this.expenses1.TabIndex = 5;
            // 
            // pomodoro11
            // 
            this.pomodoro11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pomodoro11.Location = new System.Drawing.Point(75, 58);
            this.pomodoro11.Name = "pomodoro11";
            this.pomodoro11.Size = new System.Drawing.Size(770, 437);
            this.pomodoro11.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EDUIsko.Properties.Resources.HomeCottage;
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Image = global::EDUIsko.Properties.Resources.Home_Icon_40;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(-10, -2);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.Home.Size = new System.Drawing.Size(217, 58);
            this.Home.TabIndex = 2;
            this.Home.Text = "                  Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // NotePad
            // 
            this.NotePad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotePad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotePad.Image = global::EDUIsko.Properties.Resources.NotePad_Icon35;
            this.NotePad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotePad.Location = new System.Drawing.Point(-10, -2);
            this.NotePad.Name = "NotePad";
            this.NotePad.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.NotePad.Size = new System.Drawing.Size(217, 58);
            this.NotePad.TabIndex = 2;
            this.NotePad.Text = "                  NotePad";
            this.NotePad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotePad.UseVisualStyleBackColor = true;
            this.NotePad.Click += new System.EventHandler(this.NotePad_Click);
            // 
            // Expenses
            // 
            this.Expenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expenses.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses.Image = global::EDUIsko.Properties.Resources.Expenses_Icon_40;
            this.Expenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Expenses.Location = new System.Drawing.Point(-10, -2);
            this.Expenses.Name = "Expenses";
            this.Expenses.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.Expenses.Size = new System.Drawing.Size(217, 58);
            this.Expenses.TabIndex = 2;
            this.Expenses.Text = "                  Expenses";
            this.Expenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Expenses.UseVisualStyleBackColor = true;
            this.Expenses.Click += new System.EventHandler(this.Expenses_Click);
            // 
            // Calendar
            // 
            this.Calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calendar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Image = global::EDUIsko.Properties.Resources.Calendar_Icon_40;
            this.Calendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Calendar.Location = new System.Drawing.Point(-10, -2);
            this.Calendar.Name = "Calendar";
            this.Calendar.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.Calendar.Size = new System.Drawing.Size(217, 58);
            this.Calendar.TabIndex = 2;
            this.Calendar.Text = "                  Calendar";
            this.Calendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Calendar.UseVisualStyleBackColor = true;
            this.Calendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // ContactUS
            // 
            this.ContactUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactUS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactUS.Image = global::EDUIsko.Properties.Resources.ContactUs_Icon_40;
            this.ContactUS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactUS.Location = new System.Drawing.Point(-10, -2);
            this.ContactUS.Name = "ContactUS";
            this.ContactUS.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.ContactUS.Size = new System.Drawing.Size(217, 58);
            this.ContactUS.TabIndex = 2;
            this.ContactUS.Text = "                 Contact Us";
            this.ContactUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactUS.UseVisualStyleBackColor = true;
            this.ContactUS.Click += new System.EventHandler(this.ContactUS_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(848, 493);
            this.Controls.Add(this.sideBarContainer);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.contactUS11);
            this.Controls.Add(this.home11);
            this.Controls.Add(this.notes11);
            this.Controls.Add(this.calendar11);
            this.Controls.Add(this.expenses1);
            this.Controls.Add(this.pomodoro11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EDUIsko";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideBarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button Expenses;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Calendar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Pomodoro;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private Home1 home11;
        private Notes1 notes11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button ContactUS;
        private Calendar1 calendar11;
        private Expenses expenses1;
        private User_Control.Pomodoro1 pomodoro11;
        private User_Control.ContactUS1 contactUS11;
    }
}

