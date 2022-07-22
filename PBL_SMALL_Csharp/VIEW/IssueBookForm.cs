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
    public partial class IssueBookForm : Form
    {
        IssueBLL a;
        MemberBLL b;
        BookBLL c;

        public IssueBookForm()
        {
            InitializeComponent();
            a = new IssueBLL();
            b = new MemberBLL();
            c = new BookBLL();
        }
            PRESENTER.Func_Class func = new PRESENTER.Func_Class();

    

        private void button_WOC1_IssueBook_Click(object sender, EventArgs e)
        {
            try
            {
                Issue issue = new Issue();
                int i = 0;
                issue.ID_Member = Int32.Parse(textBox1_IDMember.Text);
                issue.ID_Book = Int32.Parse(textBox2_IDBook.Text);
                issue.Date_Borrow = dateTimePicker1_IssueDate.Value.ToString("yyyy-MM-dd");
                issue.Date_Return = dateTimePicker2_ReturnDate.Value.ToString("yyyy-MM-dd");
                if(!b.checkID(issue.ID_Member))
                {
                    func.Alert("Member Not Exist!", AlertForm.enmType.Warning);
                    i++;
                }
                else if(!c.checkID(issue.ID_Book))
                {
                    func.Alert("Book issue failed!", AlertForm.enmType.Error);
                    i++;
                }
                else if(dateTimePicker1_IssueDate.Value.Date > dateTimePicker2_ReturnDate.Value.Date)
                {
                    func.Alert("Return date must be after the Issue date!", AlertForm.enmType.Warning);
                    i++;
                }
                if (i == 0)
                {
                    if (a.addIssue(issue))
                    {
                        func.Alert("Borrow Successful!", AlertForm.enmType.Success);
                        resetField();
                    }
                    else
                    {
                        func.Alert("Borrow Unsuccessful!", AlertForm.enmType.Error);
                        resetField();
                    }
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void resetField()
        {
            textBox1_IDMember.Text = "";
            label5_MemberName.Visible = false;
            textBox2_IDBook.Text = "";
            label7_BookName.Visible = false;
            label7_Available.Text = "";

            dateTimePicker1_IssueDate = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2_ReturnDate = new System.Windows.Forms.DateTimePicker();

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            try
            {
                if(b.searchMember(Int32.Parse(textBox1_IDMember.Text)).firstName == null)
                {
                    func.Alert("ID Member not available!", AlertForm.enmType.Warning    );
                }
                else
                {
                    label5_MemberName.Visible = true;
                    label5_MemberName.Text = b.searchMember(Int32.Parse(textBox1_IDMember.Text)).firstName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            try
            {
                if (c.searchBook(Int32.Parse(textBox2_IDBook.Text)).isbn == null)
                {
                    label7_Available.Visible = true;
                    label7_Available.Text = "Not Available!";
                }
                else
                {
                    label7_BookName.Visible = true;
                    label7_BookName.Text = c.searchBook(Int32.Parse(textBox2_IDBook.Text)).isbn;
                    if(c.searchBook(Int32.Parse(textBox2_IDBook.Text)).quantity == 0)
                    {
                        label7_Available.Visible = true;
                        label7_Available.Text = "Out of stock!";
                    }
                    else
                    {
                        label7_Available.Visible = true;
                        label7_Available.Text = "Available!";
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
