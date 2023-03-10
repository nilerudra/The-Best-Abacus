using AbacusApp.RegMasters;
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

namespace AbacusApp.SysBase
{
    public partial class frmSysBranchList : Form
    {
        bool click = true;  
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        DataTable dt = new DataTable(); 
        public frmSysBranchList()
        {
            InitializeComponent();
        }

        private void frmSysBranchList_Load(object sender, EventArgs e)
        {
            conn.Open();
            ad = new MySqlDataAdapter("Select * from branch_master where status = '" + 1 + "'", conn);
            ad.Fill(dt);
            dgv_BranchList.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }

        private void btn_newBranch_Click(object sender, EventArgs e)
        {
            new frmRegBranch().Show();
            this.Hide();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            (dgv_BranchList.DataSource as DataTable).DefaultView.RowFilter = String.Format("name like '%{0}%' OR city like '%{0}%' OR contact_person like '%{0}%' OR contact_no like '%{0}%' OR contact_email like '%{0}%' OR addr like '%{0}%'", txt_search.Text);
        }

        private void dgv_BranchList_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmSysUpdateBranch up = new frmSysUpdateBranch();
            up.GetData(dt, e.RowIndex);
            this.Hide();
            up.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSysDashboard().Show();
        }
    }
}