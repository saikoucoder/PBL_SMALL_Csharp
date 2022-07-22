using PBL_SMALL_Csharp.PRESENTER;
using PBL_SMALL_Csharp.VIEW;
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
using PBL_SMALL_Csharp.Properties;

namespace PBL_SMALL_Csharp.GUI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            OpenForm<HomeForm>();           
        }
        public DashboardForm(User a)
        {
            
           
            InitializeComponent();
            OpenForm<HomeForm>();
            if(a.Usertype != "admin")
            {
                label18.Visible = false;
                label19_ManagerUser.Visible = false;   
                panel7.Visible = false;
            }
            string b = "";
            b = b + "Hello " + a.FirstName + " " + a.LastName + ". Have a nice day !";
            label2_hello.Text = b;
        }

        Func_Class func = new Func_Class();

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7_DashBoard.ForeColor = Color.Black;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7_DashBoard.ForeColor = Color.DarkGray;
        }

        private void label8_AddMember_MouseEnter(object sender, EventArgs e)
        {
            label8_AddMember.ForeColor = Color.Black;
        }

        private void label8_AddMember_MouseLeave(object sender, EventArgs e)
        {
            label8_AddMember.ForeColor = Color.DarkGray;
        }

        private void label8_AddMember_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label9_EditMember_MouseEnter(object sender, EventArgs e)
        {
            label9_EditMember.ForeColor = Color.Black;
        }

        private void label9_EditMember_MouseLeave(object sender, EventArgs e)
        {
            label9_EditMember.ForeColor = Color.DarkGray;
        }

        private void label9_EditMember_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label10_DeleteMember_MouseEnter(object sender, EventArgs e)
        {
            label10_DeleteMember.ForeColor = Color.Black;
        }

        private void label10_DeleteMember_MouseLeave(object sender, EventArgs e)
        {
            label10_DeleteMember.ForeColor = Color.DarkGray;
        }

        private void label10_DeleteMember_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label11_MemberList_MouseEnter(object sender, EventArgs e)
        {
            label11_MemberList.ForeColor = Color.Black;
        }

        private void label11_MemberList_MouseLeave(object sender, EventArgs e)
        {
            label11_MemberList.ForeColor = Color.DarkGray;
        }

        private void label11_MemberList_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label12_AddBook_MouseEnter(object sender, EventArgs e)
        {
            label12_AddBook.ForeColor = Color.Black;
        }

        private void label12_AddBook_MouseLeave(object sender, EventArgs e)
        {
            label12_AddBook.ForeColor = Color.DarkGray;
        }

        private void label12_AddBook_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label13_EditBook_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label13_EditBook_MouseEnter(object sender, EventArgs e)
        {
            label13_EditBook.ForeColor = Color.Black;
        }

        private void label13_EditBook_MouseLeave(object sender, EventArgs e)
        {
            label13_EditBook.ForeColor = Color.DarkGray;
        }

        private void label14_DeleteBook_MouseEnter(object sender, EventArgs e)
        {
            label14_DeleteBook.ForeColor = Color.Black;
        }

        private void label14_DeleteBook_MouseLeave(object sender, EventArgs e)
        {
            label14_DeleteBook.ForeColor = Color.DarkGray;
        }

        private void label14_DeleteBook_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label15_BookList_MouseEnter(object sender, EventArgs e)
        {
            label15_BookList.ForeColor = Color.Black;
        }

        private void label15_BookList_MouseLeave(object sender, EventArgs e)
        {
            label15_BookList.ForeColor = Color.DarkGray;
        }

        private void label15_BookList_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label16_IssueBook_MouseEnter(object sender, EventArgs e)
        {
            label16_IssueBook.ForeColor = Color.Black;
        }

        private void label16_IssueBook_MouseLeave(object sender, EventArgs e)
        {
            label16_IssueBook.ForeColor = Color.DarkGray;
        }

        private void label16_IssueBook_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label17_ReturnBook_MouseEnter(object sender, EventArgs e)
        {
            label17_ReturnBook.ForeColor = Color.Black;
        }

        private void label17_ReturnBook_MouseLeave(object sender, EventArgs e)
        {
            label17_ReturnBook.ForeColor = Color.DarkGray;
        }

        private void label17_ReturnBook_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label19_ManagerUser_MouseEnter(object sender, EventArgs e)
        {
            label19_ManagerUser.ForeColor = Color.Violet;
        }

        private void label19_ManagerUser_MouseLeave(object sender, EventArgs e)
        {
            label19_ManagerUser.ForeColor = Color.DarkGray;
        }

        private void label19_ManagerUser_MouseClick(object sender, MouseEventArgs e)
        {
            OpenForm<UserManagerForm>();
        }

        private void label7_DashBoard_Click(object sender, EventArgs e)
        {
            OpenForm<HomeForm>();
        }

        private void label8_AddMember_Click(object sender, EventArgs e)
        {
            OpenForm<AddMemberForm>();
        }

        private void label9_EditMember_Click(object sender, EventArgs e)
        {
            OpenForm<EditMemberForm>();
        }

        private void label10_DeleteMember_Click(object sender, EventArgs e)
        {
            OpenForm<DeleteMemberForm>();
        }

        private void label11_MemberList_Click(object sender, EventArgs e)
        {
            this.Refresh();
            ListMemberForm a = new ListMemberForm();   
            OpenForm<ListMemberForm>();
        }

        private void label12_AddBook_Click(object sender, EventArgs e)
        {
            OpenForm<AddBookForm>();
        }

        private void label13_EditBook_Click(object sender, EventArgs e)
        {
            OpenForm<EditBookForm>();
        }

        private void label14_DeleteBook_Click(object sender, EventArgs e)
        {
            OpenForm<DeleteBookForm>();
        }

        private void label15_BookList_Click(object sender, EventArgs e)
        {
            OpenForm<ListBookForm>();
        }

        private void label16_IssueBook_Click(object sender, EventArgs e)
        {
            OpenForm<IssueBookForm>();
        }

        private void label17_ReturnBook_Click(object sender, EventArgs e)
        {
            //OpenForm<ReturnBookForm>();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void OpenForm<MiForm>() where MiForm : Form, new()
        {
            Form form;
            form = panel8_MainDisplay.Controls.OfType<MiForm>().FirstOrDefault();//Search the collection for the form

            if (form == null)
            {
                form = new MiForm();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panel8_MainDisplay.Controls.Add(form);
                panel8_MainDisplay.Tag = form;
                form.Show();
                form.Show();
                form.BringToFront();
            }
            else
            {
                form = new MiForm();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panel8_MainDisplay.Controls.Remove(form);
                panel8_MainDisplay.Controls.Add(form);
                panel8_MainDisplay.Tag = form;
                form.Show();
                form.Show();
                form.BringToFront();
            }
        }
    }
}
