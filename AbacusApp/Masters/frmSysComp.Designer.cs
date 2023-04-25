namespace AbacusApp.Masters
{
    partial class frmSysComp
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
            this.dgv_Student = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_levels = new System.Windows.Forms.Label();
            this.cmbo_levels = new System.Windows.Forms.ComboBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.cmb_paper_Ls = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dtp_end_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Student
            // 
            this.dgv_Student.AllowUserToAddRows = false;
            this.dgv_Student.AllowUserToDeleteRows = false;
            this.dgv_Student.AllowUserToResizeColumns = false;
            this.dgv_Student.AllowUserToResizeRows = false;
            this.dgv_Student.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dgv_Student.Location = new System.Drawing.Point(32, 83);
            this.dgv_Student.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgv_Student.Name = "dgv_Student";
            this.dgv_Student.RowHeadersWidth = 60;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Student.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Student.RowTemplate.Height = 41;
            this.dgv_Student.Size = new System.Drawing.Size(738, 225);
            this.dgv_Student.TabIndex = 16;
            this.dgv_Student.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Student_CellValueChanged);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 10;
            this.Select.Name = "Select";
            // 
            // lbl_levels
            // 
            this.lbl_levels.AutoSize = true;
            this.lbl_levels.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_levels.Location = new System.Drawing.Point(32, 33);
            this.lbl_levels.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_levels.Name = "lbl_levels";
            this.lbl_levels.Size = new System.Drawing.Size(105, 21);
            this.lbl_levels.TabIndex = 14;
            this.lbl_levels.Text = "Select Levels :";
            // 
            // cmbo_levels
            // 
            this.cmbo_levels.FormattingEnabled = true;
            this.cmbo_levels.Items.AddRange(new object[] {
            "ALL"});
            this.cmbo_levels.Location = new System.Drawing.Point(149, 35);
            this.cmbo_levels.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbo_levels.Name = "cmbo_levels";
            this.cmbo_levels.Size = new System.Drawing.Size(203, 23);
            this.cmbo_levels.TabIndex = 13;
            this.cmbo_levels.SelectedIndexChanged += new System.EventHandler(this.cmbo_levels_SelectedIndexChanged);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_create.Location = new System.Drawing.Point(350, 412);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(106, 32);
            this.btn_create.TabIndex = 20;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // cmb_paper_Ls
            // 
            this.cmb_paper_Ls.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmb_paper_Ls.FormattingEnabled = true;
            this.cmb_paper_Ls.Location = new System.Drawing.Point(380, 326);
            this.cmb_paper_Ls.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmb_paper_Ls.Name = "cmb_paper_Ls";
            this.cmb_paper_Ls.Size = new System.Drawing.Size(203, 23);
            this.cmb_paper_Ls.TabIndex = 19;
            this.cmb_paper_Ls.SelectedIndexChanged += new System.EventHandler(this.cmb_paper_Ls_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(240, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select Compitition :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(440, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search Student :";
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Location = new System.Drawing.Point(576, 35);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(194, 23);
            this.txt_search.TabIndex = 17;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // dtp_end_date
            // 
            this.dtp_end_date.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtp_end_date.Location = new System.Drawing.Point(380, 363);
            this.dtp_end_date.Name = "dtp_end_date";
            this.dtp_end_date.Size = new System.Drawing.Size(203, 23);
            this.dtp_end_date.TabIndex = 22;
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(291, 363);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(68, 17);
            this.lbl_date.TabIndex = 21;
            this.lbl_date.Text = "End Date :";
            // 
            // frmSysComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_end_date);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.dgv_Student);
            this.Controls.Add(this.lbl_levels);
            this.Controls.Add(this.cmbo_levels);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.cmb_paper_Ls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSysComp";
            this.Load += new System.EventHandler(this.frmSysComp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_Student;
        private DataGridViewCheckBoxColumn Select;
        private Label lbl_levels;
        private ComboBox cmbo_levels;
        private Button btn_create;
        private ComboBox cmb_paper_Ls;
        private Label label2;
        private Label label1;
        private TextBox txt_search;
        private DateTimePicker dtp_end_date;
        private Label lbl_date;
    }
}