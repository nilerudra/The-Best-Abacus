using AbacusApp.SysBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class frmSysStudBranchShift : Form
    {
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        int branch;
        DataTable dt1 = new DataTable();
        public frmSysStudBranchShift()
        {
            InitializeComponent();
        }

        public void LoadBranches()
        {
            
            String que = "Select id, name from branch_master where id != " + frmSysDashboard.profile_id + " and status = '1'";
            MessageBox.Show(frmSysDashboard.id + "");

            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt1);
            for(int i = 0; i < dt1.Rows.Count; i++)
                cmbo_branches.Items.Add(dt1.Rows[i].ItemArray[1].ToString());
        }

        private void frmSysStudBranchShift_Load(object sender, EventArgs e)
        {
            String que = "Select * from stud_profile where status = '1' and branch_id =" + frmSysDashboard.profile_id + "";
            
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt);
            dgv_studInfo.DataSource = dt;
            ad.Dispose();
            dgv_studInfo.Columns[1].Visible = false;
            dgv_studInfo.Columns[9].Visible = false;
            dgv_studInfo.Columns[10].Visible = false;
            dgv_studInfo.Columns[11].Visible = false;
            dgv_studInfo.Columns[12].Visible = false;
            dgv_studInfo.Columns[15].Visible = false;

            LoadBranches();
        }

        private void btn_shift_Click(object sender, EventArgs e)
        {
            if (cmbo_branches.SelectedIndex > -1)
            {
                String name = cmbo_branches.Text;

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (name.Equals(dt1.Rows[i].ItemArray[1].ToString()))
                    {
                        branch = int.Parse(dt1.Rows[i].ItemArray[0].ToString());

                    }
                }

                ArrayList ls = new ArrayList();
                for (int i = 0; i < dgv_studInfo.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgv_studInfo.Rows[i].Cells[0].Value))
                    {
                        ls.Add(dgv_studInfo.Rows[i].Cells[1].Value);
                    }
                }

                if (ls.Count > 0)
                {
                    for (int i = 0; i < ls.Count; i++)
                    {
                        String q = "update stud_profile set branch_id = " + branch + " where id = " + ls[i] + "";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(q, conn);
                        cmd.ExecuteNonQuery();
                        conn.Dispose();
                    }

                    MessageBox.Show("Student Shifted");
                }
                else
                {
                    MessageBox.Show("Select students");
                }
            }
            else
            {
                MessageBox.Show("Choose Branch");
            }
        }
    }
}
