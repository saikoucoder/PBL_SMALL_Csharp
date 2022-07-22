namespace PBL_SMALL_Csharp.VIEW
{
    partial class ListBookForm
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
            this.dataGridView1_Book = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5_DateAdd = new System.Windows.Forms.Label();
            this.label4_Price = new System.Windows.Forms.Label();
            this.label2_Quantity = new System.Windows.Forms.Label();
            this.label1_Name = new System.Windows.Forms.Label();
            this.label54_ISBN = new System.Windows.Forms.Label();
            this.pictureBox1_BookCover = new System.Windows.Forms.PictureBox();
            this.customPanel1 = new PBL_SMALL_Csharp.Custom.CustomPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button_WOC1_SearchName = new ePOSOne.btnProduct.Button_WOC();
            this.customPanel2 = new PBL_SMALL_Csharp.Custom.CustomPanel();
            this.textBox1_Search_Name = new System.Windows.Forms.TextBox();
            this.label54_ID_Member = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1_ISBN = new System.Windows.Forms.TextBox();
            this.textBox2_Name = new System.Windows.Forms.TextBox();
            this.textBox3_Quantity = new System.Windows.Forms.TextBox();
            this.textBox4_Price = new System.Windows.Forms.TextBox();
            this.textBox5_DateAdd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Book)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_BookCover)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1_Book
            // 
            this.dataGridView1_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Book.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1_Book.Name = "dataGridView1_Book";
            this.dataGridView1_Book.RowHeadersWidth = 51;
            this.dataGridView1_Book.RowTemplate.Height = 24;
            this.dataGridView1_Book.Size = new System.Drawing.Size(959, 525);
            this.dataGridView1_Book.TabIndex = 79;
            this.dataGridView1_Book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Book_CellClick);
            this.dataGridView1_Book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Book_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1246, 763);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox5_DateAdd);
            this.panel2.Controls.Add(this.textBox4_Price);
            this.panel2.Controls.Add(this.textBox3_Quantity);
            this.panel2.Controls.Add(this.textBox2_Name);
            this.panel2.Controls.Add(this.textBox1_ISBN);
            this.panel2.Controls.Add(this.label5_DateAdd);
            this.panel2.Controls.Add(this.label4_Price);
            this.panel2.Controls.Add(this.label2_Quantity);
            this.panel2.Controls.Add(this.label1_Name);
            this.panel2.Controls.Add(this.label54_ISBN);
            this.panel2.Controls.Add(this.pictureBox1_BookCover);
            this.panel2.Controls.Add(this.dataGridView1_Book);
            this.panel2.Controls.Add(this.customPanel1);
            this.panel2.Controls.Add(this.button_WOC1_SearchName);
            this.panel2.Controls.Add(this.customPanel2);
            this.panel2.Controls.Add(this.textBox1_Search_Name);
            this.panel2.Controls.Add(this.label54_ID_Member);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 763);
            this.panel2.TabIndex = 2;
            // 
            // label5_DateAdd
            // 
            this.label5_DateAdd.AutoSize = true;
            this.label5_DateAdd.BackColor = System.Drawing.Color.Transparent;
            this.label5_DateAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_DateAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5_DateAdd.Location = new System.Drawing.Point(972, 584);
            this.label5_DateAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5_DateAdd.Name = "label5_DateAdd";
            this.label5_DateAdd.Size = new System.Drawing.Size(102, 22);
            this.label5_DateAdd.TabIndex = 80;
            this.label5_DateAdd.Text = "Date Add:";
            // 
            // label4_Price
            // 
            this.label4_Price.AutoSize = true;
            this.label4_Price.BackColor = System.Drawing.Color.Transparent;
            this.label4_Price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_Price.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4_Price.Location = new System.Drawing.Point(1010, 532);
            this.label4_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4_Price.Name = "label4_Price";
            this.label4_Price.Size = new System.Drawing.Size(64, 22);
            this.label4_Price.TabIndex = 81;
            this.label4_Price.Text = "Price:";
            // 
            // label2_Quantity
            // 
            this.label2_Quantity.AutoSize = true;
            this.label2_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.label2_Quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_Quantity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2_Quantity.Location = new System.Drawing.Point(981, 484);
            this.label2_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2_Quantity.Name = "label2_Quantity";
            this.label2_Quantity.Size = new System.Drawing.Size(93, 22);
            this.label2_Quantity.TabIndex = 83;
            this.label2_Quantity.Text = "Quantity:";
            // 
            // label1_Name
            // 
            this.label1_Name.AutoSize = true;
            this.label1_Name.BackColor = System.Drawing.Color.Transparent;
            this.label1_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Name.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1_Name.Location = new System.Drawing.Point(1005, 434);
            this.label1_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_Name.Name = "label1_Name";
            this.label1_Name.Size = new System.Drawing.Size(69, 22);
            this.label1_Name.TabIndex = 84;
            this.label1_Name.Text = "Name:";
            // 
            // label54_ISBN
            // 
            this.label54_ISBN.AutoSize = true;
            this.label54_ISBN.BackColor = System.Drawing.Color.Transparent;
            this.label54_ISBN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54_ISBN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label54_ISBN.Location = new System.Drawing.Point(1011, 381);
            this.label54_ISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54_ISBN.Name = "label54_ISBN";
            this.label54_ISBN.Size = new System.Drawing.Size(63, 22);
            this.label54_ISBN.TabIndex = 85;
            this.label54_ISBN.Text = "ISBN:";
            // 
            // pictureBox1_BookCover
            // 
            this.pictureBox1_BookCover.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1_BookCover.Image = global::PBL_SMALL_Csharp.Properties.Resources.素敵な装丁の本76___gyu_s_shop_blog1;
            this.pictureBox1_BookCover.Location = new System.Drawing.Point(1039, 98);
            this.pictureBox1_BookCover.Name = "pictureBox1_BookCover";
            this.pictureBox1_BookCover.Size = new System.Drawing.Size(195, 252);
            this.pictureBox1_BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_BookCover.TabIndex = 0;
            this.pictureBox1_BookCover.TabStop = false;
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
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1312, 68);
            this.customPanel1.TabIndex = 63;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PBL_SMALL_Csharp.Properties.Resources.list_48px;
            this.pictureBox2.Location = new System.Drawing.Point(469, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
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
            this.label27.Size = new System.Drawing.Size(213, 42);
            this.label27.TabIndex = 37;
            this.label27.Text = "Books List";
            // 
            // button_WOC1_SearchName
            // 
            this.button_WOC1_SearchName.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1_SearchName.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1_SearchName.ButtonColor = System.Drawing.Color.SteelBlue;
            this.button_WOC1_SearchName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC1_SearchName.FlatAppearance.BorderSize = 0;
            this.button_WOC1_SearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1_SearchName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1_SearchName.ForeColor = System.Drawing.Color.Transparent;
            this.button_WOC1_SearchName.Location = new System.Drawing.Point(613, 94);
            this.button_WOC1_SearchName.Name = "button_WOC1_SearchName";
            this.button_WOC1_SearchName.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1_SearchName.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.button_WOC1_SearchName.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1_SearchName.Size = new System.Drawing.Size(182, 34);
            this.button_WOC1_SearchName.TabIndex = 69;
            this.button_WOC1_SearchName.Text = "Search";
            this.button_WOC1_SearchName.TextColor = System.Drawing.Color.White;
            this.button_WOC1_SearchName.UseVisualStyleBackColor = false;
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
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1315, 55);
            this.customPanel2.TabIndex = 66;
            // 
            // textBox1_Search_Name
            // 
            this.textBox1_Search_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_Search_Name.Location = new System.Drawing.Point(365, 98);
            this.textBox1_Search_Name.Name = "textBox1_Search_Name";
            this.textBox1_Search_Name.Size = new System.Drawing.Size(229, 28);
            this.textBox1_Search_Name.TabIndex = 57;
            // 
            // label54_ID_Member
            // 
            this.label54_ID_Member.AutoSize = true;
            this.label54_ID_Member.BackColor = System.Drawing.Color.Transparent;
            this.label54_ID_Member.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54_ID_Member.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label54_ID_Member.Location = new System.Drawing.Point(219, 100);
            this.label54_ID_Member.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54_ID_Member.Name = "label54_ID_Member";
            this.label54_ID_Member.Size = new System.Drawing.Size(139, 22);
            this.label54_ID_Member.TabIndex = 56;
            this.label54_ID_Member.Text = "Search Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 763);
            this.panel1.TabIndex = 3;
            // 
            // textBox1_ISBN
            // 
            this.textBox1_ISBN.Enabled = false;
            this.textBox1_ISBN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_ISBN.Location = new System.Drawing.Point(1073, 375);
            this.textBox1_ISBN.Name = "textBox1_ISBN";
            this.textBox1_ISBN.Size = new System.Drawing.Size(170, 28);
            this.textBox1_ISBN.TabIndex = 86;
            // 
            // textBox2_Name
            // 
            this.textBox2_Name.Enabled = false;
            this.textBox2_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_Name.Location = new System.Drawing.Point(1073, 432);
            this.textBox2_Name.Name = "textBox2_Name";
            this.textBox2_Name.Size = new System.Drawing.Size(170, 28);
            this.textBox2_Name.TabIndex = 87;
            // 
            // textBox3_Quantity
            // 
            this.textBox3_Quantity.Enabled = false;
            this.textBox3_Quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_Quantity.Location = new System.Drawing.Point(1073, 482);
            this.textBox3_Quantity.Name = "textBox3_Quantity";
            this.textBox3_Quantity.Size = new System.Drawing.Size(170, 28);
            this.textBox3_Quantity.TabIndex = 88;
            // 
            // textBox4_Price
            // 
            this.textBox4_Price.Enabled = false;
            this.textBox4_Price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_Price.Location = new System.Drawing.Point(1073, 530);
            this.textBox4_Price.Name = "textBox4_Price";
            this.textBox4_Price.Size = new System.Drawing.Size(170, 28);
            this.textBox4_Price.TabIndex = 89;
            // 
            // textBox5_DateAdd
            // 
            this.textBox5_DateAdd.Enabled = false;
            this.textBox5_DateAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_DateAdd.Location = new System.Drawing.Point(1073, 582);
            this.textBox5_DateAdd.Name = "textBox5_DateAdd";
            this.textBox5_DateAdd.Size = new System.Drawing.Size(170, 28);
            this.textBox5_DateAdd.TabIndex = 90;
            // 
            // ListBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 763);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListBookForm";
            this.Text = "ListBookForm";
            this.Load += new System.EventHandler(this.ListBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Book)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_BookCover)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_Book;
        private System.Windows.Forms.PictureBox pictureBox1_BookCover;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Custom.CustomPanel customPanel1;
        private System.Windows.Forms.Label label27;
        private ePOSOne.btnProduct.Button_WOC button_WOC1_SearchName;
        private Custom.CustomPanel customPanel2;
        private System.Windows.Forms.TextBox textBox1_Search_Name;
        private System.Windows.Forms.Label label54_ID_Member;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5_DateAdd;
        private System.Windows.Forms.Label label4_Price;
        private System.Windows.Forms.Label label2_Quantity;
        private System.Windows.Forms.Label label1_Name;
        private System.Windows.Forms.Label label54_ISBN;
        private System.Windows.Forms.TextBox textBox5_DateAdd;
        private System.Windows.Forms.TextBox textBox4_Price;
        private System.Windows.Forms.TextBox textBox3_Quantity;
        private System.Windows.Forms.TextBox textBox2_Name;
        private System.Windows.Forms.TextBox textBox1_ISBN;
    }
}