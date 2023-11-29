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
    public partial class Notes1 : UserControl
    {
        DataTable notes = new DataTable();
        bool editing = false;

        public Notes1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[NotesList.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[NotesList.CurrentCell.RowIndex]["Notes"] = NotesBox.Text;
                notes.Rows[NotesList.CurrentCell.RowIndex]["Date"] = DateBox.Text;

            }
            else
            { 
                notes.Rows.Add(TitleBox.Text, NotesBox.Text, DateBox.Text);

            }


            SaveFileDialog Dialog = new SaveFileDialog();
            Dialog.Title = "Save";
            Dialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (Dialog.ShowDialog() == DialogResult.OK)
                NotesBox.SaveFile(Dialog.FileName, RichTextBoxStreamType.PlainText);
            this.Text = Dialog.FileName;

            TitleBox.Text = "";
            NotesBox.Text = "";
            DateBox.Text = "";
            editing = false;
        }

        private void Load1_Click(object sender, EventArgs e)
        {
            TitleBox.Text = notes.Rows[NotesList.CurrentCell.RowIndex].ItemArray[0].ToString();
            NotesBox.Text = notes.Rows[NotesList.CurrentCell.RowIndex].ItemArray[1].ToString();
            DateBox.Text = notes.Rows[NotesList.CurrentCell.RowIndex].ItemArray[2].ToString();
            editing = true;
        }

        private void NewNote_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            NotesBox.Text = "";
            DateBox.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[NotesList.CurrentCell.RowIndex].Delete();
            }
            catch
            {
                MessageBox.Show("Nothing to Delete");
            }
        }

        private void Notes1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Notes");
            notes.Columns.Add("Date");

            NotesList.DataSource = notes;
        }

        private void NotesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleBox.Text = notes.Rows[NotesList.CurrentCell.RowIndex].ItemArray[0].ToString();
            NotesBox.Text = notes.Rows[NotesList.CurrentCell.RowIndex].ItemArray[1].ToString();
            DateBox.Text = notes.Rows[NotesList.CurrentCell.RowIndex].ItemArray[2].ToString();
            editing = true;
        }
    }
}
