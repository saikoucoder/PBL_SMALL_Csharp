using PBL_SMALL_Csharp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_SMALL_Csharp.CUSTOM
{
    public partial class AlertForm : Form
    {
        public AlertForm()
        {
            InitializeComponent();
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }
        private int x, y;
        private AlertForm.enmAction action;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 4000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        public void showAlert(String msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            String fname;

            for(int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                AlertForm alertForm = (AlertForm)Application.OpenForms[fname];

                if(alertForm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5*i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    //this.pictureBox1.Image = Image.FromFile(@"D:\ONE DRIVE\OneDrive\TAI LIEU\Visual Studio 2022\.NET\PBL_SMALL_Csharp\PBL_SMALL_Csharp\Resources\ok_46px.png");
                    this.pictureBox1.Image = Resources.ok_46px;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    //pictureBox1.Image = Image.FromFile(@"D:\ONE DRIVE\OneDrive\TAI LIEU\Visual Studio 2022\.NET\PBL_SMALL_Csharp\PBL_SMALL_Csharp\Resources\error_cloud_48px.png");
                    this.pictureBox1.Image = Resources.error_cloud;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    //this.pictureBox1.Image = Image.FromFile(@"D:\ONE DRIVE\OneDrive\TAI LIEU\Visual Studio 2022\.NET\PBL_SMALL_Csharp\PBL_SMALL_Csharp\Resources\info_48px.png");
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    //this.pictureBox1.Image = Image.FromFile(@"D:\ONE DRIVE\OneDrive\TAI LIEU\Visual Studio 2022\.NET\PBL_SMALL_Csharp\PBL_SMALL_Csharp\Resources\warning_shield_48px.png");
                    this.pictureBox1.Image = Resources.Warning_;
                    this.BackColor = Color.DarkOrange;
                    break;
            }

            this.label1_msgbox.Text = msg;
            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
