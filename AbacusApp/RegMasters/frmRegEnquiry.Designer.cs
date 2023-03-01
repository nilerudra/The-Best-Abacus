﻿namespace AbacusApp.RegMasters
{
    partial class frmRegEnquiry
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_contactNo = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_addr = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.rbtn_other = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(249, 140);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 15);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name :";
            // 
            // lbl_contact
            // 
            this.lbl_contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Location = new System.Drawing.Point(218, 168);
            this.lbl_contact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(74, 15);
            this.lbl_contact.TabIndex = 1;
            this.lbl_contact.Text = "Contact No :";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(239, 199);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(53, 15);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E - Mail :";
            // 
            // lbl_address
            // 
            this.lbl_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(238, 226);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(55, 15);
            this.lbl_address.TabIndex = 3;
            this.lbl_address.Text = "Address :";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.Location = new System.Drawing.Point(310, 138);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(250, 23);
            this.txt_name.TabIndex = 4;
            // 
            // txt_contactNo
            // 
            this.txt_contactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contactNo.Location = new System.Drawing.Point(310, 166);
            this.txt_contactNo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_contactNo.Name = "txt_contactNo";
            this.txt_contactNo.Size = new System.Drawing.Size(250, 23);
            this.txt_contactNo.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.Location = new System.Drawing.Point(310, 197);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(250, 23);
            this.txt_email.TabIndex = 6;
            // 
            // txt_addr
            // 
            this.txt_addr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_addr.Location = new System.Drawing.Point(310, 225);
            this.txt_addr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_addr.Name = "txt_addr";
            this.txt_addr.Size = new System.Drawing.Size(250, 23);
            this.txt_addr.TabIndex = 7;
            // 
            // btn_register
            // 
            this.btn_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_register.Location = new System.Drawing.Point(324, 305);
            this.btn_register.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(130, 30);
            this.btn_register.TabIndex = 8;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_gender
            // 
            this.lbl_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(241, 257);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(51, 15);
            this.lbl_gender.TabIndex = 9;
            this.lbl_gender.Text = "Gender :";
            this.lbl_gender.Click += new System.EventHandler(this.lbl_gender_Click);
            // 
            // rbtn_male
            // 
            this.rbtn_male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(310, 256);
            this.rbtn_male.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(51, 19);
            this.rbtn_male.TabIndex = 10;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // rbtn_female
            // 
            this.rbtn_female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(395, 256);
            this.rbtn_female.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(63, 19);
            this.rbtn_female.TabIndex = 11;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            // 
            // rbtn_other
            // 
            this.rbtn_other.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_other.AutoSize = true;
            this.rbtn_other.Location = new System.Drawing.Point(500, 256);
            this.rbtn_other.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbtn_other.Name = "rbtn_other";
            this.rbtn_other.Size = new System.Drawing.Size(55, 19);
            this.rbtn_other.TabIndex = 12;
            this.rbtn_other.TabStop = true;
            this.rbtn_other.Text = "Other";
            this.rbtn_other.UseVisualStyleBackColor = true;
            // 
            // frmRegEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.rbtn_other);
            this.Controls.Add(this.rbtn_female);
            this.Controls.Add(this.rbtn_male);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_addr);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_contactNo);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.lbl_name);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegEnquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Enquiry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegEnquiry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_name;
        private Label lbl_contact;
        private Label lbl_email;
        private Label lbl_address;
        private TextBox txt_name;
        private TextBox txt_contactNo;
        private TextBox txt_email;
        private TextBox txt_addr;
        private Button btn_register;
        private Label lbl_gender;
        private RadioButton rbtn_male;
        private RadioButton rbtn_female;
        private RadioButton rbtn_other;
    }
}