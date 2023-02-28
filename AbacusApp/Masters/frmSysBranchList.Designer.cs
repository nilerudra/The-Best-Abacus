
namespace AbacusApp.SysBase
{
    partial class frmSysBranchList
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
            this.tbLayPnl_Branches = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl_searchBy = new System.Windows.Forms.Panel();
            this.btn_apply = new System.Windows.Forms.Button();
            this.rbtn_addr = new System.Windows.Forms.RadioButton();
            this.rbtn_city = new System.Windows.Forms.RadioButton();
            this.rbtn_name = new System.Windows.Forms.RadioButton();
            this.lbl_searchBy = new System.Windows.Forms.Label();
            this.btn_searchBy = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_newBranch = new System.Windows.Forms.Button();
            this.dgv_BranchList = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbLayPnl_Branches.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnl_searchBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BranchList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLayPnl_Branches
            // 
            this.tbLayPnl_Branches.ColumnCount = 1;
            this.tbLayPnl_Branches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayPnl_Branches.Controls.Add(this.panel1, 0, 0);
            this.tbLayPnl_Branches.Controls.Add(this.panel2, 0, 1);
            this.tbLayPnl_Branches.Controls.Add(this.panel3, 0, 2);
            this.tbLayPnl_Branches.Controls.Add(this.panel7, 0, 3);
            this.tbLayPnl_Branches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayPnl_Branches.Location = new System.Drawing.Point(0, 0);
            this.tbLayPnl_Branches.Margin = new System.Windows.Forms.Padding(0);
            this.tbLayPnl_Branches.Name = "tbLayPnl_Branches";
            this.tbLayPnl_Branches.RowCount = 4;
            this.tbLayPnl_Branches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tbLayPnl_Branches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tbLayPnl_Branches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayPnl_Branches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tbLayPnl_Branches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLayPnl_Branches.Size = new System.Drawing.Size(784, 461);
            this.tbLayPnl_Branches.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 47);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 35);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 356);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pnl_searchBy);
            this.panel5.Controls.Add(this.btn_searchBy);
            this.panel5.Controls.Add(this.txt_search);
            this.panel5.Controls.Add(this.btn_newBranch);
            this.panel5.Controls.Add(this.dgv_BranchList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(784, 356);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pnl_searchBy
            // 
            this.pnl_searchBy.BackColor = System.Drawing.Color.Black;
            this.pnl_searchBy.Controls.Add(this.btn_apply);
            this.pnl_searchBy.Controls.Add(this.rbtn_addr);
            this.pnl_searchBy.Controls.Add(this.rbtn_city);
            this.pnl_searchBy.Controls.Add(this.rbtn_name);
            this.pnl_searchBy.Controls.Add(this.lbl_searchBy);
            this.pnl_searchBy.Location = new System.Drawing.Point(470, 58);
            this.pnl_searchBy.Margin = new System.Windows.Forms.Padding(1);
            this.pnl_searchBy.Name = "pnl_searchBy";
            this.pnl_searchBy.Size = new System.Drawing.Size(156, 154);
            this.pnl_searchBy.TabIndex = 10;
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_apply.FlatAppearance.BorderSize = 0;
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_apply.ForeColor = System.Drawing.Color.White;
            this.btn_apply.Location = new System.Drawing.Point(60, 123);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(1);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(80, 22);
            this.btn_apply.TabIndex = 4;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // rbtn_addr
            // 
            this.rbtn_addr.AutoSize = true;
            this.rbtn_addr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_addr.ForeColor = System.Drawing.Color.White;
            this.rbtn_addr.Location = new System.Drawing.Point(20, 85);
            this.rbtn_addr.Margin = new System.Windows.Forms.Padding(1);
            this.rbtn_addr.Name = "rbtn_addr";
            this.rbtn_addr.Size = new System.Drawing.Size(76, 23);
            this.rbtn_addr.TabIndex = 3;
            this.rbtn_addr.TabStop = true;
            this.rbtn_addr.Text = "Address";
            this.rbtn_addr.UseVisualStyleBackColor = true;
            // 
            // rbtn_city
            // 
            this.rbtn_city.AutoSize = true;
            this.rbtn_city.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_city.ForeColor = System.Drawing.Color.White;
            this.rbtn_city.Location = new System.Drawing.Point(20, 58);
            this.rbtn_city.Margin = new System.Windows.Forms.Padding(1);
            this.rbtn_city.Name = "rbtn_city";
            this.rbtn_city.Size = new System.Drawing.Size(51, 23);
            this.rbtn_city.TabIndex = 2;
            this.rbtn_city.TabStop = true;
            this.rbtn_city.Text = "City";
            this.rbtn_city.UseVisualStyleBackColor = true;
            // 
            // rbtn_name
            // 
            this.rbtn_name.AutoSize = true;
            this.rbtn_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_name.ForeColor = System.Drawing.Color.White;
            this.rbtn_name.Location = new System.Drawing.Point(20, 31);
            this.rbtn_name.Margin = new System.Windows.Forms.Padding(1);
            this.rbtn_name.Name = "rbtn_name";
            this.rbtn_name.Size = new System.Drawing.Size(63, 23);
            this.rbtn_name.TabIndex = 1;
            this.rbtn_name.TabStop = true;
            this.rbtn_name.Text = "Name";
            this.rbtn_name.UseVisualStyleBackColor = true;
            // 
            // lbl_searchBy
            // 
            this.lbl_searchBy.AutoSize = true;
            this.lbl_searchBy.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbl_searchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_searchBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_searchBy.ForeColor = System.Drawing.Color.White;
            this.lbl_searchBy.Location = new System.Drawing.Point(1, 1);
            this.lbl_searchBy.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_searchBy.Name = "lbl_searchBy";
            this.lbl_searchBy.Padding = new System.Windows.Forms.Padding(5, 4, 0, 4);
            this.lbl_searchBy.Size = new System.Drawing.Size(149, 29);
            this.lbl_searchBy.TabIndex = 0;
            this.lbl_searchBy.Text = "Search By               ";
            // 
            // btn_searchBy
            // 
            this.btn_searchBy.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_searchBy.FlatAppearance.BorderSize = 0;
            this.btn_searchBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_searchBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_searchBy.Location = new System.Drawing.Point(439, 29);
            this.btn_searchBy.Margin = new System.Windows.Forms.Padding(1);
            this.btn_searchBy.Name = "btn_searchBy";
            this.btn_searchBy.Size = new System.Drawing.Size(102, 28);
            this.btn_searchBy.TabIndex = 9;
            this.btn_searchBy.Text = "Search By";
            this.btn_searchBy.UseVisualStyleBackColor = false;
            this.btn_searchBy.Click += new System.EventHandler(this.btn_searchBy_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(74, 34);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(328, 23);
            this.txt_search.TabIndex = 8;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_newBranch
            // 
            this.btn_newBranch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_newBranch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_newBranch.FlatAppearance.BorderSize = 0;
            this.btn_newBranch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_newBranch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_newBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newBranch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_newBranch.ForeColor = System.Drawing.Color.Black;
            this.btn_newBranch.Location = new System.Drawing.Point(497, 306);
            this.btn_newBranch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_newBranch.Name = "btn_newBranch";
            this.btn_newBranch.Size = new System.Drawing.Size(214, 35);
            this.btn_newBranch.TabIndex = 7;
            this.btn_newBranch.Text = "New Branch";
            this.btn_newBranch.UseVisualStyleBackColor = false;
            this.btn_newBranch.Click += new System.EventHandler(this.btn_newBranch_Click_1);
            // 
            // dgv_BranchList
            // 
            this.dgv_BranchList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BranchList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_BranchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BranchList.Location = new System.Drawing.Point(74, 40);
            this.dgv_BranchList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgv_BranchList.Name = "dgv_BranchList";
            this.dgv_BranchList.RowHeadersWidth = 82;
            this.dgv_BranchList.RowTemplate.Height = 41;
            this.dgv_BranchList.Size = new System.Drawing.Size(637, 230);
            this.dgv_BranchList.TabIndex = 6;
            this.dgv_BranchList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BranchList_CellContentClick);
            this.dgv_BranchList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_BranchList_RowHeaderMouseDoubleClick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PeachPuff;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 438);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(784, 23);
            this.panel7.TabIndex = 5;
            // 
            // frmSysBranchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tbLayPnl_Branches);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysBranchList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSysBranchList_Load);
            this.tbLayPnl_Branches.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnl_searchBy.ResumeLayout(false);
            this.pnl_searchBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BranchList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tbLayPnl_Branches;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private DataGridView dgv_BranchList;
        private Button btn_newBranch;
        private Panel panel7;
        private TextBox txt_search;
        private Panel pnl_searchBy;
        private RadioButton rbtn_addr;
        private RadioButton rbtn_city;
        private RadioButton rbtn_name;
        private Label lbl_searchBy;
        private Button btn_searchBy;
        private Button btn_apply;
    }
}