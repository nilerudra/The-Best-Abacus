namespace AbacusApp.Masters
{
    partial class frmSysAdmittedStudLs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSysAdmittedStudLs));
            this.lsv_admittedStud = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_newAdmission = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_shift = new System.Windows.Forms.Button();
            this.btn_promote = new System.Windows.Forms.Button();
            this.lbl_search = new System.Windows.Forms.Label();
            this.cmbo_branch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lsv_admittedStud
            // 
            this.lsv_admittedStud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_admittedStud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsv_admittedStud.LargeImageList = this.imageList1;
            this.lsv_admittedStud.Location = new System.Drawing.Point(-3, 74);
            this.lsv_admittedStud.Name = "lsv_admittedStud";
            this.lsv_admittedStud.Size = new System.Drawing.Size(790, 321);
            this.lsv_admittedStud.SmallImageList = this.imageList1;
            this.lsv_admittedStud.TabIndex = 0;
            this.lsv_admittedStud.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "female_active.png");
            this.imageList1.Images.SetKeyName(1, "female_inactive.png");
            this.imageList1.Images.SetKeyName(2, "male_active.png");
            this.imageList1.Images.SetKeyName(3, "male_inactive.png");
            // 
            // btn_newAdmission
            // 
            this.btn_newAdmission.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_newAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newAdmission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_newAdmission.Location = new System.Drawing.Point(321, 412);
            this.btn_newAdmission.Name = "btn_newAdmission";
            this.btn_newAdmission.Size = new System.Drawing.Size(148, 37);
            this.btn_newAdmission.TabIndex = 1;
            this.btn_newAdmission.Text = "New Admission";
            this.btn_newAdmission.UseVisualStyleBackColor = true;
            this.btn_newAdmission.Click += new System.EventHandler(this.btn_newAdmission_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(526, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_shift
            // 
            this.btn_shift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_shift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shift.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_shift.Location = new System.Drawing.Point(12, 412);
            this.btn_shift.Name = "btn_shift";
            this.btn_shift.Size = new System.Drawing.Size(148, 37);
            this.btn_shift.TabIndex = 3;
            this.btn_shift.Text = "Shifting";
            this.btn_shift.UseVisualStyleBackColor = true;
            this.btn_shift.Click += new System.EventHandler(this.btn_shift_Click);
            // 
            // btn_promote
            // 
            this.btn_promote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_promote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_promote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_promote.Location = new System.Drawing.Point(624, 412);
            this.btn_promote.Name = "btn_promote";
            this.btn_promote.Size = new System.Drawing.Size(148, 37);
            this.btn_promote.TabIndex = 4;
            this.btn_promote.Text = "Promote";
            this.btn_promote.UseVisualStyleBackColor = true;
            this.btn_promote.Click += new System.EventHandler(this.btn_promote_Click);
            // 
            // lbl_search
            // 
            this.lbl_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_search.Location = new System.Drawing.Point(442, 24);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(78, 25);
            this.lbl_search.TabIndex = 5;
            this.lbl_search.Text = "Search :";
            // 
            // cmbo_branch
            // 
            this.cmbo_branch.FormattingEnabled = true;
            this.cmbo_branch.Items.AddRange(new object[] {
            "All"});
            this.cmbo_branch.Location = new System.Drawing.Point(84, 24);
            this.cmbo_branch.Name = "cmbo_branch";
            this.cmbo_branch.Size = new System.Drawing.Size(208, 23);
            this.cmbo_branch.TabIndex = 6;
            this.cmbo_branch.SelectedIndexChanged += new System.EventHandler(this.cmbo_branch_SelectedIndexChanged);
            // 
            // frmSysAdmittedStudLs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cmbo_branch);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_promote);
            this.Controls.Add(this.btn_shift);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_newAdmission);
            this.Controls.Add(this.lsv_admittedStud);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysAdmittedStudLs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admitted Students";
            this.Load += new System.EventHandler(this.frmSysAdmittedStudLs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lsv_admittedStud;
        private ImageList imageList1;
        private Button btn_newAdmission;
        private TextBox textBox1;
        private Button btn_shift;
        private Button btn_promote;
        private Label lbl_search;
        private ComboBox cmbo_branch;
    }
}