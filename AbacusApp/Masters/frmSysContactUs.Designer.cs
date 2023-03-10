namespace AbacusApp.Masters
{
    partial class frmSysContactUs
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
            this.dgv_contactUs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contactUs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_contactUs
            // 
            this.dgv_contactUs.AllowUserToResizeColumns = false;
            this.dgv_contactUs.AllowUserToResizeRows = false;
            this.dgv_contactUs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_contactUs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_contactUs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_contactUs.BackgroundColor = System.Drawing.Color.White;
            this.dgv_contactUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contactUs.GridColor = System.Drawing.Color.White;
            this.dgv_contactUs.Location = new System.Drawing.Point(26, 83);
            this.dgv_contactUs.Name = "dgv_contactUs";
            this.dgv_contactUs.RowHeadersWidth = 82;
            this.dgv_contactUs.RowTemplate.Height = 41;
            this.dgv_contactUs.Size = new System.Drawing.Size(1231, 404);
            this.dgv_contactUs.TabIndex = 0;
            this.dgv_contactUs.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_contactUs_RowHeaderMouseDoubleClick);
            // 
            // frmSysContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 797);
            this.Controls.Add(this.dgv_contactUs);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysContactUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSysContactUs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSysContactUs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contactUs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_contactUs;
    }
}