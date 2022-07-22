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

namespace PBL_SMALL_Csharp.VIEW
{
    public partial class ListMemberForm : Form
    {
        MemberBLL a;
        public ListMemberForm()
        {
            InitializeComponent();
            a = new MemberBLL();
            showAllMember();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void showAllMember()
        {
            DataTable dt = a.getAllMember();
            dataGridView1_Member.DataSource = dt;
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
        private void dataGridView1_Member_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = Int32.Parse(dataGridView1_Member.Rows[index].Cells[0].Value.ToString());
                textBox1_Firstname.Text = dataGridView1_Member.Rows[index].Cells[1].Value.ToString();
                textBox2_Lastname.Text = dataGridView1_Member.Rows[index].Cells[2].Value.ToString();
                textBox3_Phone.Text = dataGridView1_Member.Rows[index].Cells[3].Value.ToString();
                textBox4_Email.Text = dataGridView1_Member.Rows[index].Cells[4].Value.ToString();
                textBox5_Gender.Text = dataGridView1_Member.Rows[index].Cells[5].Value.ToString();
                pictureBox1_ProfileImage.Image = ByteToImage(a.searchMember(ID).picture);
            }
        }
    }
}
