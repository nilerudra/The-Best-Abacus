using AbacusApp.SysBase;
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
    public partial class frmSysExams : Form
    {
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public frmSysExams()
        {
            InitializeComponent();
        }

        public void show()
        {
            dt.Clear();
            String que = "Select id, name, subscrp_value from subscrp_master where status = '1'";
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt);
        }

        private void frmSysExams_Load(object sender, EventArgs e)
        {
            show();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbo_levels.Items.Add(dt.Rows[i].ItemArray[1].ToString());
            }

            dgv_Refresh();
        }

        private void dgv_Refresh()
        {
            dt2.Clear();
            ad = new MySqlDataAdapter("select id, first_name, middle_name, last_name, current_subscrp_id from stud_profile where status = '1' and branch_id = '" + frmSysDashboard.profile_id + "'", conn);
            ad.Fill(dt2);
            dgv_Student.DataSource = dt2;
        }

        private void cmbo_levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = cmbo_levels.Text;
            int id = -1;

            if (s.Equals("ALL"))
            {
                dgv_Refresh();
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].ItemArray[1].ToString().Equals(s))
                    {
                        id = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                        break;
                    }
                }

                DataTable data = new DataTable();
                data = dt2.Clone();
                data.Clear();

                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    if (id == int.Parse(dt2.Rows[i].ItemArray[4].ToString()))
                    {
                        DataRow dr = data.NewRow();
                        dr.ItemArray = dt2.Rows[i].ItemArray.Clone() as object[];
                        data.Rows.Add(dr);
                    }
                }
                dgv_Student.DataSource = data;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txt_search.Text.ToLower();

            foreach (DataGridViewRow row in dgv_Student.Rows)
            {
                string cellValue = row.Cells[1].Value.ToString().ToLower();

                if (row.Cells[1].ToString().ToLower().Contains(searchKeyword) || row.Cells[2].ToString().ToLower().Contains(searchKeyword) || row.Cells[3].ToString().ToLower().Contains(searchKeyword))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
    }
}
