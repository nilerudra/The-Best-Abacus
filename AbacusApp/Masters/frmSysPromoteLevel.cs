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
    public partial class frmSysPromoteLevel : Form
    {
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public frmSysPromoteLevel()
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

        private void frmSysPromoteLevel_Load(object sender, EventArgs e)
        {
            show();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbo_levels.Items.Add(dt.Rows[i].ItemArray[1].ToString());
            }

            Refresh();

        }

        public void Refresh()
        {
            String que = "Select * from stud_profile where status = '1' and branch_id =" + frmSysDashboard.profile_id + "";
            dt2.Clear();
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt2);
            dgv_Student.DataSource = dt2;
            ad.Dispose();
            dgv_Student.Columns[1].Visible = false;
            dgv_Student.Columns[9].Visible = false;
            dgv_Student.Columns[10].Visible = false;
            dgv_Student.Columns[11].Visible = false;
            dgv_Student.Columns[12].Visible = false;
            dgv_Student.Columns[15].Visible = false;
        }

        private void cmbo_levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
            cmb_Promote.Items.Clear();
            cmb_Promote.Text = "";
            int index = cmbo_levels.SelectedIndex;
            DataTable dt3 = new DataTable();
            dt3 = dt2.Clone();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i != index)
                {
                    cmb_Promote.Items.Add(dt.Rows[i].ItemArray[1].ToString());
                }
            }
            dt3.Clear();
            int a = 0;
            for(int i = 0; i < dt2.Rows.Count; i++)
            {
                //MessageBox.Show(dt2.Rows[i].ItemArray[13].ToString() + " " + cmbo_levels.SelectedIndex + 2);
                if(int.Parse(dt2.Rows[i].ItemArray[13].ToString()) == cmbo_levels.SelectedIndex + 1)
                {
                    DataRow newRow = dt3.NewRow();
                    newRow.ItemArray = dt2.Rows[a].ItemArray.Clone() as object[];
                    dt3.Rows.Add(newRow);
                    a++;
                }
            }
            dgv_Student.DataSource = dt3;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList ls = new ArrayList();
            for (int i = 0; i < dgv_Student.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv_Student.Rows[i].Cells[0].Value))
                {
                    ls.Add(dgv_Student.Rows[i].Cells[1].Value);
                }
            }

            if(ls.Count > 0)
            {
                for(int i = 0; i < ls.Count; i++)
                {
                    String q = "Update stud_profile set current_subscrp_id = '" + cmb_Promote.SelectedIndex + 2 + "' where id = "+ ls[i] + "";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    conn.Dispose();
                }
                cmbo_levels.Text = "";
                cmb_Promote.Text = "";
                Refresh();
                MessageBox.Show("Student Promoted");
            }
            else
            {
                MessageBox.Show("Select Student");
            }
        }
    }
}