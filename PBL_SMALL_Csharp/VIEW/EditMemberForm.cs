using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL_SMALL_Csharp.MODEL;
using PBL_SMALL_Csharp.DatabaseConnect;
using PBL_SMALL_Csharp.Properties;
using System.IO;
using PBL_SMALL_Csharp.CUSTOM;

namespace PBL_SMALL_Csharp.VIEW
{
    public partial class EditMemberForm : Form
    {
        MemberBLL a;
        public EditMemberForm()
        {
            InitializeComponent();
            a = new MemberBLL();
        }

        String imgPath = null;
        PRESENTER.Func_Class func = new PRESENTER.Func_Class();


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
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void button_WOC1_AddMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1_ID_Member.Text == "")
                {
                    label5_emptyID.Visible = true;
                }
                else if (textBox1_FirstName.Text == "")
                {
                    label6_Empty_Fname.Visible = true;
                }
                else if (textBox1_LastName.Text == "")
                {
                    label7_EmtyLname.Visible = true;
                }
                else if (textBox1_Phone.Text == "")
                {
                    label8_EmptyPhone.Visible = true;
                }
                else if (textBox1_Email.Text == "")
                {
                    label9_EmptyMail.Visible = true;
                }
                else if (comboBox1_Gender.Text == "")
                {
                    label10_EmptyGender.Visible = true;
                }
                else
                {
                    Member nguoi = new Member();
                    nguoi.Id = int.Parse(textBox1_ID_Member.Text);
                    nguoi.firstName = textBox1_FirstName.Text;
                    nguoi.lastName = textBox1_LastName.Text;
                    nguoi.phone = textBox1_Phone.Text;
                    nguoi.email = textBox1_Email.Text;
                    nguoi.gender = comboBox1_Gender.SelectedItem.ToString();
                    nguoi.picture = ImageToByte(pictureBox1_ProfileImage.Image, pictureBox1_ProfileImage.Image.RawFormat);

                    if (a.editMember(nguoi))
                        func.Alert("Edit member successful", AlertForm.enmType.Success);
                    else
                        func.Alert("Edit member unsuccessful", AlertForm.enmType.Error);
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
            textBox1_ID_Member.Text = "";
            label5_emptyID.Visible = false;

            textBox1_FirstName.Text = "";
            label6_Empty_Fname.Visible = false;

            textBox1_LastName.Text = "";
            label7_EmtyLname.Visible = false;

            textBox1_Phone.Text = "";
            label8_EmptyPhone.Visible = false;

            textBox1_Email.Text = "";
            label9_EmptyMail.Visible = false;

            comboBox1_Gender.Text = "";
            label10_EmptyGender.Visible = false;

            pictureBox1_ProfileImage.Image = Resources.generated_photos_5e6889316d3b380006f22d41;
        }

        private void button_WOC1_Search_Click(object sender, EventArgs e)
        {
            Member nguoi = new Member();
            nguoi = a.searchMember(int.Parse(textBox1_ID_Member.Text));
            textBox1_FirstName.Text = nguoi.firstName;
            textBox1_LastName.Text = nguoi.lastName;
            textBox1_Email.Text = nguoi.email;
            textBox1_Phone.Text = nguoi.phone;
            comboBox1_Gender.Text = nguoi.gender;
            pictureBox1_ProfileImage.Image = ByteToImage(nguoi.picture);
        }

        private void button_WOC1_SelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgPath = dialog.FileName.ToString();
                pictureBox1_ProfileImage.ImageLocation = imgPath;
            }
        }
    }
}
