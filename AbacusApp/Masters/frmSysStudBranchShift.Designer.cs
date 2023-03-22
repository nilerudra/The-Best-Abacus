namespace AbacusApp.Masters
{
    partial class frmSysStudBranchShift
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbo_branches = new System.Windows.Forms.ComboBox();
            this.lbl_selectBranch = new System.Windows.Forms.Label();
            this.dgv_studInfo = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_shift = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbo_branches
            // 
            this.cmbo_branches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbo_branches.FormattingEnabled = true;
            this.cmbo_branches.Location = new System.Drawing.Point(541, 30);
            this.cmbo_branches.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbo_branches.Name = "cmbo_branches";
            this.cmbo_branches.Size = new System.Drawing.Size(219, 23);
            this.cmbo_branches.TabIndex = 0;
            // 
            // lbl_selectBranch
            // 
            this.lbl_selectBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_selectBranch.AutoSize = true;
            this.lbl_selectBranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_selectBranch.Location = new System.Drawing.Point(439, 28);
            this.lbl_selectBranch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_selectBranch.Name = "lbl_selectBranch";
            this.lbl_selectBranch.Size = new System.Drawing.Size(87, 21);
            this.lbl_selectBranch.TabIndex = 1;
            this.lbl_selectBranch.Text = "Branches :";
            // 
            // dgv_studInfo
            // 
            this.dgv_studInfo.AllowUserToAddRows = false;
            this.dgv_studInfo.AllowUserToDeleteRows = false;
            this.dgv_studInfo.AllowUserToOrderColumns = true;
            this.dgv_studInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_studInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_studInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_studInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv_studInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_studInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_studInfo.GridColor = System.Drawing.Color.White;
            this.dgv_studInfo.Location = new System.Drawing.Point(25, 73);
            this.dgv_studInfo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgv_studInfo.Name = "dgv_studInfo";
            this.dgv_studInfo.RowHeadersWidth = 60;
            this.dgv_studInfo.RowTemplate.Height = 41;
            this.dgv_studInfo.Size = new System.Drawing.Size(735, 342);
            this.dgv_studInfo.TabIndex = 2;
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.MinimumWidth = 10;
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_shift
            // 
            this.btn_shift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shift.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_shift.Location = new System.Drawing.Point(638, 424);
            this.btn_shift.Margin = new System.Windows.Forms.Padding(0);
            this.btn_shift.Name = "btn_shift";
            this.btn_shift.Size = new System.Drawing.Size(122, 28);
            this.btn_shift.TabIndex = 3;
            this.btn_shift.Text = "Shift";
            this.btn_shift.UseVisualStyleBackColor = true;
            this.btn_shift.Click += new System.EventHandler(this.btn_shift_Click);
            // 
            // frmSysStudBranchShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_shift);
            this.Controls.Add(this.dgv_studInfo);
            this.Controls.Add(this.lbl_selectBranch);
            this.Controls.Add(this.cmbo_branches);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysStudBranchShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift Branch";
            this.Load += new System.EventHandler(this.frmSysStudBranchShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbo_branches;
        private Label lbl_selectBranch;
        private DataGridView dgv_studInfo;
        private DataGridViewCheckBoxColumn select;
        private Button btn_shift;
    }
}