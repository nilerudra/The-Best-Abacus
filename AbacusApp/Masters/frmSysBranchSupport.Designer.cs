namespace AbacusApp.Masters
{
    partial class frmSysBranchSupport
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
            this.dgv_branchSupport = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_report = new System.Windows.Forms.Button();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_reportProblem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_branchSupport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_branchSupport
            // 
            this.dgv_branchSupport.AllowUserToAddRows = false;
            this.dgv_branchSupport.AllowUserToDeleteRows = false;
            this.dgv_branchSupport.AllowUserToResizeColumns = false;
            this.dgv_branchSupport.AllowUserToResizeRows = false;
            this.dgv_branchSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_branchSupport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_branchSupport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_branchSupport.BackgroundColor = System.Drawing.Color.White;
            this.dgv_branchSupport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_branchSupport.GridColor = System.Drawing.Color.White;
            this.dgv_branchSupport.Location = new System.Drawing.Point(43, 39);
            this.dgv_branchSupport.Name = "dgv_branchSupport";
            this.dgv_branchSupport.ReadOnly = true;
            this.dgv_branchSupport.RowHeadersWidth = 82;
            this.dgv_branchSupport.RowTemplate.Height = 41;
            this.dgv_branchSupport.Size = new System.Drawing.Size(1293, 389);
            this.dgv_branchSupport.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_report);
            this.panel1.Controls.Add(this.txt_msg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_reportProblem);
            this.panel1.Location = new System.Drawing.Point(43, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 423);
            this.panel1.TabIndex = 2;
            // 
            // btn_report
            // 
            this.btn_report.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_report.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_report.Location = new System.Drawing.Point(1008, 326);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(237, 72);
            this.btn_report.TabIndex = 3;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // txt_msg
            // 
            this.txt_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_msg.Location = new System.Drawing.Point(334, 86);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(623, 194);
            this.txt_msg.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message :";
            // 
            // lbl_reportProblem
            // 
            this.lbl_reportProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_reportProblem.AutoSize = true;
            this.lbl_reportProblem.BackColor = System.Drawing.Color.Black;
            this.lbl_reportProblem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_reportProblem.ForeColor = System.Drawing.Color.White;
            this.lbl_reportProblem.Location = new System.Drawing.Point(0, 0);
            this.lbl_reportProblem.Name = "lbl_reportProblem";
            this.lbl_reportProblem.Size = new System.Drawing.Size(260, 45);
            this.lbl_reportProblem.TabIndex = 0;
            this.lbl_reportProblem.Text = "Report Problem";
            // 
            // frmSysBranchSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 930);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_branchSupport);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysBranchSupport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSysBranchSupport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSysBranchSupport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_branchSupport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_branchSupport;
        private Panel panel1;
        private Button btn_report;
        private TextBox txt_msg;
        private Label label1;
        private Label lbl_reportProblem;
    }
}