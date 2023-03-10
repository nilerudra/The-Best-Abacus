namespace AbacusApp.Masters
{
    partial class frmSysShowMsg
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(307, 228);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(126, 45);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name :";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(454, 235);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(380, 39);
            this.txt_name.TabIndex = 1;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(454, 298);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(380, 39);
            this.txt_subject.TabIndex = 3;
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Subject.Location = new System.Drawing.Point(285, 291);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(148, 45);
            this.lbl_Subject.TabIndex = 2;
            this.lbl_Subject.Text = "Subject :";
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(454, 370);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(380, 160);
            this.txt_msg.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(265, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Message :";
            // 
            // frmSysShowMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 935);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "frmSysShowMsg";
            this.Text = "frmSysShowMsg";
            this.Load += new System.EventHandler(this.frmSysShowMsg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_name;
        private TextBox txt_name;
        private TextBox txt_subject;
        private Label lbl_Subject;
        private TextBox txt_msg;
        private Label label1;
    }
}