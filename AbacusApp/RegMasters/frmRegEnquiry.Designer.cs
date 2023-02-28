namespace AbacusApp.RegMasters
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
            this.lbl_name.Location = new System.Drawing.Point(529, 268);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(90, 32);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name :";
            // 
            // lbl_contact
            // 
            this.lbl_contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Location = new System.Drawing.Point(472, 328);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(147, 32);
            this.lbl_contact.TabIndex = 1;
            this.lbl_contact.Text = "Contact No :";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(511, 394);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(108, 32);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E - Mail :";
            // 
            // lbl_address
            // 
            this.lbl_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(509, 453);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(110, 32);
            this.lbl_address.TabIndex = 3;
            this.lbl_address.Text = "Address :";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.Location = new System.Drawing.Point(642, 265);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(460, 39);
            this.txt_name.TabIndex = 4;
            // 
            // txt_contactNo
            // 
            this.txt_contactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contactNo.Location = new System.Drawing.Point(642, 325);
            this.txt_contactNo.Name = "txt_contactNo";
            this.txt_contactNo.Size = new System.Drawing.Size(460, 39);
            this.txt_contactNo.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.Location = new System.Drawing.Point(642, 391);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(460, 39);
            this.txt_email.TabIndex = 6;
            // 
            // txt_addr
            // 
            this.txt_addr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_addr.Location = new System.Drawing.Point(642, 450);
            this.txt_addr.Name = "txt_addr";
            this.txt_addr.Size = new System.Drawing.Size(460, 39);
            this.txt_addr.TabIndex = 7;
            // 
            // btn_register
            // 
            this.btn_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_register.Location = new System.Drawing.Point(668, 621);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(241, 65);
            this.btn_register.TabIndex = 8;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_gender
            // 
            this.lbl_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(515, 518);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(104, 32);
            this.lbl_gender.TabIndex = 9;
            this.lbl_gender.Text = "Gender :";
            this.lbl_gender.Click += new System.EventHandler(this.lbl_gender_Click);
            // 
            // rbtn_male
            // 
            this.rbtn_male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(642, 516);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(98, 36);
            this.rbtn_male.TabIndex = 10;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // rbtn_female
            // 
            this.rbtn_female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(800, 516);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(122, 36);
            this.rbtn_female.TabIndex = 11;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            // 
            // rbtn_other
            // 
            this.rbtn_other.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_other.AutoSize = true;
            this.rbtn_other.Location = new System.Drawing.Point(996, 516);
            this.rbtn_other.Name = "rbtn_other";
            this.rbtn_other.Size = new System.Drawing.Size(106, 36);
            this.rbtn_other.TabIndex = 12;
            this.rbtn_other.TabStop = true;
            this.rbtn_other.Text = "Other";
            this.rbtn_other.UseVisualStyleBackColor = true;
            // 
            // frmRegEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 1009);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegEnquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Enquiry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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