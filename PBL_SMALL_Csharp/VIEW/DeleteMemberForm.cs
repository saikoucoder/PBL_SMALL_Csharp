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
using PBL_SMALL_Csharp.CUSTOM;

namespace PBL_SMALL_Csharp.VIEW
{
    public partial class DeleteMemberForm : Form
    {
        MemberBLL a;
        public DeleteMemberForm()
        {
            InitializeComponent();
            a = new MemberBLL();
        }

        PRESENTER.Func_Class func = new PRESENTER.Func_Class();

        private void button_WOC1_DelMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1_ID_Member.Text == "")
                {
                    label5_emptyID.Visible = true;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you sure to delete this member? ", "Delete Member", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string b = textBox1_ID_Member.Text;
                        if (a.deleteMember(int.Parse(b)))
                            func.Alert("Delete member successful", AlertForm.enmType.Success);
                        else
                            func.Alert("Delete member unsuccessful", AlertForm.enmType.Error);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        func.Alert("Cancle delete member", AlertForm.enmType.Info);
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
            textBox1_ID_Member.Text = "";
            label5_emptyID.Visible = false;
        }


        private void button_WOC1_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1_ID_Member.Text == "")
                {
                    label5_emptyID.Visible = true;
                }
                else
                {
                    label5_emptyID.Visible = false;
                    string b = textBox1_ID_Member.Text;
                    if (a.checkID(int.Parse(b)))
                    {
                        MessageBox.Show("Member available!");
                    }
                    else
                    {
                        MessageBox.Show("Member not available!");
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
