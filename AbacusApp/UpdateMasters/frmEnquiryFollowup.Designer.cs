namespace AbacusApp.UpdateMasters
{
    partial class frmEnquiryFollowup
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
            this.dgv_enqList = new System.Windows.Forms.DataGridView();
            this.pnl_update = new System.Windows.Forms.Panel();
            this.btn_procced = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dtp_nextFollowupDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_nextFollowup = new System.Windows.Forms.Label();
            this.chbox_notIntretsed = new System.Windows.Forms.CheckBox();
            this.txt_contactNo = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.lbl_contactNo = new System.Windows.Forms.Label();
            this.lbl_update = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.txt_rmk = new System.Windows.Forms.TextBox();
            this.lbn_rmk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_enqList)).BeginInit();
            this.pnl_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_enqList
            // 
            this.dgv_enqList.AllowUserToAddRows = false;
            this.dgv_enqList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_enqList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_enqList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_enqList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_enqList.GridColor = System.Drawing.Color.White;
            this.dgv_enqList.Location = new System.Drawing.Point(50, 11);
            this.dgv_enqList.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_enqList.Name = "dgv_enqList";
            this.dgv_enqList.RowHeadersWidth = 82;
            this.dgv_enqList.RowTemplate.Height = 41;
            this.dgv_enqList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_enqList.Size = new System.Drawing.Size(687, 190);
            this.dgv_enqList.TabIndex = 0;
            this.dgv_enqList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_enqList_CellContentClick);
            this.dgv_enqList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_enqList_RowHeaderMouseDoubleClick);
            // 
            // pnl_update
            // 
            this.pnl_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_update.Controls.Add(this.txt_rmk);
            this.pnl_update.Controls.Add(this.lbn_rmk);
            this.pnl_update.Controls.Add(this.btn_procced);
            this.pnl_update.Controls.Add(this.btn_update);
            this.pnl_update.Controls.Add(this.dtp_nextFollowupDate);
            this.pnl_update.Controls.Add(this.lbl_nextFollowup);
            this.pnl_update.Controls.Add(this.chbox_notIntretsed);
            this.pnl_update.Controls.Add(this.txt_contactNo);
            this.pnl_update.Controls.Add(this.txt_lastName);
            this.pnl_update.Controls.Add(this.txt_firstName);
            this.pnl_update.Controls.Add(this.lbl_contactNo);
            this.pnl_update.Controls.Add(this.lbl_update);
            this.pnl_update.Controls.Add(this.lbl_lastName);
            this.pnl_update.Controls.Add(this.lbl_firstName);
            this.pnl_update.Location = new System.Drawing.Point(50, 222);
            this.pnl_update.Margin = new System.Windows.Forms.Padding(1);
            this.pnl_update.Name = "pnl_update";
            this.pnl_update.Size = new System.Drawing.Size(687, 229);
            this.pnl_update.TabIndex = 1;
            // 
            // btn_procced
            // 
            this.btn_procced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_procced.Location = new System.Drawing.Point(502, 173);
            this.btn_procced.Margin = new System.Windows.Forms.Padding(1);
            this.btn_procced.Name = "btn_procced";
            this.btn_procced.Size = new System.Drawing.Size(139, 29);
            this.btn_procced.TabIndex = 11;
            this.btn_procced.Text = "Procced to Admission";
            this.btn_procced.UseVisualStyleBackColor = true;
            this.btn_procced.Click += new System.EventHandler(this.btn_procced_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.Location = new System.Drawing.Point(361, 173);
            this.btn_update.Margin = new System.Windows.Forms.Padding(1);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 29);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dtp_nextFollowupDate
            // 
            this.dtp_nextFollowupDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_nextFollowupDate.Checked = false;
            this.dtp_nextFollowupDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_nextFollowupDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_nextFollowupDate.Location = new System.Drawing.Point(465, 97);
            this.dtp_nextFollowupDate.Margin = new System.Windows.Forms.Padding(1);
            this.dtp_nextFollowupDate.Name = "dtp_nextFollowupDate";
            this.dtp_nextFollowupDate.Size = new System.Drawing.Size(176, 23);
            this.dtp_nextFollowupDate.TabIndex = 9;
            // 
            // lbl_nextFollowup
            // 
            this.lbl_nextFollowup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nextFollowup.AutoSize = true;
            this.lbl_nextFollowup.Location = new System.Drawing.Point(346, 100);
            this.lbl_nextFollowup.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_nextFollowup.Name = "lbl_nextFollowup";
            this.lbl_nextFollowup.Size = new System.Drawing.Size(117, 15);
            this.lbl_nextFollowup.TabIndex = 8;
            this.lbl_nextFollowup.Text = "Next Followup Date :";
            // 
            // chbox_notIntretsed
            // 
            this.chbox_notIntretsed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbox_notIntretsed.AutoSize = true;
            this.chbox_notIntretsed.Location = new System.Drawing.Point(346, 66);
            this.chbox_notIntretsed.Margin = new System.Windows.Forms.Padding(1);
            this.chbox_notIntretsed.Name = "chbox_notIntretsed";
            this.chbox_notIntretsed.Size = new System.Drawing.Size(101, 19);
            this.chbox_notIntretsed.TabIndex = 7;
            this.chbox_notIntretsed.Text = "Not Interested";
            this.chbox_notIntretsed.UseVisualStyleBackColor = true;
            this.chbox_notIntretsed.CheckStateChanged += new System.EventHandler(this.chbox_notIntretsed_CheckStateChanged);
            // 
            // txt_contactNo
            // 
            this.txt_contactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contactNo.Location = new System.Drawing.Point(122, 130);
            this.txt_contactNo.Margin = new System.Windows.Forms.Padding(1);
            this.txt_contactNo.Name = "txt_contactNo";
            this.txt_contactNo.Size = new System.Drawing.Size(176, 23);
            this.txt_contactNo.TabIndex = 6;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_lastName.Location = new System.Drawing.Point(122, 97);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(1);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(176, 23);
            this.txt_lastName.TabIndex = 5;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_firstName.Location = new System.Drawing.Point(122, 62);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(1);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(176, 23);
            this.txt_firstName.TabIndex = 4;
            // 
            // lbl_contactNo
            // 
            this.lbl_contactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_contactNo.AutoSize = true;
            this.lbl_contactNo.Location = new System.Drawing.Point(36, 133);
            this.lbl_contactNo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_contactNo.Name = "lbl_contactNo";
            this.lbl_contactNo.Size = new System.Drawing.Size(74, 15);
            this.lbl_contactNo.TabIndex = 3;
            this.lbl_contactNo.Text = "Contact No :";
            // 
            // lbl_update
            // 
            this.lbl_update.AutoSize = true;
            this.lbl_update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_update.ForeColor = System.Drawing.Color.White;
            this.lbl_update.Location = new System.Drawing.Point(-1, 0);
            this.lbl_update.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_update.Name = "lbl_update";
            this.lbl_update.Size = new System.Drawing.Size(133, 21);
            this.lbl_update.TabIndex = 2;
            this.lbl_update.Text = "Update Data Here";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(41, 98);
            this.lbl_lastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(69, 15);
            this.lbl_lastName.TabIndex = 1;
            this.lbl_lastName.Text = "Last Name :";
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(40, 65);
            this.lbl_firstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(70, 15);
            this.lbl_firstName.TabIndex = 0;
            this.lbl_firstName.Text = "First Name :";
            // 
            // txt_rmk
            // 
            this.txt_rmk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_rmk.Location = new System.Drawing.Point(122, 164);
            this.txt_rmk.Margin = new System.Windows.Forms.Padding(1);
            this.txt_rmk.Name = "txt_rmk";
            this.txt_rmk.Size = new System.Drawing.Size(176, 23);
            this.txt_rmk.TabIndex = 13;
            // 
            // lbn_rmk
            // 
            this.lbn_rmk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbn_rmk.AutoSize = true;
            this.lbn_rmk.Location = new System.Drawing.Point(57, 167);
            this.lbn_rmk.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbn_rmk.Name = "lbn_rmk";
            this.lbn_rmk.Size = new System.Drawing.Size(53, 15);
            this.lbn_rmk.TabIndex = 12;
            this.lbn_rmk.Text = "Remark :";
            // 
            // frmEnquiryFollowup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnl_update);
            this.Controls.Add(this.dgv_enqList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnquiryFollowup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enquiry Followup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEnquiryFollowup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_enqList)).EndInit();
            this.pnl_update.ResumeLayout(false);
            this.pnl_update.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_enqList;
        private Panel pnl_update;
        private TextBox txt_contactNo;
        private TextBox txt_lastName;
        private TextBox txt_firstName;
        private Label lbl_contactNo;
        private Label lbl_update;
        private Label lbl_lastName;
        private Label lbl_firstName;
        private DateTimePicker dtp_nextFollowupDate;
        private Label lbl_nextFollowup;
        private CheckBox chbox_notIntretsed;
        private Button btn_update;
        private Button btn_procced;
        private TextBox txt_rmk;
        private Label lbn_rmk;
    }
}