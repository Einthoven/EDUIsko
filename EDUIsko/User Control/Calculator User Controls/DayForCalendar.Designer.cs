namespace EDUIsko.User_Control
{
    partial class DayForCalendar
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
            this.DateLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateLeft
            // 
            this.DateLeft.AutoSize = true;
            this.DateLeft.Location = new System.Drawing.Point(3, 0);
            this.DateLeft.Name = "DateLeft";
            this.DateLeft.Size = new System.Drawing.Size(21, 16);
            this.DateLeft.TabIndex = 1;
            this.DateLeft.Text = "00";
            // 
            // DayForCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.Controls.Add(this.DateLeft);
            this.Name = "DayForCalendar";
            this.Size = new System.Drawing.Size(70, 51);
            this.Load += new System.EventHandler(this.DayForCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLeft;
    }
}
