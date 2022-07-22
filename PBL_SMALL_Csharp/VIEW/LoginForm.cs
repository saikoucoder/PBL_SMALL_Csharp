using PBL_SMALL_Csharp.CUSTOM;
using PBL_SMALL_Csharp.GUI;
using PBL_SMALL_Csharp.PRESENTER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL_SMALL_Csharp.DatabaseConnect;

namespace PBL_SMALL_Csharp
{
    public partial class LoginForm : Form
    {
        UserBLL a;
        public LoginForm()
        {
            InitializeComponent();
            a = new UserBLL();
        }

        Func_Class func = new Func_Class();

        private void button1_login_Click(object sender, EventArgs e)
        {
            //if (textBox1_Username.Text == "admin" && textBox1_Password.Text == "admin")
            //{
            //    this.Hide();
            //    DashboardForm dashboardForm = new DashboardForm();
            //    dashboardForm.ShowDialog();
            //}
            //else if(textBox1_Username.Text == "Username" && textBox1_Password.Text == "Password")
            //{
            //    func.Alert("Username and password are null", AlertForm.enmType.Warning);
            //}
            //else
            //{
            //    func.Alert("Username or password wrong", AlertForm.enmType.Error);
            //}
            if(a.log_in(textBox1_Username.Text, textBox1_Password.Text))
            {
                this.Hide();
                Console.WriteLine(a.status(textBox1_Username.Text));
                DashboardForm dashboardForm = new DashboardForm(a.status(textBox1_Username.Text));
                dashboardForm.ShowDialog();
            }
            else
            {
                func.Alert("Username or password wrong", AlertForm.enmType.Error);
            }


        }

        private void textBox1_Username_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1_Username.Text = "";
        }

        private void textBox1_Username_Leave(object sender, EventArgs e)
        {
            if (textBox1_Username.Text.Equals(""))
            {
                textBox1_Username.Text = "Username";
            }
            
        }

        private void textBox1_Password_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1_Password.Text = "";
            textBox1_Password.PasswordChar = '*';
        }

        private void textBox1_Password_Leave(object sender, EventArgs e)
        {
            if (textBox1_Password.Text.Equals(""))
            {
                textBox1_Password.Text = "Password";
            }
        }

        private void button1_login_MouseEnter(object sender, EventArgs e)
        {
            button1_login.ForeColor = Color.White;
            button1_login.BackColor = Color.ForestGreen;
        }

        private void button1_login_MouseLeave(object sender, EventArgs e)
        {
            
            button1_login.BackColor = Color.FromArgb(126, 200, 113);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
