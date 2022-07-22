namespace PBL_SMALL_Csharp.VIEW
{
    partial class UserManagerForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1_User = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10_EmptyREPassword = new System.Windows.Forms.Label();
            this.label9_EmptyPass = new System.Windows.Forms.Label();
            this.label6_Empty_Fname = new System.Windows.Forms.Label();
            this.label7_EmtyLname = new System.Windows.Forms.Label();
            this.textBox1_REPassword = new System.Windows.Forms.TextBox();
            this.textBox1_Password = new System.Windows.Forms.TextBox();
            this.textBox1_Username = new System.Windows.Forms.TextBox();
            this.textBox1_FirstName = new System.Windows.Forms.TextBox();
            this.textBox1_LastName = new System.Windows.Forms.TextBox();
            this.textBox1_ID_User = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1_LastName = new System.Windows.Forms.Label();
            this.label54_ID_Member = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1_DelUser = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1_AddUser = new ePOSOne.btnProduct.Button_WOC();
            this.customPanel1 = new PBL_SMALL_Csharp.Custom.CustomPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button_WOC1_EditUser = new ePOSOne.btnProduct.Button_WOC();
            this.customPanel2 = new PBL_SMALL_Csharp.Custom.CustomPanel();
            this.ID_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_User)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 763);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button_WOC1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dataGridView1_User);
            this.panel2.Controls.Add(this.button_WOC1_DelUser);
            this.panel2.Controls.Add(this.button_WOC1_AddUser);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.customPanel1);
            this.panel2.Controls.Add(this.button_WOC1_EditUser);
            this.panel2.Controls.Add(this.customPanel2);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10_EmptyREPassword);
            this.panel2.Controls.Add(this.label9_EmptyPass);
            this.panel2.Controls.Add(this.label6_Empty_Fname);
            this.panel2.Controls.Add(this.label7_EmtyLname);
            this.panel2.Controls.Add(this.textBox1_REPassword);
            this.panel2.Controls.Add(this.textBox1_Password);
            this.panel2.Controls.Add(this.textBox1_Username);
            this.panel2.Controls.Add(this.textBox1_FirstName);
            this.panel2.Controls.Add(this.textBox1_LastName);
            this.panel2.Controls.Add(this.textBox1_ID_User);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1_LastName);
            this.panel2.Controls.Add(this.label54_ID_Member);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 763);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(274, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "* Enter the username";
            this.label5.Visible = false;
            // 
            // dataGridView1_User
            // 
            this.dataGridView1_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_User,
            this.FirstName,
            this.LastName,
            this.Username,
            this.Password,
            this.Usertype});
            this.dataGridView1_User.Location = new System.Drawing.Point(583, 131);
            this.dataGridView1_User.Name = "dataGridView1_User";
            this.dataGridView1_User.RowHeadersWidth = 51;
            this.dataGridView1_User.RowTemplate.Height = 24;
            this.dataGridView1_User.Size = new System.Drawing.Size(623, 449);
            this.dataGridView1_User.TabIndex = 72;
            this.dataGridView1_User.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_User_CellClick);
            this.dataGridView1_User.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_User_CellContentClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F);
            this.checkBox1.Location = new System.Drawing.Point(272, 582);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(221, 26);
            this.checkBox1.TabIndex = 69;
            this.checkBox1.Text = "Make User To Admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(221, 504);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 20);
            this.label16.TabIndex = 65;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(221, 427);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 65;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(221, 360);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 65;
            this.label14.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(224, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(223, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 65;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(226, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 65;
            this.label12.Text = "*";
            // 
            // label10_EmptyREPassword
            // 
            this.label10_EmptyREPassword.AutoSize = true;
            this.label10_EmptyREPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10_EmptyREPassword.ForeColor = System.Drawing.Color.Red;
            this.label10_EmptyREPassword.Location = new System.Drawing.Point(274, 527);
            this.label10_EmptyREPassword.Name = "label10_EmptyREPassword";
            this.label10_EmptyREPassword.Size = new System.Drawing.Size(186, 20);
            this.label10_EmptyREPassword.TabIndex = 58;
            this.label10_EmptyREPassword.Text = "* Enter the re-password";
            this.label10_EmptyREPassword.Visible = false;
            // 
            // label9_EmptyPass
            // 
            this.label9_EmptyPass.AutoSize = true;
            this.label9_EmptyPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9_EmptyPass.ForeColor = System.Drawing.Color.Red;
            this.label9_EmptyPass.Location = new System.Drawing.Point(274, 456);
            this.label9_EmptyPass.Name = "label9_EmptyPass";
            this.label9_EmptyPass.Size = new System.Drawing.Size(165, 20);
            this.label9_EmptyPass.TabIndex = 58;
            this.label9_EmptyPass.Text = "* Enter the password";
            this.label9_EmptyPass.Visible = false;
            // 
            // label6_Empty_Fname
            // 
            this.label6_Empty_Fname.AutoSize = true;
            this.label6_Empty_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6_Empty_Fname.ForeColor = System.Drawing.Color.Red;
            this.label6_Empty_Fname.Location = new System.Drawing.Point(272, 225);
            this.label6_Empty_Fname.Name = "label6_Empty_Fname";
            this.label6_Empty_Fname.Size = new System.Drawing.Size(168, 20);
            this.label6_Empty_Fname.TabIndex = 58;
            this.label6_Empty_Fname.Text = "* Enter the first name";
            this.label6_Empty_Fname.Visible = false;
            // 
            // label7_EmtyLname
            // 
            this.label7_EmtyLname.AutoSize = true;
            this.label7_EmtyLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7_EmtyLname.ForeColor = System.Drawing.Color.Red;
            this.label7_EmtyLname.Location = new System.Drawing.Point(274, 302);
            this.label7_EmtyLname.Name = "label7_EmtyLname";
            this.label7_EmtyLname.Size = new System.Drawing.Size(166, 20);
            this.label7_EmtyLname.TabIndex = 58;
            this.label7_EmtyLname.Text = "* Enter the last name";
            this.label7_EmtyLname.Visible = false;
            // 
            // textBox1_REPassword
            // 
            this.textBox1_REPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_REPassword.Location = new System.Drawing.Point(272, 496);
            this.textBox1_REPassword.Name = "textBox1_REPassword";
            this.textBox1_REPassword.Size = new System.Drawing.Size(243, 28);
            this.textBox1_REPassword.TabIndex = 57;
            // 
            // textBox1_Password
            // 
            this.textBox1_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_Password.Location = new System.Drawing.Point(272, 425);
            this.textBox1_Password.Name = "textBox1_Password";
            this.textBox1_Password.Size = new System.Drawing.Size(243, 28);
            this.textBox1_Password.TabIndex = 57;
            // 
            // textBox1_Username
            // 
            this.textBox1_Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_Username.Location = new System.Drawing.Point(272, 352);
            this.textBox1_Username.Name = "textBox1_Username";
            this.textBox1_Username.Size = new System.Drawing.Size(243, 28);
            this.textBox1_Username.TabIndex = 57;
            // 
            // textBox1_FirstName
            // 
            this.textBox1_FirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_FirstName.Location = new System.Drawing.Point(275, 194);
            this.textBox1_FirstName.Name = "textBox1_FirstName";
            this.textBox1_FirstName.Size = new System.Drawing.Size(239, 28);
            this.textBox1_FirstName.TabIndex = 57;
            // 
            // textBox1_LastName
            // 
            this.textBox1_LastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_LastName.Location = new System.Drawing.Point(274, 271);
            this.textBox1_LastName.Name = "textBox1_LastName";
            this.textBox1_LastName.Size = new System.Drawing.Size(239, 28);
            this.textBox1_LastName.TabIndex = 57;
            // 
            // textBox1_ID_User
            // 
            this.textBox1_ID_User.Enabled = false;
            this.textBox1_ID_User.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_ID_User.Location = new System.Drawing.Point(275, 127);
            this.textBox1_ID_User.Name = "textBox1_ID_User";
            this.textBox1_ID_User.Size = new System.Drawing.Size(239, 28);
            this.textBox1_ID_User.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(83, 499);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 56;
            this.label4.Text = "Re-Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(108, 425);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(106, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(112, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 56;
            this.label2.Text = "Username:";
            // 
            // label1_LastName
            // 
            this.label1_LastName.AutoSize = true;
            this.label1_LastName.BackColor = System.Drawing.Color.Transparent;
            this.label1_LastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_LastName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1_LastName.Location = new System.Drawing.Point(108, 277);
            this.label1_LastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_LastName.Name = "label1_LastName";
            this.label1_LastName.Size = new System.Drawing.Size(113, 22);
            this.label1_LastName.TabIndex = 56;
            this.label1_LastName.Text = "Last Name:";
            // 
            // label54_ID_Member
            // 
            this.label54_ID_Member.AutoSize = true;
            this.label54_ID_Member.BackColor = System.Drawing.Color.Transparent;
            this.label54_ID_Member.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54_ID_Member.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label54_ID_Member.Location = new System.Drawing.Point(122, 129);
            this.label54_ID_Member.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54_ID_Member.Name = "label54_ID_Member";
            this.label54_ID_Member.Size = new System.Drawing.Size(84, 22);
            this.label54_ID_Member.TabIndex = 56;
            this.label54_ID_Member.Text = "ID User:";
            this.label54_ID_Member.Click += new System.EventHandler(this.label54_ID_Member_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(728, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 20);
            this.label6.TabIndex = 75;
            this.label6.Text = "This table only shows the users of the system!";
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.RoyalBlue;
            this.button_WOC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.White;
            this.button_WOC1.Location = new System.Drawing.Point(543, 641);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.White;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Blue;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(162, 48);
            this.button_WOC1.TabIndex = 74;
            this.button_WOC1.Text = "Reset";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // button_WOC1_DelUser
            // 
            this.button_WOC1_DelUser.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1_DelUser.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1_DelUser.ButtonColor = System.Drawing.Color.IndianRed;
            this.button_WOC1_DelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC1_DelUser.FlatAppearance.BorderSize = 0;
            this.button_WOC1_DelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1_DelUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1_DelUser.ForeColor = System.Drawing.Color.White;
            this.button_WOC1_DelUser.Location = new System.Drawing.Point(375, 641);
            this.button_WOC1_DelUser.Name = "button_WOC1_DelUser";
            this.button_WOC1_DelUser.OnHoverBorderColor = System.Drawing.Color.White;
            this.button_WOC1_DelUser.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_WOC1_DelUser.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1_DelUser.Size = new System.Drawing.Size(162, 48);
            this.button_WOC1_DelUser.TabIndex = 71;
            this.button_WOC1_DelUser.Text = "Delete User";
            this.button_WOC1_DelUser.TextColor = System.Drawing.Color.White;
            this.button_WOC1_DelUser.UseVisualStyleBackColor = false;
            this.button_WOC1_DelUser.Click += new System.EventHandler(this.button_WOC1_DelUser_Click);
            // 
            // button_WOC1_AddUser
            // 
            this.button_WOC1_AddUser.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1_AddUser.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1_AddUser.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(200)))), ((int)(((byte)(113)))));
            this.button_WOC1_AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC1_AddUser.FlatAppearance.BorderSize = 0;
            this.button_WOC1_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1_AddUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1_AddUser.ForeColor = System.Drawing.Color.White;
            this.button_WOC1_AddUser.Location = new System.Drawing.Point(72, 641);
            this.button_WOC1_AddUser.Name = "button_WOC1_AddUser";
            this.button_WOC1_AddUser.OnHoverBorderColor = System.Drawing.Color.White;
            this.button_WOC1_AddUser.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.button_WOC1_AddUser.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1_AddUser.Size = new System.Drawing.Size(142, 48);
            this.button_WOC1_AddUser.TabIndex = 70;
            this.button_WOC1_AddUser.Text = "Add User";
            this.button_WOC1_AddUser.TextColor = System.Drawing.Color.White;
            this.button_WOC1_AddUser.UseVisualStyleBackColor = false;
            this.button_WOC1_AddUser.Click += new System.EventHandler(this.button_WOC1_AddUser_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.Controls.Add(this.pictureBox2);
            this.customPanel1.Controls.Add(this.label27);
            this.customPanel1.DradientAngle = 30F;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(200)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(148)))), ((int)(((byte)(251)))));
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1312, 68);
            this.customPanel1.TabIndex = 63;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PBL_SMALL_Csharp.Properties.Resources.more_info_48px;
            this.pictureBox2.Location = new System.Drawing.Point(469, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.label27.Size = new System.Drawing.Size(274, 42);
            this.label27.TabIndex = 37;
            this.label27.Text = "Manage Users";
            // 
            // button_WOC1_EditUser
            // 
            this.button_WOC1_EditUser.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1_EditUser.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1_EditUser.ButtonColor = System.Drawing.Color.Gold;
            this.button_WOC1_EditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC1_EditUser.FlatAppearance.BorderSize = 0;
            this.button_WOC1_EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1_EditUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1_EditUser.ForeColor = System.Drawing.Color.White;
            this.button_WOC1_EditUser.Location = new System.Drawing.Point(220, 641);
            this.button_WOC1_EditUser.Name = "button_WOC1_EditUser";
            this.button_WOC1_EditUser.OnHoverBorderColor = System.Drawing.Color.White;
            this.button_WOC1_EditUser.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC1_EditUser.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1_EditUser.Size = new System.Drawing.Size(149, 48);
            this.button_WOC1_EditUser.TabIndex = 68;
            this.button_WOC1_EditUser.Text = "Edit User";
            this.button_WOC1_EditUser.TextColor = System.Drawing.Color.White;
            this.button_WOC1_EditUser.UseVisualStyleBackColor = false;
            this.button_WOC1_EditUser.Click += new System.EventHandler(this.button_WOC1_EditUser_Click);
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 0;
            this.customPanel2.DradientAngle = 30F;
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(200)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(148)))), ((int)(((byte)(251)))));
            this.customPanel2.Location = new System.Drawing.Point(-3, 709);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1315, 55);
            this.customPanel2.TabIndex = 66;
            // 
            // ID_User
            // 
            this.ID_User.DataPropertyName = "ID_User";
            this.ID_User.HeaderText = "ID User";
            this.ID_User.MinimumWidth = 6;
            this.ID_User.Name = "ID_User";
            this.ID_User.Visible = false;
            this.ID_User.Width = 75;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 115;
            // 
            // Usertype
            // 
            this.Usertype.DataPropertyName = "Usertype";
            this.Usertype.HeaderText = "Usertype";
            this.Usertype.MinimumWidth = 6;
            this.Usertype.Name = "Usertype";
            this.Usertype.Visible = false;
            this.Usertype.Width = 125;
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 763);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagerForm";
            this.Text = "UserManagerForm";
            this.Load += new System.EventHandler(this.label1_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_User)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Custom.CustomPanel customPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label27;
        private ePOSOne.btnProduct.Button_WOC button_WOC1_EditUser;
        private Custom.CustomPanel customPanel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10_EmptyREPassword;
        private System.Windows.Forms.Label label9_EmptyPass;
        private System.Windows.Forms.Label label6_Empty_Fname;
        private System.Windows.Forms.Label label7_EmtyLname;
        private System.Windows.Forms.TextBox textBox1_Password;
        private System.Windows.Forms.TextBox textBox1_FirstName;
        private System.Windows.Forms.TextBox textBox1_LastName;
        private System.Windows.Forms.TextBox textBox1_ID_User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1_LastName;
        private System.Windows.Forms.Label label54_ID_Member;
        private System.Windows.Forms.TextBox textBox1_REPassword;
        private System.Windows.Forms.CheckBox checkBox1;
        private ePOSOne.btnProduct.Button_WOC button_WOC1_AddUser;
        private System.Windows.Forms.DataGridView dataGridView1_User;
        public System.Windows.Forms.TextBox textBox1_Username;
        private System.Windows.Forms.Label label5;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC button_WOC1_DelUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usertype;
    }
}