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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_days = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.expire_date = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_fees.GridColor = System.Drawing.Color.White;
            this.dgv_fees.Location = new System.Drawing.Point(12, 153);
            this.dgv_fees.Name = "dgv_fees";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_fees.RowHeadersWidth = 62;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(157, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "The Current Level is ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(316, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "..... ,";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(354, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "will expire in ";
            // 
            // lbl_days
            // 
            this.lbl_days.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_days.AutoSize = true;
            this.lbl_days.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_days.Location = new System.Drawing.Point(460, 99);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(22, 21);
            this.lbl_days.TabIndex = 20;
            this.lbl_days.Text = "....";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(489, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "days. on date";
            // 
            // expire_date
            // 
            this.expire_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.expire_date.AutoSize = true;
            this.expire_date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expire_date.Location = new System.Drawing.Point(594, 99);
            this.expire_date.Name = "expire_date";
            this.expire_date.Size = new System.Drawing.Size(34, 21);
            this.expire_date.TabIndex = 22;
            this.expire_date.Text = "........";
            // 
            // frmSystransactiion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.expire_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_days);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
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
        private Label label2;
        private Label label4;
        private Label label5;
        private Label lbl_days;
        private Label label7;
        private Label expire_date;
    }
}