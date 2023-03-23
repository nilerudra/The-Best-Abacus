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

namespace AbacusApp.Masters
{
    public partial class frmSystransactiion : Form
    {
        String name;
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public frmSystransactiion()
        {
            InitializeComponent();
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

        private void ifSelected()
        {
            for (int i = 0; i < dgv_fees.Rows.Count; i++)
            {
                if (!Convert.ToBoolean(dgv_fees.Rows[i].Cells[0].Value))
                {
                    dgv_fees.Rows[i].Cells[3].ReadOnly = true;
                }
                else
                {
                    dgv_fees.Rows[i].Cells[3].ReadOnly = false;
                }
            }
        }

        public void Levels()
        {
            ad = new MySqlDataAdapter("Select name, fees_amt from subscrp_master where status = '1'", conn);
            dt2 = new DataTable();
            ad.Fill(dt2);
        }

        private void frmSystransactiion_Load(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("Select id, concat(first_name,' ',middle_name,' ',last_name) as name from stud_profile where branch_id = " + SysBase.frmSysDashboard.profile_id + " and status = '1'", conn);
            ad.Fill(dt);

            int i = 0;
            while (i < dt.Rows.Count)
            {
                cmbo_studName.Items.Add(dt.Rows[i].ItemArray[1].ToString());
                listBox1.Items.Add(dt.Rows[i].ItemArray[1].ToString());
                i++;
            }

            DataTable dataTable = new DataTable();
            ad = new MySqlDataAdapter("select id, name from fees_heads where fees_head_role = '0' and status = '1'", conn);
            ad.Fill(dataTable);
            dgv_fees.DataSource = dataTable;

            Levels();

            DataGridViewColumn newColumn = new DataGridViewTextBoxColumn();
            newColumn.HeaderText = "Fees";
            newColumn.Name = "fees";

            dgv_fees.Columns.Add(newColumn);

            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            int j = 0;
            while (j < dt2.Rows.Count)
            {
                cell.Items.Add(dt2.Rows[j].ItemArray[0].ToString());
                cell.FlatStyle = FlatStyle.Flat;
                j++;
            }
            dgv_fees.Rows[2].Cells[newColumn.Name] = cell;
            dgv_fees.Rows[0].Cells[3].Value = 0;
            dgv_fees.Rows[1].Cells[3].Value = 0;
            
        }

        private void dgv_fees_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ifSelected();
            /*if (dgv_fees.Columns[e.ColumnIndex].CellType == typeof(DataGridViewCheckBoxCell) && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = dgv_fees.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                bool isChecked = Convert.ToBoolean(checkBoxCell.Value);

                if (isChecked)
                {
                    dgv_fees.Rows[e.RowIndex].Cells[3].ReadOnly = false;
                }
                else
                {
                    dgv_fees.Rows[e.RowIndex].Cells[3].ReadOnly = true;
                }
            }*/
        }

        private void dgv_fees_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //int fees_amt = 0;
            //int regv = 0;
            //int levelKit = 0;

            //if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            //{
            //    for(int i = 0; i < dt2.Rows.Count; i++)
            //    {
            //        if (dt2.Rows[i].ItemArray[0].ToString().Equals(dgv_fees.Rows[2].Cells[3].Value))
            //        {
            //            fees_amt = int.Parse(dt2.Rows[i].ItemArray[1].ToString());
            //        }
            //    }

            //    regv = int.Parse(dgv_fees.Rows[0].Cells[3].Value.ToString());
            //    levelKit = int.Parse(dgv_fees.Rows[1].Cells[3].Value.ToString());

            //    txt_total.Text = "" + (fees_amt + levelKit + regv);
            //}
        }

        private void dgv_fees_Leave(object sender, EventArgs e)
        {

        }

        private void dgv_fees_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            /*int fees_amt = 0;
            int regv = 0;
            int levelKit = 0;

            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    if (dt2.Rows[i].ItemArray[0].ToString().Equals(dgv_fees.Rows[2].Cells[3].Value))
                    {
                        fees_amt = int.Parse(dt2.Rows[i].ItemArray[1].ToString());
                    }
                }

                regv = int.Parse(dgv_fees.Rows[0].Cells[3].Value.ToString());
                levelKit = int.Parse(dgv_fees.Rows[1].Cells[3].Value.ToString());

                txt_total.Text = "" + (fees_amt + levelKit + regv);
            }*/
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           /* // Filter the items in the ListBox based on the current text in the TextBox.
            string filter = textBox1.Text.ToLower();
            List<string> visibleItems = listBox1.Items.Cast<string>()
                .Where(item => item.ToLower().Contains(filter))
                .ToList();
            listBox1.DataSource = visibleItems;

            // Show the ListBox if there are any matching items, otherwise hide it.
            if (visibleItems.Any())
            {
                listBox1.Visible = true;
            }
            else
            {
                listBox1.Visible = false;
            }*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            // Copy the selected item from the ListBox to the TextBox and disable the TextBox.
            /*if (listBox1.SelectedIndex != -1)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                //textBox1.Enabled = false;
                listBox1.Visible = false;
            }*/
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            // Enable the TextBox when it is clicked.
            //textBox1.Enabled = true;
            /*listBox1.Visible = true;*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            string filter = textBox1.Text.ToLower();
            List<string> visibleItems = listBox1.Items.Cast<string>()
                .Where(item => item.ToLower().Contains(filter))
                .ToList();
            listBox1.DataSource = visibleItems;

            // Show the ListBox if there are any matching items, otherwise hide it.
            if (visibleItems.Any())
            {
                listBox1.Visible = true;
            }
            else
            {
                listBox1.Visible = false;
            }*/
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int first = 0;
            int second = 0;
            int third = 0;

            if (dgv_fees.Rows[0].Cells[3].Value != null)
            {
                first = int.Parse(dgv_fees.Rows[0].Cells[3].Value.ToString());
            }

            if (dgv_fees.Rows[1].Cells[3].Value != null)
            {
                second = int.Parse(dgv_fees.Rows[0].Cells[3].Value.ToString());
            }

            DataGridViewComboBoxCell cell = dgv_fees.Rows[2].Cells[3] as DataGridViewComboBoxCell;
            if (cell.Value != null)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    if (dt2.Rows[i].ItemArray[0].ToString().Equals(dgv_fees.Rows[2].Cells[3].Value))
                    {
                        third = int.Parse(dt2.Rows[i].ItemArray[1].ToString());
                    }
                }
            }

            
            //MessageBox.Show(first + "," + second + "," + third);
            StringBuilder stringBuilder = new StringBuilder();

            for(int i = 0; i < dgv_fees.Rows.Count; i++)
            {
                //MessageBox.Show(stringBuilder.Length + "");
                if (Convert.ToBoolean(dgv_fees.Rows[i].Cells[0].Value))
                {
                    
                    if (stringBuilder.Length > 0)
                    {
                        stringBuilder.Append("," + i);
                    }
                    else
                    {
                        stringBuilder.Append("" + i);
                    }
                }
            }
            MessageBox.Show(stringBuilder.ToString());
        }
    }
}