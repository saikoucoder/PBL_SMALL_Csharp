using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL_SMALL_Csharp.CUSTOM;
using PBL_SMALL_Csharp.DatabaseConnect;
using PBL_SMALL_Csharp.MODEL;

namespace PBL_SMALL_Csharp.VIEW
{
    public partial class DeleteBookForm : Form
    {
        BookBLL a;
        public DeleteBookForm()
        {
            InitializeComponent();
            a = new BookBLL();
        }

        PRESENTER.Func_Class func = new PRESENTER.Func_Class();

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_WOC1_DeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1_ID_Book.Text == "")
                {
                    label5_empty_ID_Book.Visible = true;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you sure to delete this book?", "Delete Book", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string b = textBox1_ID_Book.Text;
                        if (a.deleteBook(int.Parse(b)))
                        {
                            func.Alert("Delete Book successful", AlertForm.enmType.Success);
                            textBox1_ID_Book.Clear();
                        }
                        else
                        {
                            func.Alert("Delete Book unsuccessful", AlertForm.enmType.Error);
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        func.Alert("Cancel delete Book", AlertForm.enmType.Info);
                    }
                    
                    resetField();
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void resetField()
        {
            textBox1_ID_Book.Text = "";
            label5_empty_ID_Book.Visible = false;
        }

        private void button_WOC1_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1_ID_Book.Text == "")
                {
                    label5_empty_ID_Book.Visible = true;
                }
                else
                {
                    label5_empty_ID_Book.Visible = false;
                    string b = textBox1_ID_Book.Text;
                    if (a.check_id_book_delete(int.Parse(b)))
                    {
                        MessageBox.Show("Book Available!");
                    }
                    else
                    {
                        MessageBox.Show("Book Unavailable!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
