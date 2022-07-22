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
using PBL_SMALL_Csharp.CUSTOM;
using PBL_SMALL_Csharp.DatabaseConnect;
using PBL_SMALL_Csharp.MODEL;
using PBL_SMALL_Csharp.Properties;

namespace PBL_SMALL_Csharp.VIEW
{
    public partial class AddBookForm : Form
    {
        BookBLL b;
        public AddBookForm()
        {
            InitializeComponent();
            b = new BookBLL();
        }

        String imgPath = null;
        PRESENTER.Func_Class func = new PRESENTER.Func_Class();

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void resetField()
        {
            textBox1_ISBN.Text = "";
            label6_emptyISBN.Visible = false;

            textBox1_Name.Text = "";
            label7_EmtyName.Visible = false;

            textBox1_Quantity.Text = "";
            label8_EmptyQuantity.Visible = false;


            textBox1_Price.Text = "";
            label10_EmptyPrice.Visible = false;

            pictureBox1_BookCover.Image = Resources.素敵な装丁の本76___gyu_s_shop_blog;
            label11_EmptyPicture.Visible = false;
        }

        private void button_WOC1_AddBook_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1_ISBN.Text == "")
                {
                    label6_emptyISBN.Visible = true;
                }
                else if (textBox1_Name.Text == "")
                {
                    label7_EmtyName.Visible = true;
                }
                else if (textBox1_Quantity.Text == "")
                {
                    label8_EmptyQuantity.Visible = true;
                }
                else if (textBox1_Price.Text == "")
                {
                    label10_EmptyPrice.Visible = true;
                }
                else if (pictureBox1_BookCover.Image == Resources.素敵な装丁の本76___gyu_s_shop_blog)
                {
                    label11_EmptyPicture.Visible = true;
                }
                else
                {
                    byte[] image = null;
                    FileStream Stream = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    image = brs.ReadBytes((int)Stream.Length);


                    Book bk = new Book();
                    bk.isbn = textBox1_ISBN.Text;
                    bk.name = textBox1_Name.Text;
                    bk.quantity = int.Parse(textBox1_Quantity.Text);
                    bk.price = float.Parse(textBox1_Price.Text);
                    bk.date_receive = dateTimePicker1_DateAdd.Value.ToString("yyyy-MM-dd");
                    bk.description = textBox1_Description.Text;
                    bk.cover = image;
                    //Console.WriteLine(bk.date_receive);
                    if (b.addBook(bk))
                    {
                        func.Alert("Add book successful", AlertForm.enmType.Success);
                    }
                    else
                    {
                        func.Alert("Add book unsuccessful", AlertForm.enmType.Error);
                    }
                    resetField();
                }
                
            }
            catch (Exception ex)
            {
            //    MessageBox.Show(ex.Message);
                func.Alert("Please choose book cover", AlertForm.enmType.Warning);
            }
        }
        private void dateTimePicker1_DateAdd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_EmtyName_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_SelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            {
                imgPath = dialog.FileName.ToString();
                pictureBox1_BookCover.ImageLocation = imgPath;
            }
        }
    }
}
