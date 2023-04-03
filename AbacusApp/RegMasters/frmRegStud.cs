using AbacusApp.SysBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbacusApp.RegMasters
{
    public partial class frmRegStud : Form
    {
        int total = 0;
        int dis = 0;
        int net = 0;
        int id;

        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        DataTable dt2 = new DataTable();
        public frmRegStud()
        {
            InitializeComponent();
        }

        public void Levels()
        {
            ad = new MySqlDataAdapter("Select name, fees_amt from subscrp_master where status = '1'", conn);
            dt2 = new DataTable();
            ad.Fill(dt2);
        }

        private void frmRegStud_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            ad = new MySqlDataAdapter("select id, name from fees_heads where find_in_set('0', fees_head_role) and status = '1'", conn);
            ad.Fill(dataTable);
            dgv_fees.DataSource = dataTable;

            Levels();

            for(int i = 0; i < dt2.Rows.Count; i++)
            {
                cmb_lvl.Items.Add(dt2.Rows[i].ItemArray[0].ToString());
            }


            DataGridViewColumn newColumn = new DataGridViewTextBoxColumn();
            newColumn.HeaderText = "Fees";
            newColumn.Name = "fees";
            dgv_fees.Columns.Add(newColumn);

            dgv_fees.Rows[2].Cells[2].Value = 0;
            dgv_fees.Rows[3].Cells[2].Value = 0;
            dgv_fees.Rows[0].Cells[2].Value = 0;
            dgv_fees.Rows[1].Cells[2].Value = 0;
            dgv_fees.Rows[2].Cells[2].ReadOnly = true;
            dgv_fees.Rows[3].Cells[2].ReadOnly = true;
            for (int i = 0; i < dgv_fees.Rows.Count; i++)
            {
                dgv_fees.Rows[i].Cells[0].ReadOnly = true;
                dgv_fees.Rows[i].Cells[1].ReadOnly = true;
            }
            txt_discount.Text = 0 + "";
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            String s = "";
            if (rbtn_male.Checked == true)
            {
                s = "Male";
            }
            else if (rbtn_female.Checked == true)
            {
                s = "Female";
            }
            else if(rbtn_other.Checked == true)
            {
                s = "Other";
            }
            
            String que = "INSERT INTO stud_profile (first_name, middle_name, last_name, contact_no, email_id, addr, gender, pwd, branch_id, city_name, current_subscrp_id, status) " +
            "values ('" + txt_firstName.Text + "','" + txt_middleName.Text + "','" + txt_lastName.Text + "','" + txt_contactNo.Text + "','" + txt_email.Text + "','" + txt_addr.Text + "','" + s + "','" + 12345 + "'," + frmSysDashboard.id + ",'" + txt_city.Text + "'," + 1 + ",'" + 1 + "')";
            conn.Open();
            cmd = new MySqlCommand(que, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            String que1 = "Insert into enq_master (name, contact, email, address, status, enq_type, rmk , branch_id) " +
                "values('" + txt_firstName.Text + " " + txt_lastName.Text+"','" + txt_contactNo.Text + "','" + txt_email.Text + "','" + txt_addr.Text + "','" + 1 + "','Offline Enquiry','Admitted by " + frmSysDashboard.name + "'," + frmSysDashboard.id +")";

            cmd = new MySqlCommand(que1, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            this.Close();
        }

        private void dgv_fees_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int third = 0;
            if (dgv_fees.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString() == "")
            {
                dgv_fees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            }

            for (int i = 0; i < dgv_fees.Rows.Count; i++)
            {
                third += Convert.ToInt32(dgv_fees.Rows[i].Cells[2].Value);
            }

            txt_total.Text = third.ToString();
            total = (int)float.Parse(txt_total.Text);
        }

        private void dgv_fees_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(dgv_fees.CurrentCell.ColumnIndex == 2 && e.Control is TextBox)
            {
                TextBox textBox = e.Control as TextBox;
                textBox.KeyPress -= textBox_KeyPress;
                textBox.KeyPress += textBox_KeyPress;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0)
            {
                txt_netBalence.Text = (Convert.ToInt32(txt_total.Text) - Convert.ToInt32(txt_discount.Text)).ToString();
                net = (int)float.Parse(txt_netBalence.Text);
            }
            else
            {
                txt_netBalence.Text = txt_total.Text;
                net = (int)float.Parse(txt_netBalence.Text);
            }
        }

        private void cmb_lvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_fees.Rows[0].Cells[2].Value = 0;
            dgv_fees.Rows[1].Cells[2].Value = 0;
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt2.Rows[i].ItemArray[0].ToString().Equals(cmb_lvl.Text))
                {
                    dgv_fees.Rows[2].Cells[2].Value = dt2.Rows[i].ItemArray[1].ToString();
                }
            }
        }
    }
}
