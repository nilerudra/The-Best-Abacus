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
            this.btn_newAdmission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newAdmission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_newAdmission.Location = new System.Drawing.Point(624, 412);
            this.btn_newAdmission.Name = "btn_newAdmission";
            this.btn_newAdmission.Size = new System.Drawing.Size(148, 37);
            this.btn_newAdmission.TabIndex = 1;
            this.btn_newAdmission.Text = "New Admission";
            this.btn_newAdmission.UseVisualStyleBackColor = true;
            this.btn_newAdmission.Click += new System.EventHandler(this.btn_newAdmission_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(526, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmSysAdmittedStudLs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
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
    }
}