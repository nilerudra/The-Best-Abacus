namespace AbacusApp.Masters
{
    partial class frmSysTechSupport
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
            this.dgv_techSupport = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_reportProblem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_techSupport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_techSupport
            // 
            this.dgv_techSupport.AllowUserToAddRows = false;
            this.dgv_techSupport.AllowUserToDeleteRows = false;
            this.dgv_techSupport.AllowUserToResizeColumns = false;
            this.dgv_techSupport.AllowUserToResizeRows = false;
            this.dgv_techSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_techSupport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_techSupport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_techSupport.BackgroundColor = System.Drawing.Color.White;
            this.dgv_techSupport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_techSupport.GridColor = System.Drawing.Color.White;
            this.dgv_techSupport.Location = new System.Drawing.Point(29, 32);
            this.dgv_techSupport.Name = "dgv_techSupport";
            this.dgv_techSupport.ReadOnly = true;
            this.dgv_techSupport.RowHeadersWidth = 82;
            this.dgv_techSupport.RowTemplate.Height = 41;
            this.dgv_techSupport.Size = new System.Drawing.Size(1268, 340);
            this.dgv_techSupport.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_msg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_reportProblem);
            this.panel1.Location = new System.Drawing.Point(29, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 476);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1005, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 72);
            this.button1.TabIndex = 3;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_msg
            // 
            this.txt_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_msg.Location = new System.Drawing.Point(313, 101);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(623, 214);
            this.txt_msg.TabIndex = 2;
            this.txt_msg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(139, 101);
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
            // frmSysTechSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 911);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_techSupport);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysTechSupport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technical Support";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSysTechSupport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_techSupport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_techSupport;
        private Panel panel1;
        private TextBox txt_msg;
        private Label label1;
        private Label lbl_reportProblem;
        private Button button1;
    }
}