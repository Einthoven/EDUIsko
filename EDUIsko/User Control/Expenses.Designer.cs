namespace EDUIsko
{
    partial class Expenses
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
            this.Add = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Reset1 = new System.Windows.Forms.Button();
            this.CostList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.RichTextBox();
            this.ProductBox = new System.Windows.Forms.RichTextBox();
            this.CostBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CostList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add.FlatAppearance.BorderSize = 2;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(56, 216);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(174, 56);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sum
            // 
            this.Sum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Sum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.Sum.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Sum.FlatAppearance.BorderSize = 2;
            this.Sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(299, 216);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(174, 56);
            this.Sum.TabIndex = 6;
            this.Sum.Text = "Sum";
            this.Sum.UseVisualStyleBackColor = false;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Reset1
            // 
            this.Reset1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Reset1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.Reset1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Reset1.FlatAppearance.BorderSize = 2;
            this.Reset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset1.Location = new System.Drawing.Point(534, 216);
            this.Reset1.Name = "Reset1";
            this.Reset1.Size = new System.Drawing.Size(174, 56);
            this.Reset1.TabIndex = 7;
            this.Reset1.Text = "Reset";
            this.Reset1.UseVisualStyleBackColor = false;
            this.Reset1.Click += new System.EventHandler(this.Reset1_Click);
            // 
            // CostList
            // 
            this.CostList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CostList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CostList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(216)))));
            this.CostList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CostList.Location = new System.Drawing.Point(76, 294);
            this.CostList.Name = "CostList";
            this.CostList.RowHeadersWidth = 51;
            this.CostList.RowTemplate.Height = 24;
            this.CostList.Size = new System.Drawing.Size(589, 118);
            this.CostList.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 51);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(284, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 51);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product/Service\r\n";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(524, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 51);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cost\r\n";
            // 
            // DateBox
            // 
            this.DateBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox.Location = new System.Drawing.Point(29, 134);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(191, 63);
            this.DateBox.TabIndex = 12;
            this.DateBox.Text = "";
            // 
            // ProductBox
            // 
            this.ProductBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBox.Location = new System.Drawing.Point(282, 134);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(191, 63);
            this.ProductBox.TabIndex = 13;
            this.ProductBox.Text = "";
            // 
            // CostBox
            // 
            this.CostBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CostBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostBox.Location = new System.Drawing.Point(524, 134);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(191, 63);
            this.CostBox.TabIndex = 14;
            this.CostBox.Text = "";
            // 
            // Expenses
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.ProductBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CostList);
            this.Controls.Add(this.Reset1);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Add);
            this.Name = "Expenses";
            this.Size = new System.Drawing.Size(770, 437);
            this.Load += new System.EventHandler(this.Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CostList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Reset1;
        private System.Windows.Forms.DataGridView CostList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox DateBox;
        private System.Windows.Forms.RichTextBox ProductBox;
        private System.Windows.Forms.RichTextBox CostBox;
    }
}
