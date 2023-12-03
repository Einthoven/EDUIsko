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
    public partial class Expenses : UserControl
    {
        DataTable notes = new DataTable();
        bool editing = false;

        public Expenses()
        {
            InitializeComponent();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Date");
            notes.Columns.Add("Product/Services");
            notes.Columns.Add("Cost");

            CostList.DataSource = notes;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[CostList.CurrentCell.RowIndex]["Date"] = DateBox.Text;
                notes.Rows[CostList.CurrentCell.RowIndex]["Product/Services"] = ProductBox.Text;
                notes.Rows[CostList.CurrentCell.RowIndex]["Cost"] = CostBox.Text;

            }
            else
            {
                notes.Rows.Add(DateBox.Text, ProductBox.Text, CostBox.Text);

            }

            DateBox.Text = "";
            ProductBox.Text = "";
            CostBox.Text = "";
            editing = false;
        }

        private void Reset1_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows.Clear();
            }
            catch
            {
                MessageBox.Show("Already Empty");
            }
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            double TotalSum = 0;

            foreach (DataRow row in notes.Rows)
            {
                // Check if the "Cost" column is not null
                if (row["Cost"] != DBNull.Value)
                {
                    TotalSum += Convert.ToDouble(row["Cost"]);
                }
                else
                {
                    break;
                }
            }

            MessageBox.Show($"Total Sum: {TotalSum}");

        }
    }
}
