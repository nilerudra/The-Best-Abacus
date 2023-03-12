
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSysBranchList));
            this.tbLayPnl_Branches = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_BranchList = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_newBranch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbLayPnl_Branches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BranchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLayPnl_Branches
            // 
            this.tbLayPnl_Branches.ColumnCount = 1;
            this.tbLayPnl_Branches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLayPnl_Branches.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tbLayPnl_Branches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayPnl_Branches.Location = new System.Drawing.Point(0, 0);
            this.tbLayPnl_Branches.Margin = new System.Windows.Forms.Padding(0);
            this.tbLayPnl_Branches.Name = "tbLayPnl_Branches";
            this.tbLayPnl_Branches.RowCount = 1;
            this.tbLayPnl_Branches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLayPnl_Branches.Size = new System.Drawing.Size(200, 100);
            this.tbLayPnl_Branches.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgv_BranchList
            // 
            this.dgv_BranchList.AllowUserToAddRows = false;
            this.dgv_BranchList.AllowUserToResizeColumns = false;
            this.dgv_BranchList.AllowUserToResizeRows = false;
            this.dgv_BranchList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BranchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BranchList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_BranchList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BranchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BranchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BranchList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_BranchList.EnableHeadersVisualStyles = false;
            this.dgv_BranchList.GridColor = System.Drawing.Color.Black;
            this.dgv_BranchList.Location = new System.Drawing.Point(22, 196);
            this.dgv_BranchList.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_BranchList.Name = "dgv_BranchList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BranchList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_BranchList.RowHeadersWidth = 50;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgv_BranchList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_BranchList.RowTemplate.Height = 25;
            this.dgv_BranchList.Size = new System.Drawing.Size(1411, 523);
            this.dgv_BranchList.TabIndex = 0;
            this.dgv_BranchList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_BranchList_RowHeaderMouseDoubleClick_1);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(804, 85);
            this.txt_search.Margin = new System.Windows.Forms.Padding(6);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(487, 43);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_newBranch
            // 
            this.btn_newBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newBranch.FlatAppearance.BorderSize = 2;
            this.btn_newBranch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_newBranch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_newBranch.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_newBranch.Location = new System.Drawing.Point(1175, 783);
            this.btn_newBranch.Margin = new System.Windows.Forms.Padding(6);
            this.btn_newBranch.Name = "btn_newBranch";
            this.btn_newBranch.Size = new System.Drawing.Size(258, 62);
            this.btn_newBranch.TabIndex = 2;
            this.btn_newBranch.Text = "New Branch";
            this.btn_newBranch.UseVisualStyleBackColor = true;
            this.btn_newBranch.Click += new System.EventHandler(this.btn_newBranch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1291, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmSysBranchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 912);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_newBranch);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_BranchList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysBranchList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSysBranchList_Load);
            this.tbLayPnl_Branches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BranchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tbLayPnl_Branches;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgv_BranchList;
        private TextBox txt_search;
        private Button btn_newBranch;
        private PictureBox pictureBox1;
    }
}