namespace EDUIsko.User_Control
{
    partial class Pomodoro1
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
            this.components = new System.ComponentModel.Container();
            this.Start1 = new System.Windows.Forms.Button();
            this.Stop1 = new System.Windows.Forms.Button();
            this.PomodoroButton = new System.Windows.Forms.Button();
            this.ShortBreak = new System.Windows.Forms.Button();
            this.LongBreak = new System.Windows.Forms.Button();
            this.Facebook = new System.Windows.Forms.PictureBox();
            this.Minute1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Seconds1 = new System.Windows.Forms.Label();
            this.PomodoroTimer1 = new System.Windows.Forms.Timer(this.components);
            this.Reset1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Facebook)).BeginInit();
            this.SuspendLayout();
            // 
            // Start1
            // 
            this.Start1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.Start1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Start1.FlatAppearance.BorderSize = 2;
            this.Start1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start1.Location = new System.Drawing.Point(230, 341);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(129, 42);
            this.Start1.TabIndex = 6;
            this.Start1.Text = "Start";
            this.Start1.UseVisualStyleBackColor = false;
            this.Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // Stop1
            // 
            this.Stop1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.Stop1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Stop1.FlatAppearance.BorderSize = 2;
            this.Stop1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop1.Location = new System.Drawing.Point(395, 341);
            this.Stop1.Name = "Stop1";
            this.Stop1.Size = new System.Drawing.Size(129, 42);
            this.Stop1.TabIndex = 7;
            this.Stop1.Text = "Stop";
            this.Stop1.UseVisualStyleBackColor = false;
            this.Stop1.Click += new System.EventHandler(this.Stop1_Click);
            // 
            // PomodoroButton
            // 
            this.PomodoroButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PomodoroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.PomodoroButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PomodoroButton.FlatAppearance.BorderSize = 2;
            this.PomodoroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PomodoroButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PomodoroButton.Location = new System.Drawing.Point(310, 7);
            this.PomodoroButton.Name = "PomodoroButton";
            this.PomodoroButton.Size = new System.Drawing.Size(129, 42);
            this.PomodoroButton.TabIndex = 8;
            this.PomodoroButton.Text = "Pomodoro";
            this.PomodoroButton.UseVisualStyleBackColor = false;
            this.PomodoroButton.Click += new System.EventHandler(this.PomodoroButton_Click);
            // 
            // ShortBreak
            // 
            this.ShortBreak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShortBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.ShortBreak.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ShortBreak.FlatAppearance.BorderSize = 2;
            this.ShortBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShortBreak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortBreak.Location = new System.Drawing.Point(578, 246);
            this.ShortBreak.Name = "ShortBreak";
            this.ShortBreak.Size = new System.Drawing.Size(147, 42);
            this.ShortBreak.TabIndex = 9;
            this.ShortBreak.Text = "Short Break";
            this.ShortBreak.UseVisualStyleBackColor = false;
            this.ShortBreak.Click += new System.EventHandler(this.ShortBreak_Click);
            // 
            // LongBreak
            // 
            this.LongBreak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LongBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.LongBreak.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LongBreak.FlatAppearance.BorderSize = 2;
            this.LongBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LongBreak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongBreak.Location = new System.Drawing.Point(578, 303);
            this.LongBreak.Name = "LongBreak";
            this.LongBreak.Size = new System.Drawing.Size(147, 42);
            this.LongBreak.TabIndex = 10;
            this.LongBreak.Text = "Long Break";
            this.LongBreak.UseVisualStyleBackColor = false;
            this.LongBreak.Click += new System.EventHandler(this.LongBreak_Click);
            // 
            // Facebook
            // 
            this.Facebook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Facebook.Image = global::EDUIsko.Properties.Resources.timer__1_;
            this.Facebook.Location = new System.Drawing.Point(221, 55);
            this.Facebook.Name = "Facebook";
            this.Facebook.Size = new System.Drawing.Size(303, 196);
            this.Facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Facebook.TabIndex = 11;
            this.Facebook.TabStop = false;
            // 
            // Minute1
            // 
            this.Minute1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Minute1.AutoSize = true;
            this.Minute1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minute1.Location = new System.Drawing.Point(261, 254);
            this.Minute1.Name = "Minute1";
            this.Minute1.Size = new System.Drawing.Size(98, 74);
            this.Minute1.TabIndex = 12;
            this.Minute1.Text = "00";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 74);
            this.label1.TabIndex = 13;
            this.label1.Text = ":";
            // 
            // Seconds1
            // 
            this.Seconds1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Seconds1.AutoSize = true;
            this.Seconds1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seconds1.Location = new System.Drawing.Point(396, 254);
            this.Seconds1.Name = "Seconds1";
            this.Seconds1.Size = new System.Drawing.Size(98, 74);
            this.Seconds1.TabIndex = 14;
            this.Seconds1.Text = "00";
            // 
            // PomodoroTimer1
            // 
            this.PomodoroTimer1.Interval = 1000;
            this.PomodoroTimer1.Tick += new System.EventHandler(this.PomodoroTimer1_Tick);
            // 
            // Reset1
            // 
            this.Reset1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reset1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.Reset1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Reset1.FlatAppearance.BorderSize = 2;
            this.Reset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset1.Location = new System.Drawing.Point(310, 389);
            this.Reset1.Name = "Reset1";
            this.Reset1.Size = new System.Drawing.Size(129, 42);
            this.Reset1.TabIndex = 15;
            this.Reset1.Text = "Reset";
            this.Reset1.UseVisualStyleBackColor = false;
            this.Reset1.Click += new System.EventHandler(this.Reset1_Click);
            // 
            // Pomodoro1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.Reset1);
            this.Controls.Add(this.Seconds1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minute1);
            this.Controls.Add(this.Facebook);
            this.Controls.Add(this.LongBreak);
            this.Controls.Add(this.ShortBreak);
            this.Controls.Add(this.PomodoroButton);
            this.Controls.Add(this.Stop1);
            this.Controls.Add(this.Start1);
            this.Name = "Pomodoro1";
            this.Size = new System.Drawing.Size(770, 437);
            ((System.ComponentModel.ISupportInitialize)(this.Facebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start1;
        private System.Windows.Forms.Button Stop1;
        private System.Windows.Forms.Button PomodoroButton;
        private System.Windows.Forms.Button ShortBreak;
        private System.Windows.Forms.Button LongBreak;
        private System.Windows.Forms.PictureBox Facebook;
        private System.Windows.Forms.Label Minute1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Seconds1;
        private System.Windows.Forms.Timer PomodoroTimer1;
        private System.Windows.Forms.Button Reset1;
    }
}
