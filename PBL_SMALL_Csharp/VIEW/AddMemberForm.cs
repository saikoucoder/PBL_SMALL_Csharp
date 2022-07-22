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
using System.IO;
using PBL_SMALL_Csharp.Properties;
using PBL_SMALL_Csharp.CUSTOM;

namespace PBL_SMALL_Csharp.GUI
{
    public partial class AddMemberForm : Form
    {
        MemberBLL a;
        public AddMemberForm()
        {
            InitializeComponent();
            a = new MemberBLL();
        }

        PRESENTER.Func_Class func = new PRESENTER.Func_Class();
        String imgPath = null;


        public void resetField()
        {
            textBox1_firstName.Text = "";
            label6_emptyFname.Visible = false;

            textBox1_LastName.Text = "";
            label7_EmtyLname.Visible = false;

            textBox1_Phone.Text = "";
            label8_EmptyPhone.Visible = false;

            textBox1_Email.Text = "";
            label9_EmptyMail.Visible = false;

            comboBox1_Gender.Text = "";
            label10_EmptyGender.Visible = false;

            pictureBox1_ProfileImage.Image = Resources.generated_photos_5e6889316d3b380006f22d41;
            label11_EmptyPicture.Visible = false;
        }
        private void button_WOC1_AddMember_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1_firstName.Text == "")
                {
                    label6_emptyFname.Visible = true;
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
                    byte[] image = null;
                    FileStream Stream = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    image = brs.ReadBytes((int)Stream.Length);


                    Member nguoi = new Member();
                    nguoi.firstName = textBox1_firstName.Text;
                    nguoi.lastName = textBox1_LastName.Text;
                    nguoi.phone = textBox1_Phone.Text;
                    nguoi.email = textBox1_Email.Text;
                    nguoi.gender = comboBox1_Gender.SelectedItem.ToString();
                    nguoi.picture = image;
                    if (a.addMember(nguoi))
                        func.Alert("Add Member successful", AlertForm.enmType.Success);
                    else
                        func.Alert("Add Member unsuccessful", AlertForm.enmType.Error);
                    resetField();
                }
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                func.Alert("Please choose member image", AlertForm.enmType.Warning);
            }

        }

        private void button_WOC1_SelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            {
                imgPath = dialog.FileName.ToString();
                pictureBox1_ProfileImage.ImageLocation = imgPath;
            }
        }
    }
}
