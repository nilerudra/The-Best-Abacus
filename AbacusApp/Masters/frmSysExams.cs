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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AbacusApp.Masters
{
    public partial class frmSysExams : Form
    {
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        MySqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable data = new DataTable();
        DataTable d = new DataTable();

        String stud_list = "";
        int qp_set = -1;

        public frmSysExams()
        {
            InitializeComponent();
        }

        public void show()
        {
            dt.Clear();
            String que = "select distinct level , qp_type from qp_set_master where status = '1' and qp_type = 'EXAM SET';";
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt);
        }

        private void frmSysExams_Load(object sender, EventArgs e)
        {
            show();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbo_levels.Items.Add(dt.Rows[i].ItemArray[0].ToString());
            }
            
            dgv_Refresh();

            ad = new MySqlDataAdapter("select id, title, level, qp_type from qp_set_master where status = '1' and qp_type = 'EXAM SET'", conn);
            ad.Fill(d);

            for (int i = 0; i < d.Rows.Count; i++)
            {
                cmb_paper_Ls.Items.Add(d.Rows[i].ItemArray[1].ToString());
            }
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
            data.Clear();
            dgv_Refresh();
            txt_search.Text = "";
            stud_list = "";
            String s = cmbo_levels.Text;
            int id = -1;

            cmb_paper_Ls.Text = "";

            if (s.Equals("ALL"))
            {
                dgv_Refresh();
                data = dt2.Clone();
                cmb_paper_Ls.Items.Clear();
                for(int i = 0; i < d.Rows.Count; i++)
                {
                    cmb_paper_Ls.Items.Add(d.Rows[i].ItemArray[1].ToString());
                }
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].ItemArray[0].ToString().Equals(s))
                    {
                        id = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                        break;
                    }
                }
                
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



                cmb_paper_Ls.Items.Clear();
                for(int i = 0; i < d.Rows.Count; i++) 
                {
                    if (s == d.Rows[i].ItemArray[2].ToString())
                    {
                        cmb_paper_Ls.Items.Add(d.Rows[i].ItemArray[1].ToString());
                    }
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            (dgv_Student.DataSource as DataTable).DefaultView.RowFilter = string.Format("first_name LIKE '%{0}%' OR middle_name LIKE '%{0}%' OR last_name LIKE '%{0}%'", txt_search.Text);

            String[] s = stud_list.Split(",");
            
            for(int i = 0; i < dgv_Student.Rows.Count; i++)
            {
                if (s.Contains(dgv_Student.Rows[i].Cells[1].Value.ToString()))
                {
                    dgv_Student.Rows[i].Cells[0].Value = true;
                }
            }

        }

        private void dgv_Student_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed cell is a CheckBox cell
            if (dgv_Student.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                // Get the new value of the cell
                bool isChecked = (bool)dgv_Student[e.ColumnIndex, e.RowIndex].Value;

                // Do something with the new value of the cell
                if (isChecked)
                {
                    // Checkbox is checked
                    if (stud_list.Equals(""))
                    {
                        stud_list = dgv_Student[e.ColumnIndex + 1, e.RowIndex].Value.ToString();
                    }
                    else
                    {
                        if(!stud_list.Contains(dgv_Student[e.ColumnIndex + 1, e.RowIndex].Value.ToString()))
                        {
                            stud_list = stud_list + "," + dgv_Student[e.ColumnIndex + 1, e.RowIndex].Value.ToString();
                        }
                    }
                }
                else
                {
                    // Checkbox is unchecked
                    /*if (!stud_list.Equals(""))
                    {
                        if(stud_list.Contains(dgv_Student[e.ColumnIndex + 1, e.RowIndex].Value.ToString()))
                        {
                            stud_list = stud_list.Replace(dgv_Student[e.ColumnIndex + 1, e.RowIndex].Value.ToString(), "");
                        }
                    }*/
                    if (!stud_list.Equals(""))
                    {
                        string idToRemove = dgv_Student[e.ColumnIndex + 1, e.RowIndex].Value.ToString();
                        string[] ids = stud_list.Split(',');
                        stud_list = string.Join(",", ids.Where(id => !id.Equals(idToRemove)));
                    }
                }
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (qp_set == -1)
            {
                MessageBox.Show("Select Paper");
            }
            else
            {
                conn.Open(); 
                string s = "INSERT INTO exam_details (stud_list, qp_set, status, end_date, reg_usr) VALUES ('" + stud_list.Replace("'", "''") + "', " + qp_set + ", '1', '" + dtp_end_date.Value.ToString("yyyy-MM-dd") + "', " + frmSysDashboard.profile_id + ")";
                cmd = new MySqlCommand(s, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void cmb_paper_Ls_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < d.Rows.Count; i++)
            {
                if (d.Rows[i].ItemArray[1].ToString().Equals(cmb_paper_Ls.Text))
                {
                    qp_set = int.Parse(d.Rows[i].ItemArray[0].ToString());
                }
            }
        }
    }
}