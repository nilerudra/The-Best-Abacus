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
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_netBalence = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fees)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbo_studName
            // 
            this.cmbo_studName.FormattingEnabled = true;
            this.cmbo_studName.Location = new System.Drawing.Point(162, 24);
            this.cmbo_studName.Name = "cmbo_studName";
            this.cmbo_studName.Size = new System.Drawing.Size(232, 23);
            this.cmbo_studName.TabIndex = 0;
            this.cmbo_studName.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // lbl_selectStud
            // 
            this.lbl_selectStud.AutoSize = true;
            this.lbl_selectStud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_selectStud.Location = new System.Drawing.Point(30, 22);
            this.lbl_selectStud.Name = "lbl_selectStud";
            this.lbl_selectStud.Size = new System.Drawing.Size(115, 21);
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
            this.dgv_fees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_fees.GridColor = System.Drawing.Color.White;
            this.dgv_fees.Location = new System.Drawing.Point(12, 106);
            this.dgv_fees.Name = "dgv_fees";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_fees.RowTemplate.Height = 25;
            this.dgv_fees.Size = new System.Drawing.Size(760, 147);
            this.dgv_fees.TabIndex = 2;
            this.dgv_fees.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_fees_CellEndEdit);
            this.dgv_fees.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_fees_CellLeave);
            this.dgv_fees.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_fees_CellValueChanged);
            this.dgv_fees.Leave += new System.EventHandler(this.dgv_fees_Leave);
            // 
            // Select
            // 
            this.Select.HeaderText = "Check";
            this.Select.Name = "Select";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(500, 306);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(155, 23);
            this.txt_total.TabIndex = 3;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(500, 337);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(155, 23);
            this.txt_discount.TabIndex = 4;
            // 
            // txt_netBalence
            // 
            this.txt_netBalence.Location = new System.Drawing.Point(500, 368);
            this.txt_netBalence.Name = "txt_netBalence";
            this.txt_netBalence.Size = new System.Drawing.Size(155, 23);
            this.txt_netBalence.TabIndex = 5;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(427, 314);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(38, 15);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(500, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(500, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 64);
            this.listBox1.TabIndex = 10;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Location = new System.Drawing.Point(169, 382);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 36);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmSystransactiion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private DataGridViewCheckBoxColumn Select;
        private TextBox txt_total;
        private TextBox txt_discount;
        private TextBox txt_netBalence;
        private Label lbl_total;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button btn_Save;
    }
}