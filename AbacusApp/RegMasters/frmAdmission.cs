using AbacusApp.SysBase;
using AbacusApp.UpdateMasters;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbacusApp.RegMasters
{
    public partial class frmAdmission : Form
    {
        int total = 0;
        int dis = 0;
        int net = 0;
        int id;

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        int index;
        String gen;
        String remark;
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        MySqlCommand cmd;

        public frmAdmission()
        {
            InitializeComponent();
        }

        public void Trans_Entey()
        {
            StringBuilder head_str = new StringBuilder("");
            StringBuilder amt_str = new StringBuilder("");

            for (int i = 0; i < dgv_fees.Rows.Count; i++)
            {
                if (!(dgv_fees.Rows[i].Cells[2].Value.ToString().Equals("0")))
                {
                    if (head_str.Length > 0)
                    {
                        head_str.Append("," + (i + 1));

                    }
                    else
                    {
                        head_str.Append("" + (i + 1));
                    }

                    if (amt_str.Length > 0)
                    {
                        amt_str.Append("," + dgv_fees.Rows[i].Cells[2].Value.ToString());
                    }
                    else
                    {
                        amt_str.Append(dgv_fees.Rows[i].Cells[2].Value.ToString());
                    }
                }
            }
            conn.Open();
            cmd = new MySqlCommand("INSERT INTO trans_master (cand_id, cand_name, cand_role, total_fees, discount, net_fees, rmk, head_str, amt_str) VALUES(" + int.Parse(dt3.Rows[0].ItemArray[0].ToString()) + ",'" + txt_firstName.Text + " " + txt_middleName.Text + " " + txt_lastName.Text + "','0'," + float.Parse(txt_total.Text) + "," + float.Parse(txt_discount.Text) + "," + float.Parse(txt_netBalence.Text) + ",'" + txt_rmk.Text + "','" + head_str + "','" + amt_str + "')", conn);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            //cmd = new MySqlCommand("Insert into subscrp_log (subscrp_id, stud_profile_id, trans_id, subscrp_mode, status, )");
        }

        public void Get_ID()
        {
            String que = "Select id from stud_profile where contact_no = '" + txt_contactNo.Text + "' and branch_id = " + SysBase.frmSysDashboard.profile_id + "";
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt3);
        }

        public void Subsrp_Entry()
        {
            string s2 = "SELECT DATE_FORMAT(DATE_ADD(CURDATE(), INTERVAL 30 DAY), '%Y-%m-%d') AS '30 Days After'";
            DataTable d2 = new DataTable();
            ad = new MySqlDataAdapter(s2, conn);
            ad.Fill(d2);
            ad.Dispose();

            string dateStr = d2.Rows[0]["30 Days After"].ToString();

            DateTime date = DateTime.Parse(dateStr);

            string formattedDate = date.ToString("yyyy-MM-dd");

            DataTable d3 = new DataTable();
            ad = new MySqlDataAdapter("select MAX(id) from trans_master where cand_id = " + int.Parse(dt3.Rows[0].ItemArray[0].ToString()) + "", conn);
            ad.Fill(d3);

            Double a = Double.Parse(txt_netBalence.Text);
            Double b = Double.Parse(txt_paid.Text);
            Double ans = a - b;

            conn.Open();
            string sql = "INSERT INTO subscrp_log (subscrp_id, stud_profile_id, trans_id, subscrp_mode, status, start_date, end_date, balc_amt) VALUES (" + (cmb_lvl.SelectedIndex + 1) + "," + int.Parse(dt3.Rows[0].ItemArray[0].ToString()) + "," + int.Parse(d3.Rows[0].ItemArray[0].ToString()) + ",'Enrollment','1',CURDATE(),'" + formattedDate + "'," + ans.ToString("0.00") + ")";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void Levels()
        {
            ad = new MySqlDataAdapter("Select name, fees_amt from subscrp_master where status = '1'", conn);
            dt2 = new DataTable();
            ad.Fill(dt2);
        }

        private void frmAdmission_Load(object sender, EventArgs e)
        {
            String na = dt.Rows[index].ItemArray[1].ToString();
            String[] ar = na.Split(" ");
            txt_firstName.Text = ar[0];
            txt_lastName.Text = ar[1];
            txt_contactNo.Text = dt.Rows[index].ItemArray[3].ToString();
            txt_email.Text = dt.Rows[index].ItemArray[4].ToString();
            txt_addr.Text = dt.Rows[index].ItemArray[5].ToString();
            gen = dt.Rows[index].ItemArray[2].ToString();

            DataTable dta = new DataTable();
            string que = "Select name from city_master";
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dta);
            int i = 0;
            while (i < dta.Rows.Count)
            {
                cmbo_city.Items.Add(dta.Rows[i].ItemArray[0]);
                i++;
            }


            DataTable dataTable = new DataTable();
            ad = new MySqlDataAdapter("select id, name from fees_heads where find_in_set('0', fees_head_role) and status = '1'", conn);
            ad.Fill(dataTable);
            dgv_fees.DataSource = dataTable;

            Levels();
            for (int j = 0; j < dt2.Rows.Count; j++)
            {
                cmb_lvl.Items.Add(dt2.Rows[j].ItemArray[0].ToString());
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
            for (int j = 0; j < dgv_fees.Rows.Count; j++)
            {
                dgv_fees.Rows[j].Cells[0].ReadOnly = true;
                dgv_fees.Rows[j].Cells[1].ReadOnly = true;
            }
            txt_discount.Text = 0 + "";
        }

        public void getData(DataTable dtt, int i, String s)
        {
            dt = dtt;
            index = i;
            remark = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String rmk;
            if (remark.Equals(""))
            {
                rmk = "Admitted By " + frmSysDashboard.name;
            }
            else
            {
                rmk = remark + " Admitted By " + frmSysDashboard.name;
            }

            String que = "Update enq_master set rmk = '" + rmk + "', status = '1' where id = " + int.Parse(dt.Rows[index].ItemArray[0].ToString());
            String que2 = "INSERT INTO stud_profile (first_name, middle_name, last_name, contact_no, email_id, addr, gender, pwd, branch_id, city_name, current_subscrp_id, status) " +
            "values ('" + txt_firstName.Text + "','" + txt_middleName.Text + "','" + txt_lastName.Text + "','" + txt_contactNo.Text + "','" + txt_email.Text + "','" + txt_addr.Text + "','" + gen + "','" + 12345 + "'," + frmSysDashboard.profile_id + ",'" + cmbo_city.Text + "'," + (cmb_lvl.SelectedIndex + 1) + ",'" + 1 + "')";
            
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(que2, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();

            Get_ID();
            Trans_Entey();
            Subsrp_Entry();

            conn.Open();
            cmd = new MySqlCommand(que, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            this.Dispose();
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

        private void txt_discount_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_discount.Text == "0")
            {
                txt_discount.Text = "";
            }
        }

        private void txt_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgv_fees_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv_fees.CurrentCell.ColumnIndex == 2 && e.Control is TextBox)
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
            txt_netBalence.Text = third.ToString();
            total = (int)float.Parse(txt_total.Text);
        }
    }
}
