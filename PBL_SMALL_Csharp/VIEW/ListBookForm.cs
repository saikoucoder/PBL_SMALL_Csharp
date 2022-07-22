using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL_SMALL_Csharp.DatabaseConnect;
using PBL_SMALL_Csharp.MODEL;

namespace PBL_SMALL_Csharp.VIEW
{
    public partial class ListBookForm : Form
    {
        BookBLL a;
        public ListBookForm()
        {
            InitializeComponent();
            a = new BookBLL();
        }
        public void showallBook()
        {
            DataTable dt = a.getAllBook();
            dataGridView1_Book.DataSource = dt;
        }



        private void dataGridView1_Book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListBookForm_Load(object sender, EventArgs e)
        {
            showallBook();
        }
        int ID;
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void dataGridView1_Book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                
                ID = Int32.Parse(dataGridView1_Book.Rows[index].Cells[0].Value.ToString());
                textBox1_ISBN.Text = dataGridView1_Book.Rows[index].Cells[1].Value.ToString();
                textBox2_Name.Text = dataGridView1_Book.Rows[index].Cells[2].Value.ToString();
                textBox3_Quantity.Text = dataGridView1_Book.Rows[index].Cells[3].Value.ToString();
                textBox4_Price.Text = dataGridView1_Book.Rows[index].Cells[4].Value.ToString();
                textBox5_DateAdd.Text = dataGridView1_Book.Rows[index].Cells[5].Value.ToString();
                pictureBox1_BookCover.Image = ByteToImage(a.searchBook(ID).cover); 
            }
        }
    }
}
