namespace PBL_SMALL_Csharp.VIEW
{
    partial class ListMemberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1_Member = new System.Windows.Forms.DataGridView();
            this.label5_Gender = new System.Windows.Forms.Label();
            this.label6_Email = new System.Windows.Forms.Label();
            this.label8_Phone = new System.Windows.Forms.Label();
            this.label9_LastName = new System.Windows.Forms.Label();
            this.label54_FirstName = new System.Windows.Forms.Label();
            this.customPanel3 = new PBL_SMALL_Csharp.Custom.CustomPanel();
            this.pictureBox1_ProfileImage = new System.Windows.Forms.PictureBox();
            this.customPanel1 = new PBL_SMALL_Csharp.Custom.CustomPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button_WOC1_Search = new ePOSOne.btnProduct.Button_WOC();
            this.customPanel2 = new PBL_SMALL_Csharp.Custom.CustomPanel();
            this.textBox1_Search_Name = new System.Windows.Forms.TextBox();
            this.label54_ID_Member = new System.Windows.Forms.Label();
            this.textBox1_Firstname = new System.Windows.Forms.TextBox();
            this.textBox2_Lastname = new System.Windows.Forms.TextBox();
            this.textBox3_Phone = new System.Windows.Forms.TextBox();
            this.textBox4_Email = new System.Windows.Forms.TextBox();
            this.textBox5_Gender = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Member)).BeginInit();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_ProfileImage)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 763);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1245, 763);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox5_Gender);
            this.panel2.Controls.Add(this.textBox4_Email);
            this.panel2.Controls.Add(this.textBox3_Phone);
            this.panel2.Controls.Add(this.textBox2_Lastname);
            this.panel2.Controls.Add(this.textBox1_Firstname);
            this.panel2.Controls.Add(this.dataGridView1_Member);
            this.panel2.Controls.Add(this.label5_Gender);
            this.panel2.Controls.Add(this.label6_Email);
            this.panel2.Controls.Add(this.label8_Phone);
            this.panel2.Controls.Add(this.label9_LastName);
            this.panel2.Controls.Add(this.label54_FirstName);
            this.panel2.Controls.Add(this.customPanel3);
            this.panel2.Controls.Add(this.customPanel1);
            this.panel2.Controls.Add(this.button_WOC1_Search);
            this.panel2.Controls.Add(this.customPanel2);
            this.panel2.Controls.Add(this.textBox1_Search_Name);
            this.panel2.Controls.Add(this.label54_ID_Member);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1245, 763);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1_Member
            // 
            this.dataGridView1_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Member.Location = new System.Drawing.Point(67, 206);
            this.dataGridView1_Member.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1_Member.Name = "dataGridView1_Member";
            this.dataGridView1_Member.RowHeadersWidth = 51;
            this.dataGridView1_Member.RowTemplate.Height = 24;
            this.dataGridView1_Member.Size = new System.Drawing.Size(851, 453);
            this.dataGridView1_Member.TabIndex = 79;
            this.dataGridView1_Member.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Member_CellClick);
            // 
            // label5_Gender
            // 
            this.label5_Gender.AutoSize = true;
            this.label5_Gender.BackColor = System.Drawing.Color.Transparent;
            this.label5_Gender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_Gender.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5_Gender.Location = new System.Drawing.Point(967, 626);
            this.label5_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5_Gender.Name = "label5_Gender";
            this.label5_Gender.Size = new System.Drawing.Size(84, 22);
            this.label5_Gender.TabIndex = 73;
            this.label5_Gender.Text = "Gender:";
            // 
            // label6_Email
            // 
            this.label6_Email.AutoSize = true;
            this.label6_Email.BackColor = System.Drawing.Color.Transparent;
            this.label6_Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_Email.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6_Email.Location = new System.Drawing.Point(984, 585);
            this.label6_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6_Email.Name = "label6_Email";
            this.label6_Email.Size = new System.Drawing.Size(67, 22);
            this.label6_Email.TabIndex = 74;
            this.label6_Email.Text = "Email:";
            // 
            // label8_Phone
            // 
            this.label8_Phone.AutoSize = true;
            this.label8_Phone.BackColor = System.Drawing.Color.Transparent;
            this.label8_Phone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8_Phone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8_Phone.Location = new System.Drawing.Point(978, 539);
            this.label8_Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8_Phone.Name = "label8_Phone";
            this.label8_Phone.Size = new System.Drawing.Size(73, 22);
            this.label8_Phone.TabIndex = 75;
            this.label8_Phone.Text = "Phone:";
            // 
            // label9_LastName
            // 
            this.label9_LastName.AutoSize = true;
            this.label9_LastName.BackColor = System.Drawing.Color.Transparent;
            this.label9_LastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9_LastName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9_LastName.Location = new System.Drawing.Point(938, 494);
            this.label9_LastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9_LastName.Name = "label9_LastName";
            this.label9_LastName.Size = new System.Drawing.Size(113, 22);
            this.label9_LastName.TabIndex = 76;
            this.label9_LastName.Text = "Last Name:";
            // 
            // label54_FirstName
            // 
            this.label54_FirstName.AutoSize = true;
            this.label54_FirstName.BackColor = System.Drawing.Color.Transparent;
            this.label54_FirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54_FirstName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label54_FirstName.Location = new System.Drawing.Point(936, 448);
            this.label54_FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54_FirstName.Name = "label54_FirstName";
            this.label54_FirstName.Size = new System.Drawing.Size(115, 22);
            this.label54_FirstName.TabIndex = 77;
            this.label54_FirstName.Text = "First Name:";
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 180;
            this.customPanel3.Controls.Add(this.pictureBox1_ProfileImage);
            this.customPanel3.DradientAngle = 90F;
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.CornflowerBlue;
            this.customPanel3.GradientTopColor = System.Drawing.Color.DarkMagenta;
            this.customPanel3.Location = new System.Drawing.Point(961, 206);
            this.customPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(232, 213);
            this.customPanel3.TabIndex = 72;
            // 
            // pictureBox1_ProfileImage
            // 
            this.pictureBox1_ProfileImage.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1_ProfileImage.Image = global::PBL_SMALL_Csharp.Properties.Resources.generated_photos_5e6889316d3b380006f22d412;
            this.pictureBox1_ProfileImage.Location = new System.Drawing.Point(-12, -12);
            this.pictureBox1_ProfileImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1_ProfileImage.Name = "pictureBox1_ProfileImage";
            this.pictureBox1_ProfileImage.Size = new System.Drawing.Size(259, 252);
            this.pictureBox1_ProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_ProfileImage.TabIndex = 0;
            this.pictureBox1_ProfileImage.TabStop = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.Controls.Add(this.pictureBox2);
            this.customPanel1.Controls.Add(this.label27);
            this.customPanel1.DradientAngle = 30F;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1312, 68);
            this.customPanel1.TabIndex = 63;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PBL_SMALL_Csharp.Properties.Resources.list_48px;
            this.pictureBox2.Location = new System.Drawing.Point(469, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(532, 9);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(267, 42);
            this.label27.TabIndex = 37;
            this.label27.Text = "Members List";
            // 
            // button_WOC1_Search
            // 
            this.button_WOC1_Search.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1_Search.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1_Search.ButtonColor = System.Drawing.Color.SteelBlue;
            this.button_WOC1_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC1_Search.FlatAppearance.BorderSize = 0;
            this.button_WOC1_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1_Search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1_Search.ForeColor = System.Drawing.Color.Transparent;
            this.button_WOC1_Search.Location = new System.Drawing.Point(521, 135);
            this.button_WOC1_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_WOC1_Search.Name = "button_WOC1_Search";
            this.button_WOC1_Search.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1_Search.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.button_WOC1_Search.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1_Search.Size = new System.Drawing.Size(209, 34);
            this.button_WOC1_Search.TabIndex = 69;
            this.button_WOC1_Search.Text = "Search";
            this.button_WOC1_Search.TextColor = System.Drawing.Color.White;
            this.button_WOC1_Search.UseVisualStyleBackColor = false;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 0;
            this.customPanel2.DradientAngle = 30F;
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.customPanel2.Location = new System.Drawing.Point(-3, 709);
            this.customPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1315, 55);
            this.customPanel2.TabIndex = 66;
            // 
            // textBox1_Search_Name
            // 
            this.textBox1_Search_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_Search_Name.Location = new System.Drawing.Point(208, 140);
            this.textBox1_Search_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1_Search_Name.Name = "textBox1_Search_Name";
            this.textBox1_Search_Name.Size = new System.Drawing.Size(307, 28);
            this.textBox1_Search_Name.TabIndex = 57;
            // 
            // label54_ID_Member
            // 
            this.label54_ID_Member.AutoSize = true;
            this.label54_ID_Member.BackColor = System.Drawing.Color.Transparent;
            this.label54_ID_Member.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54_ID_Member.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label54_ID_Member.Location = new System.Drawing.Point(61, 142);
            this.label54_ID_Member.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54_ID_Member.Name = "label54_ID_Member";
            this.label54_ID_Member.Size = new System.Drawing.Size(139, 22);
            this.label54_ID_Member.TabIndex = 56;
            this.label54_ID_Member.Text = "Search Name:";
            // 
            // textBox1_Firstname
            // 
            this.textBox1_Firstname.Enabled = false;
            this.textBox1_Firstname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_Firstname.Location = new System.Drawing.Point(1057, 446);
            this.textBox1_Firstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1_Firstname.Name = "textBox1_Firstname";
            this.textBox1_Firstname.Size = new System.Drawing.Size(185, 28);
            this.textBox1_Firstname.TabIndex = 80;
            // 
            // textBox2_Lastname
            // 
            this.textBox2_Lastname.Enabled = false;
            this.textBox2_Lastname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_Lastname.Location = new System.Drawing.Point(1057, 492);
            this.textBox2_Lastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2_Lastname.Name = "textBox2_Lastname";
            this.textBox2_Lastname.Size = new System.Drawing.Size(185, 28);
            this.textBox2_Lastname.TabIndex = 81;
            // 
            // textBox3_Phone
            // 
            this.textBox3_Phone.Enabled = false;
            this.textBox3_Phone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_Phone.Location = new System.Drawing.Point(1057, 539);
            this.textBox3_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3_Phone.Name = "textBox3_Phone";
            this.textBox3_Phone.Size = new System.Drawing.Size(185, 28);
            this.textBox3_Phone.TabIndex = 82;
            // 
            // textBox4_Email
            // 
            this.textBox4_Email.Enabled = false;
            this.textBox4_Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_Email.Location = new System.Drawing.Point(1057, 583);
            this.textBox4_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4_Email.Name = "textBox4_Email";
            this.textBox4_Email.Size = new System.Drawing.Size(185, 28);
            this.textBox4_Email.TabIndex = 83;
            // 
            // textBox5_Gender
            // 
            this.textBox5_Gender.Enabled = false;
            this.textBox5_Gender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_Gender.Location = new System.Drawing.Point(1057, 624);
            this.textBox5_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5_Gender.Name = "textBox5_Gender";
            this.textBox5_Gender.Size = new System.Drawing.Size(185, 28);
            this.textBox5_Gender.TabIndex = 84;
            // 
            // ListMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 763);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListMemberForm";
            this.Text = "ListMemberForm";
            this.Load += new System.EventHandler(this.label1_Click);
            this.Leave += new System.EventHandler(this.label1_Click);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Member)).EndInit();
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_ProfileImage)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Custom.CustomPanel customPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label27;
        private ePOSOne.btnProduct.Button_WOC button_WOC1_Search;
        private Custom.CustomPanel customPanel2;
        private System.Windows.Forms.TextBox textBox1_Search_Name;
        private System.Windows.Forms.Label label54_ID_Member;
        private Custom.CustomPanel customPanel3;
        private System.Windows.Forms.PictureBox pictureBox1_ProfileImage;
        private System.Windows.Forms.Label label5_Gender;
        private System.Windows.Forms.Label label6_Email;
        private System.Windows.Forms.Label label8_Phone;
        private System.Windows.Forms.Label label9_LastName;
        private System.Windows.Forms.Label label54_FirstName;
        private System.Windows.Forms.DataGridView dataGridView1_Member;
        private System.Windows.Forms.TextBox textBox5_Gender;
        private System.Windows.Forms.TextBox textBox4_Email;
        private System.Windows.Forms.TextBox textBox3_Phone;
        private System.Windows.Forms.TextBox textBox2_Lastname;
        private System.Windows.Forms.TextBox textBox1_Firstname;
    }
}