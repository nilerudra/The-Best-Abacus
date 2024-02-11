using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AbacusApp.Masters
{
    public partial class frmSystransactiion : Form
    {
        int total = 0;
        int dis = 0;
        int net = 0;
        int id;
        String name;
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();

        public frmSystransactiion()
        {
            InitializeComponent();
        }

        public void Get_ID()
        {
            String que = "Select MAX(id) from stud_profile where branch_id = " + SysBase.frmSysDashboard.profile_id + "";
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt3);
        }

        /*public void Cal_Date()
        {
            String s = "SELECT DATE(start_date) AS start_date FROM subscrp_log WHERE stud_profile_id = 15 LIMIT 1";

            DataTable d = new DataTable();
            ad = new MySqlDataAdapter(s, conn);
            ad.Fill(d);
            MessageBox.Show(d.Rows[0].ItemArray[0].ToString() + "");
            ad.Dispose();

            String s2 = "SELECT DATE_ADD(STR_TO_DATE('" + d.Rows[0].ItemArray[0] + "', '%Y-%m-%d'), INTERVAL 30 DAY) AS '30 Days After'";
            DataTable d2 = new DataTable();
            ad = new MySqlDataAdapter(s2, conn);
            ad.Fill(d2);
            MessageBox.Show(d2.Rows[0].ItemArray[0].ToString());
        }*/

        public void Cal_Date()
        {
            String s = "SELECT DATE_FORMAT(start_date, '%Y-%m-%d') AS start_date FROM subscrp_log WHERE stud_profile_id = 15 ORDER BY start_date DESC LIMIT 1";
            DataTable d = new DataTable();
            ad = new MySqlDataAdapter(s, conn);
            ad.Fill(d);
            ad.Dispose();

            if (d.Rows.Count > 0)
            {
                String dateStr = d.Rows[0].ItemArray[0].ToString();
                String s2 = "SELECT DATE_ADD('" + dateStr + "', INTERVAL 30 DAY) AS '30 Days After'";
                DataTable d2 = new DataTable();
                ad = new MySqlDataAdapter(s2, conn);
                ad.Fill(d2);
                ad.Dispose();


                DataTable d3 = new DataTable();
                String s3 = "SELECT DATEDIFF('" + d2.Rows[0].ItemArray[0].ToString() + "', NOW()) AS diff";
                ad = new MySqlDataAdapter(s3, conn);
                ad.Fill(d3);
                ad.Dispose();

                if (int.Parse(d3.Rows[0].ItemArray[0].ToString()) < 0)
                {
                    //lbl_days.Text = "0";
                }
                else
                {
                    if (d2.Rows.Count > 0)
                    {
                        String result = d2.Rows[0].ItemArray[0].ToString();
                       // expire_date.Text = result;
                       // lbl_days.Text = d3.Rows[0].ItemArray[0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No result found for DATE_ADD query.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No result found for SELECT query.");
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (cmbo_studName.SelectedIndex == -1)
            {

                int cursorPosition = cmbo_studName.SelectionStart;
                DataTable dt1 = new DataTable();
                dt1 = dt.Clone();
                dt1.Clear();
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    if (dt.Rows[i].ItemArray[1].ToString().Contains(cmbo_studName.Text))
                    {
                        DataRow newRow = dt1.NewRow();
                        newRow.ItemArray = dt.Rows[i].ItemArray.Clone() as object[];
                        dt1.Rows.Add(newRow);
                    }
                    i++;
                }
                cmbo_studName.Items.Clear();
                int j = 0;
                while (j < dt1.Rows.Count)
                {
                    cmbo_studName.Items.Add(dt1.Rows[j].ItemArray[1].ToString());
                    j++;
                }
                cmbo_studName.SelectionStart = cursorPosition;
            }
            else
            {
                name = cmbo_studName.Text;
            }
        }

        public void Levels()
        {
            ad = new MySqlDataAdapter("Select name, fees_amt from subscrp_master where status = '1'", conn);
            dt2 = new DataTable();
            ad.Fill(dt2);
        }

        public void FillLevel(int level)
        {
            cmb_lvl.Items.Clear();
            int j = level;
            while (j < dt2.Rows.Count)
            {
                cmb_lvl.Items.Add(dt2.Rows[j].ItemArray[0].ToString());
                j++;
            }

            dgv_fees.Rows[0].Cells[2].Value = 0;
            dgv_fees.Rows[1].Cells[2].Value = 0;
        }

        private void frmSystransactiion_Load(object sender, EventArgs e)
        {
            Cal_Date();
            ad = new MySqlDataAdapter("Select id, concat(first_name,' ',middle_name,' ',last_name) as name, current_subscrp_id from stud_profile where branch_id = " + SysBase.frmSysDashboard.profile_id + " and status = '1'", conn);
            ad.Fill(dt);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                cmbo_studName.Items.Add(dt.Rows[i].ItemArray[1].ToString());
            }

            DataTable dataTable = new DataTable();
            ad = new MySqlDataAdapter("select id, name from fees_heads where find_in_set('0', fees_head_role) and status = '1'", conn);
            ad.Fill(dataTable);
            dgv_fees.DataSource = dataTable;

            Levels();
            DataGridViewColumn newColumn = new DataGridViewTextBoxColumn();
            newColumn.HeaderText = "Fees";
            newColumn.Name = "fees";
            dgv_fees.Columns.Add(newColumn);
            
            dgv_fees.Rows[2].Cells[2].Value = 0;
            dgv_fees.Rows[3].Cells[2].Value = 0;
            dgv_fees.Rows[0].Cells[2].Value = 0;
            dgv_fees.Rows[1].Cells[2].Value = 0;
            dgv_fees.Rows[2].Cells[2].ReadOnly= true;
            dgv_fees.Rows[3].Cells[2].ReadOnly = true;
            for (int i = 0; i < dgv_fees.Rows.Count; i++)
            {
                dgv_fees.Rows[i].Cells[0].ReadOnly  = true;
                dgv_fees.Rows[i].Cells[1].ReadOnly = true;
            }
            txt_discount.Text = 0 + "";
        }

        private void dgv_fees_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int third = 0;
            if (dgv_fees.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString() == "")
            {
                dgv_fees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            }

            for(int i = 0; i < dgv_fees.Rows.Count; i++)
            {
                third += Convert.ToInt32(dgv_fees.Rows[i].Cells[2].Value);
            }
           
            txt_total.Text = third.ToString();
            total = (int)float.Parse(txt_total.Text);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            StringBuilder head_str = new StringBuilder("");
            for(int i = 0; i < dgv_fees.Rows.Count; i++)
            {
                if (!(dgv_fees.Rows[i].Cells[2].Value.ToString().Equals("0")))
                {
                    if (head_str.Length > 0)
                    {
                        head_str.Append("," + (i+1));
                    }
                    else
                    {
                        head_str.Append("" + (i + 1));
                    }
                }
            }
            MessageBox.Show(head_str + "");
            /*String q = "insert into trans_master (cand_id, cand_name, cand_role, total_fees, discount, net_fees, status, ref_code, head_str, amt_str) values" +
                " " +id+ ",'" +name+ "','" +0+ "'," +total+ "," +txt_discount.Text+ "," +net+",'0','0','" +head_str+ "', ";*/
        }

        private void cmbo_studName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // set Handled property to true by default

            if (Char.IsControl(e.KeyChar)) // allow control keys (e.g. backspace, delete)
            {
                e.Handled = false;
            }
            else
            {
                // Check if the key pressed exists in the ComboBox Items collection
                foreach (string item in cmbo_studName.Items)
                {
                    if (item.Contains(e.KeyChar.ToString(), StringComparison.CurrentCultureIgnoreCase))
                    {
                        e.Handled = false;
                        break;
                    }
                }
            }
        }

        private void cmbo_studName_Click(object sender, EventArgs e)
        {
            cmbo_studName.DroppedDown = true;
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

        private void cmbo_studName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_changeLvl.Enabled = false;
            txt_discount.Text = 0 + "";
            for(int i = 0; i < dgv_fees.Rows.Count; i++) 
            {
                dgv_fees.Rows[i].Cells[2].Value = 0;
            }

            cmb_lvl.Text = "";

            changeLevel();

            if(cmb_lvl.Items.Count == 1)
            {
                cb_changeLvl.Enabled = true;
            }
        }

        public void changeLevel()
        {
            cmb_lvl.Items.Clear();
            id = int.Parse(dt.Rows[cmbo_studName.SelectedIndex].ItemArray[0].ToString());
            int lvl = 0;

            ad = new MySqlDataAdapter("select stud_profile_id from subscrp_log where stud_profile_id =" + id + "", conn);
            DataTable table = new DataTable();
            ad.Fill(table);

            if (table.Rows.Count > 0)
            {
                lvl = int.Parse(dt.Rows[cmbo_studName.SelectedIndex].ItemArray[2].ToString());
                cmb_lvl.Items.Add("Level-" + lvl);
            }
            else
            {
                FillLevel(0);
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if(txt_discount.Text.Length > 0)
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

        private void cb_changeLvl_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_changeLvl.Checked)
            {
                string l = cmb_lvl.Items[0].ToString();
                String[] a = l.Split("-");
                int lvl = Convert.ToInt32(a[1]);

                FillLevel(lvl);
                cmb_lvl.SelectedIndex = 0;
            }
            else
            {
                changeLevel();
                cmb_lvl.SelectedIndex = 0;
            }
        }

        private void dgv_fees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}