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
    public partial class UserManagerForm : Form
    {
        UserBLL c;
        public UserManagerForm()
        {
            InitializeComponent();
            c = new UserBLL();
        }

        PRESENTER.Func_Class func = new PRESENTER.Func_Class();

        private void label1_Click(object sender, EventArgs e)
        {
            showAllUser();
        }

        private void label54_ID_Member_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                User us = new User();
                us.FirstName = textBox1_FirstName.Text;
                us.LastName = textBox1_LastName.Text;
                us.Username = textBox1_Username.Text;
                us.Password = textBox1_Password.Text;
                if(checkBox1.Checked == true)
                {
                    us.Usertype = "admin";
                }
                else
                {
                    us.Usertype = "user";
                }
                if(!c.checkUsername(us.Username))
                {
                    func.Alert("Username already taken!", AlertForm.enmType.Warning);
                }
                else
                {
                    if (c.addUser(us))
                    {
                        func.Alert("Add Successful!", AlertForm.enmType.Success);
                        resetField();
                    }
                    else
                    {
                        func.Alert("Add Unsuccessful!", AlertForm.enmType.Error);
                        resetField();
                    }
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void showAllUser()
        {
            DataTable dt = c.getAllUser();
            dataGridView1_User.DataSource = dt;
        }

        private void dataGridView1_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_WOC1_EditUser_Click(object sender, EventArgs e)
        {
            try
            {
                User us = new User();
                us.ID_User = int.Parse(textBox1_ID_User.Text);
                us.FirstName = textBox1_FirstName.Text;
                us.LastName = textBox1_LastName.Text;
                us.Username = textBox1_Username.Text;
                us.Password = textBox1_Password.Text;
                if (checkBox1.Checked == true)
                {
                    us.Usertype = "admin";
                }
                else
                {
                    us.Usertype = "user";
                }

                if (c.editUser(us))
                {
                    func.Alert("Edit Successful!", AlertForm.enmType.Success);
                    resetField();
                }
                else
                {
                    func.Alert("Edit UnSuccessful!", AlertForm.enmType.Error);
                    resetField();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int ID;
        private void dataGridView1_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1_Username.Enabled = false;
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = Int32.Parse(dataGridView1_User.Rows[index].Cells[0].Value.ToString());
                textBox1_ID_User.Text = dataGridView1_User.Rows[index].Cells[0].Value.ToString();
                textBox1_FirstName.Text = dataGridView1_User.Rows[index].Cells[1].Value.ToString();
                textBox1_LastName.Text = dataGridView1_User.Rows[index].Cells[2].Value.ToString();
                textBox1_Username.Text = dataGridView1_User.Rows[index].Cells[3].Value.ToString();
                textBox1_Password.Text = dataGridView1_User.Rows[index].Cells[4].Value.ToString();
                if (dataGridView1_User.Rows[index].Cells[5].Value.ToString() == "admin")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
        }

        private void button_WOC1_DelUser_Click(object sender, EventArgs e)
        {
            try
            {
                string b = textBox1_ID_User.Text;


                DialogResult dialogResult = MessageBox.Show("Warning", "Do you sure to delete this user?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (c.deleteUser(int.Parse(b)))
                    {
                        func.Alert("Delete Successful!", AlertForm.enmType.Success);
                        resetField();
                    }
                    else
                    {
                        func.Alert("Delete UnSuccessful!", AlertForm.enmType.Error);
                        resetField();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    func.Alert("Cancle delete user", AlertForm.enmType.Info);
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
            textBox1_ID_User.Text = String.Empty;
            textBox1_FirstName.Text = String.Empty;
            textBox1_LastName.Text = String.Empty;
            textBox1_Password.Text = String.Empty;
            textBox1_REPassword.Text = String.Empty;
            textBox1_Username.Text = String.Empty;
            textBox1_Username.Enabled = true;
            checkBox1.Checked = false;
            showAllUser();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            textBox1_ID_User.Text = String.Empty;
            textBox1_FirstName.Text = String.Empty;
            textBox1_LastName.Text = String.Empty;
            textBox1_Password.Text = String.Empty;
            textBox1_REPassword.Text = String.Empty;
            textBox1_Username.Text = String.Empty;
            textBox1_Username.Enabled = true;
            checkBox1.Checked = false;

            showAllUser();
        }
    }
}
