namespace AbacusApp.Masters
{
    partial class frmSysExams
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_levels = new System.Windows.Forms.Label();
            this.cmbo_levels = new System.Windows.Forms.ComboBox();
            this.dgv_Student = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_levels
            // 
            this.lbl_levels.AutoSize = true;
            this.lbl_levels.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_levels.Location = new System.Drawing.Point(25, 32);
            this.lbl_levels.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_levels.Name = "lbl_levels";
            this.lbl_levels.Size = new System.Drawing.Size(105, 21);
            this.lbl_levels.TabIndex = 4;
            this.lbl_levels.Text = "Select Levels :";
            // 
            // cmbo_levels
            // 
            this.cmbo_levels.FormattingEnabled = true;
            this.cmbo_levels.Items.AddRange(new object[] {
            "ALL"});
            this.cmbo_levels.Location = new System.Drawing.Point(142, 34);
            this.cmbo_levels.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbo_levels.Name = "cmbo_levels";
            this.cmbo_levels.Size = new System.Drawing.Size(203, 23);
            this.cmbo_levels.TabIndex = 3;
            this.cmbo_levels.SelectedIndexChanged += new System.EventHandler(this.cmbo_levels_SelectedIndexChanged);
            // 
            // dgv_Student
            // 
            this.dgv_Student.AllowUserToAddRows = false;
            this.dgv_Student.AllowUserToDeleteRows = false;
            this.dgv_Student.AllowUserToResizeColumns = false;
            this.dgv_Student.AllowUserToResizeRows = false;
            this.dgv_Student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Student.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Student.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Student.Location = new System.Drawing.Point(25, 83);
            this.dgv_Student.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgv_Student.Name = "dgv_Student";
            this.dgv_Student.RowHeadersWidth = 60;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Student.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Student.RowTemplate.Height = 41;
            this.dgv_Student.Size = new System.Drawing.Size(738, 271);
            this.dgv_Student.TabIndex = 7;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 10;
            this.Select.Name = "Select";
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Location = new System.Drawing.Point(569, 34);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(194, 23);
            this.txt_search.TabIndex = 8;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(433, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Student :";
            // 
            // frmSysExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_Student);
            this.Controls.Add(this.lbl_levels);
            this.Controls.Add(this.cmbo_levels);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysExams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Exam";
            this.Load += new System.EventHandler(this.frmSysExams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_levels;
        private ComboBox cmbo_levels;
        private DataGridView dgv_Student;
        private DataGridViewCheckBoxColumn Select;
        private TextBox txt_search;
        private Label label1;
    }
}