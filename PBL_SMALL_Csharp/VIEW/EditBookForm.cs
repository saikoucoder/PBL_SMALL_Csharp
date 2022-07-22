using PBL_SMALL_Csharp.DatabaseConnect;
using PBL_SMALL_Csharp.MODEL;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PBL_SMALL_Csharp.Properties;
using PBL_SMALL_Csharp.CUSTOM;

namespace PBL_SMALL_Csharp.VIEW
{
    public partial class EditBookForm : Form
    {
        BookBLL a;
        public EditBookForm()
        {
            InitializeComponent();
            a = new BookBLL();
        }

        String imgPath = null;
        PRESENTER.Func_Class func = new PRESENTER.Func_Class();

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        public byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

               // Convert byte[] to Base64 String
                
                return imageBytes;
            }
        }
        private void button_WOC1_Search_Click(object sender, EventArgs e)
        {
            Book bk = new Book();
            bk = a.searchBook(int.Parse(textBox1_ID_Book.Text));
            textBox1_ISBN.Text = string.Empty;
            textBox1_Name.Text = string.Empty;
            textBox1_Quantity.Text = string.Empty;
            textBox1_Price.Text = string.Empty;
            textBox1_Description.Text = string.Empty;
            if (bk.isbn != null)
            {
                textBox1_ISBN.Text = bk.isbn;
                textBox1_Name.Text = bk.name;
                textBox1_Quantity.Text = bk.quantity.ToString();
                textBox1_Price.Text = bk.price.ToString();
                dateTimePicker1_DateAdd.Text = bk.date_receive.ToString();
                textBox1_Description.Text = bk.description;
                pictureBox1_BookCover.Image = ByteToImage(bk.cover);
            }
            
        }


        private void button_WOC1_EditBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1_ID_Book.Text == "")
                {
                    label5_EmptyID.Visible = true;
                }
                else if (textBox1_ISBN.Text == "")
                {
                    label6_EmptyISBN.Visible = true;
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
                    label9_EmptyPrice.Visible = true;
                }

                else
                {
                   
                    Book bk = new Book();
                    bk.id_book = int.Parse(textBox1_ID_Book.Text);
                    bk.isbn = textBox1_ISBN.Text;
                    bk.name = textBox1_Name.Text;
                    bk.quantity = int.Parse(textBox1_Quantity.Text);
                    bk.price = float.Parse(textBox1_Price.Text);
                    bk.description = textBox1_Description.Text;
                    bk.date_receive = dateTimePicker1_DateAdd.Value.ToString("yyyy-MM-dd");
                    bk.cover = ImageToByte(pictureBox1_BookCover.Image, pictureBox1_BookCover.Image.RawFormat);

                    if (a.editBook(bk))
                    {
                        func.Alert("Edit Book successful", AlertForm.enmType.Success);
                    }
                    else
                    {
                        func.Alert("Edit Book unsuccessful", AlertForm.enmType.Error);
                    }
                    resetField();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void resetField()
        {
            textBox1_ISBN.Text = "";
            label6_EmptyISBN.Visible = false;

            textBox1_Name.Text = "";
            label7_EmtyName.Visible = false;

            textBox1_Quantity.Text = "";
            label8_EmptyQuantity.Visible = false;

            textBox1_Description.Text = "";


            label10_EmptyDate.Visible = false;

            textBox1_ID_Book.Text = "";

            textBox1_Price.Text = "";
            label9_EmptyPrice.Visible = false;

            pictureBox1_BookCover.Image = Resources.素敵な装丁の本76___gyu_s_shop_blog;
            label11_EmptyPicture.Visible = false;

        }
        
        private void button_WOC1_SelectPicture_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgPath = dialog.FileName.ToString();
                pictureBox1_BookCover.ImageLocation = imgPath;
            }
        }
    }
}
