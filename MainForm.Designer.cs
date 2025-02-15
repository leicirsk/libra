using System.Net.Http.Headers;

namespace LIBRA
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout_txt = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_bookbtn = new System.Windows.Forms.Button();
            this.return_bookbtn = new System.Windows.Forms.Button();
            this.issue_bookbtn = new System.Windows.Forms.Button();
            this.view_invbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 36);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Krona One", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "LIBRARY INFORMATION AND BOOK RESOURCES ADMINISTRATION SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit.Location = new System.Drawing.Point(1072, 11);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(17, 17);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "x";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Logout_txt);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.add_bookbtn);
            this.panel2.Controls.Add(this.return_bookbtn);
            this.panel2.Controls.Add(this.issue_bookbtn);
            this.panel2.Controls.Add(this.view_invbtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.home_btn);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 548);
            this.panel2.TabIndex = 2;
            // 
            // Logout_txt
            // 
            this.Logout_txt.AutoSize = true;
            this.Logout_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_txt.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.Logout_txt.Location = new System.Drawing.Point(47, 513);
            this.Logout_txt.Name = "Logout_txt";
            this.Logout_txt.Size = new System.Drawing.Size(84, 17);
            this.Logout_txt.TabIndex = 3;
            this.Logout_txt.Text = "LOG OUT";
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("logout_btn.ErrorImage")));
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.InitialImage = ((System.Drawing.Image)(resources.GetObject("logout_btn.InitialImage")));
            this.logout_btn.Location = new System.Drawing.Point(16, 508);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(25, 26);
            this.logout_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout_btn.TabIndex = 3;
            this.logout_btn.TabStop = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Krona One", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(67, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "INVENTORY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Krona One", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(62, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "CIRCULATION";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // add_bookbtn
            // 
            this.add_bookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(216)))), ((int)(((byte)(231)))));
            this.add_bookbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_bookbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_bookbtn.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_bookbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.add_bookbtn.Location = new System.Drawing.Point(16, 238);
            this.add_bookbtn.Name = "add_bookbtn";
            this.add_bookbtn.Size = new System.Drawing.Size(200, 46);
            this.add_bookbtn.TabIndex = 7;
            this.add_bookbtn.Text = "ADD BOOKS";
            this.add_bookbtn.UseVisualStyleBackColor = false;
            // 
            // return_bookbtn
            // 
            this.return_bookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(216)))), ((int)(((byte)(231)))));
            this.return_bookbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_bookbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_bookbtn.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_bookbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.return_bookbtn.Location = new System.Drawing.Point(16, 418);
            this.return_bookbtn.Name = "return_bookbtn";
            this.return_bookbtn.Size = new System.Drawing.Size(200, 46);
            this.return_bookbtn.TabIndex = 6;
            this.return_bookbtn.Text = "RETURN BOOKS";
            this.return_bookbtn.UseVisualStyleBackColor = false;
            this.return_bookbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // issue_bookbtn
            // 
            this.issue_bookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(216)))), ((int)(((byte)(231)))));
            this.issue_bookbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issue_bookbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue_bookbtn.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_bookbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.issue_bookbtn.Location = new System.Drawing.Point(16, 366);
            this.issue_bookbtn.Name = "issue_bookbtn";
            this.issue_bookbtn.Size = new System.Drawing.Size(200, 46);
            this.issue_bookbtn.TabIndex = 3;
            this.issue_bookbtn.Text = "ISSUE BOOKS";
            this.issue_bookbtn.UseVisualStyleBackColor = false;
            // 
            // view_invbtn
            // 
            this.view_invbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(216)))), ((int)(((byte)(231)))));
            this.view_invbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_invbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_invbtn.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_invbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.view_invbtn.Location = new System.Drawing.Point(16, 314);
            this.view_invbtn.Name = "view_invbtn";
            this.view_invbtn.Size = new System.Drawing.Size(200, 46);
            this.view_invbtn.TabIndex = 5;
            this.view_invbtn.Text = "VIEW INVENTORY";
            this.view_invbtn.UseVisualStyleBackColor = false;
            this.view_invbtn.Click += new System.EventHandler(this.view_invbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::LIBRA.Properties.Resources._8_pCdh1daWljYCHVX_removebg_preview__1_;
            this.pictureBox1.Image = global::LIBRA.Properties.Resources._8_pCdh1daWljYCHVX_removebg_preview__1_;
            this.pictureBox1.InitialImage = global::LIBRA.Properties.Resources._8_pCdh1daWljYCHVX_removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(45, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(216)))), ((int)(((byte)(231)))));
            this.home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.home_btn.Location = new System.Drawing.Point(16, 161);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(200, 49);
            this.home_btn.TabIndex = 4;
            this.home_btn.Text = "HOME";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(251, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 548);
            this.panel3.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Krona One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button issue_bookbtn;
        private System.Windows.Forms.Button view_invbtn;
        private System.Windows.Forms.Button return_bookbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_bookbtn;
        private System.Windows.Forms.PictureBox logout_btn;
        private System.Windows.Forms.Label Logout_txt;
        private System.Windows.Forms.Panel panel3;
    }
}