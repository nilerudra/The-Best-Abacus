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
    public partial class frmSysBranchSupport : Form
    {
        DataTable dt = new DataTable();
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        MySqlCommand cmd;
        public frmSysBranchSupport()
        {
            InitializeComponent();
        }
        public void Show_Table()
        {
            dt.Clear();
            String que = "Select * from branch_support where status = '0'";
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt);
            txt_msg.Text = "";
        }

        private void frmSysBranchSupport_Load(object sender, EventArgs e)
        {
            Show_Table();
            dgv_branchSupport.DataSource = dt;
            dgv_branchSupport.Columns[0].Visible = false;
            dgv_branchSupport.Columns[1].Visible = false;
            dgv_branchSupport.Columns[2].Visible = false;
            dgv_branchSupport.Columns[5].Visible = false;
            dgv_branchSupport.Columns[7].Visible = false;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            String que = "Insert into branch_support (stud_id, branch_id, msg, status) Values(0," + frmSysDashboard.profile_id + ",'" + txt_msg.Text + "','" + 0 + "')";
            conn.Open();
            cmd = new MySqlCommand(que, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Dispose();
            Show_Table();
        }
    }
}
