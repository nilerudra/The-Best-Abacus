
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSysBranchList));
            this.tbLayPnl_Branches = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_newBranch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lsv_branchLs = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_search = new System.Windows.Forms.Label();
            this.tbLayPnl_Branches.SuspendLayout();
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
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(534, 33);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(238, 25);
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
            this.btn_newBranch.Location = new System.Drawing.Point(633, 413);
            this.btn_newBranch.Name = "btn_newBranch";
            this.btn_newBranch.Size = new System.Drawing.Size(139, 38);
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
            this.pictureBox1.Location = new System.Drawing.Point(788, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lsv_branchLs
            // 
            this.lsv_branchLs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_branchLs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lsv_branchLs.Location = new System.Drawing.Point(13, 78);
            this.lsv_branchLs.Name = "lsv_branchLs";
            this.lsv_branchLs.Size = new System.Drawing.Size(759, 316);
            this.lsv_branchLs.TabIndex = 4;
            this.lsv_branchLs.UseCompatibleStateImageBehavior = false;
            this.lsv_branchLs.DoubleClick += new System.EventHandler(this.lsv_branchLs_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "branch_active.png");
            this.imageList1.Images.SetKeyName(1, "branch_inactive.png");
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_search.Location = new System.Drawing.Point(461, 33);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(64, 21);
            this.lbl_search.TabIndex = 5;
            this.lbl_search.Text = "Search :";
            // 
            // frmSysBranchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.lsv_branchLs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_newBranch);
            this.Controls.Add(this.txt_search);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysBranchList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch List";
            this.Load += new System.EventHandler(this.frmSysBranchList_Load);
            this.tbLayPnl_Branches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tbLayPnl_Branches;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txt_search;
        private Button btn_newBranch;
        private PictureBox pictureBox1;
        private ListView lsv_branchLs;
        private ImageList imageList1;
        private Label lbl_search;
    }
}