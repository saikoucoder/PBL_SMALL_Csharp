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
using PBL_SMALL_Csharp;

namespace PBL_SMALL_Csharp.GUI
{
    public partial class HomeForm : Form
    {
        MemberBLL a;
        public HomeForm()
        {
            InitializeComponent();
            a = new MemberBLL();
            displayCount();
        }

        PRESENTER.Func_Class func = new PRESENTER.Func_Class();

        private void HomeForm_Click(object sender, EventArgs e)
        {
            label24.Text = a.total().ToString();    
        }

        public void displayCount()
        {
            label24.Text = func.total("book").ToString();
            label25.Text = func.total("member").ToString();
            label26.Text = func.total("users").ToString();
        }
    }
}
