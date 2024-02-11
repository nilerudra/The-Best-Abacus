namespace AbacusApp.Masters
{
    partial class frmSystransactiion
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
            this.cmbo_studName = new System.Windows.Forms.ComboBox();
            this.lbl_selectStud = new System.Windows.Forms.Label();
            this.dgv_fees = new System.Windows.Forms.DataGridView();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_netBalence = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_lvl = new System.Windows.Forms.Label();
            this.cmb_lvl = new System.Windows.Forms.ComboBox();
            this.cb_changeLvl = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fees)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbo_studName
            // 
            this.cmbo_studName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbo_studName.FormattingEnabled = true;
            this.cmbo_studName.Location = new System.Drawing.Point(321, 24);
            this.cmbo_studName.Name = "cmbo_studName";
            this.cmbo_studName.Size = new System.Drawing.Size(232, 23);
            this.cmbo_studName.TabIndex = 0;
            this.cmbo_studName.SelectedIndexChanged += new System.EventHandler(this.cmbo_studName_SelectedIndexChanged);
            this.cmbo_studName.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.cmbo_studName.Click += new System.EventHandler(this.cmbo_studName_Click);
            this.cmbo_studName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbo_studName_KeyPress);
            // 
            // lbl_selectStud
            // 
            this.lbl_selectStud.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_selectStud.AutoSize = true;
            this.lbl_selectStud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_selectStud.Location = new System.Drawing.Point(178, 24);
            this.lbl_selectStud.Name = "lbl_selectStud";
            this.lbl_selectStud.Size = new System.Drawing.Size(128, 21);
            this.lbl_selectStud.TabIndex = 1;
            this.lbl_selectStud.Text = "Select Student :";
            // 
            // dgv_fees
            // 
            this.dgv_fees.AllowUserToAddRows = false;
            this.dgv_fees.AllowUserToDeleteRows = false;
            this.dgv_fees.AllowUserToResizeColumns = false;
            this.dgv_fees.AllowUserToResizeRows = false;
            this.dgv_fees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_fees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_fees.BackgroundColor = System.Drawing.Color.White;
            this.dgv_fees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_fees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_fees.GridColor = System.Drawing.Color.White;
            this.dgv_fees.Location = new System.Drawing.Point(12, 153);
            this.dgv_fees.Name = "dgv_fees";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_fees.RowHeadersWidth = 62;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_fees.RowTemplate.Height = 25;
            this.dgv_fees.Size = new System.Drawing.Size(760, 120);
            this.dgv_fees.TabIndex = 2;
            this.dgv_fees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_fees_CellContentClick);
            this.dgv_fees.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_fees_CellValueChanged);
            this.dgv_fees.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_fees_EditingControlShowing);
            // 
            // txt_total
            // 
            this.txt_total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_total.Location = new System.Drawing.Point(386, 288);
            this.txt_total.Margin = new System.Windows.Forms.Padding(0);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(155, 23);
            this.txt_total.TabIndex = 3;
            // 
            // txt_discount
            // 
            this.txt_discount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_discount.Location = new System.Drawing.Point(386, 319);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(155, 23);
            this.txt_discount.TabIndex = 4;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            // 
            // txt_netBalence
            // 
            this.txt_netBalence.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_netBalence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_netBalence.Location = new System.Drawing.Point(386, 350);
            this.txt_netBalence.Margin = new System.Windows.Forms.Padding(0);
            this.txt_netBalence.Name = "txt_netBalence";
            this.txt_netBalence.ReadOnly = true;
            this.txt_netBalence.Size = new System.Drawing.Size(155, 23);
            this.txt_netBalence.TabIndex = 5;
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_total.Location = new System.Drawing.Point(324, 289);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(47, 17);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Total :";
            // 
            // lbl_discount
            // 
            this.lbl_discount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_discount.Location = new System.Drawing.Point(300, 320);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(71, 17);
            this.lbl_discount.TabIndex = 7;
            this.lbl_discount.Text = "Discount :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(279, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Net Amount :";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(338, 419);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 36);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_lvl.Location = new System.Drawing.Point(196, 53);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(108, 21);
            this.lbl_lvl.TabIndex = 13;
            this.lbl_lvl.Text = "Select Level :";
            // 
            // cmb_lvl
            // 
            this.cmb_lvl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_lvl.FormattingEnabled = true;
            this.cmb_lvl.Location = new System.Drawing.Point(321, 53);
            this.cmb_lvl.Name = "cmb_lvl";
            this.cmb_lvl.Size = new System.Drawing.Size(232, 23);
            this.cmb_lvl.TabIndex = 12;
            this.cmb_lvl.SelectedIndexChanged += new System.EventHandler(this.cmb_lvl_SelectedIndexChanged);
            // 
            // cb_changeLvl
            // 
            this.cb_changeLvl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_changeLvl.AutoSize = true;
            this.cb_changeLvl.Enabled = false;
            this.cb_changeLvl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_changeLvl.Location = new System.Drawing.Point(599, 55);
            this.cb_changeLvl.Name = "cb_changeLvl";
            this.cb_changeLvl.Size = new System.Drawing.Size(104, 21);
            this.cb_changeLvl.TabIndex = 14;
            this.cb_changeLvl.Text = "Change Level";
            this.cb_changeLvl.UseVisualStyleBackColor = true;
            this.cb_changeLvl.CheckedChanged += new System.EventHandler(this.cb_changeLvl_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(328, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Paid :";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(386, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 23);
            this.textBox1.TabIndex = 15;
            // 
            // frmSystransactiion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_changeLvl);
            this.Controls.Add(this.lbl_lvl);
            this.Controls.Add(this.cmb_lvl);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_discount);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.txt_netBalence);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.dgv_fees);
            this.Controls.Add(this.lbl_selectStud);
            this.Controls.Add(this.cmbo_studName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystransactiion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.frmSystransactiion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbo_studName;
        private Label lbl_selectStud;
        private DataGridView dgv_fees;
        private TextBox txt_total;
        private TextBox txt_discount;
        private TextBox txt_netBalence;
        private Label lbl_total;
        private Label lbl_discount;
        private Label label3;
        private Button btn_Save;
        private Label lbl_lvl;
        private ComboBox cmb_lvl;
        private CheckBox cb_changeLvl;
        private Label label1;
        private TextBox textBox1;
    }
}