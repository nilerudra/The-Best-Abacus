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
            pnl_searchBy.Visible = false;
            rbtn_name.Select();
            conn.Open();
            ad = new MySqlDataAdapter("Select * from branch_master where status = '" + 1 + "'", conn);
            ad.Fill(dt);
            dgv_BranchList.DataSource = dt; 
            conn.Close();
            conn.Dispose();
        }

        private void btn_newBranch_Click_1(object sender, EventArgs e)
        {
            new frmRegBranch().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String s;
            if(rbtn_addr.Checked == true)
            {
                s = "addr";
            }
            else if(rbtn_city.Checked == true)
            {
                s = "city";
            }
            else
            {
                s = "name";
            }
            (dgv_BranchList.DataSource as DataTable).DefaultView.RowFilter = String.Format(s +" like '%" + txt_search.Text + "%'");
        }

        private void dgv_BranchList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_searchBy_Click(object sender, EventArgs e)
        {
            
            if(click)
            {
                pnl_searchBy.Visible = true;
                click = false;
            }
            else
            {
                pnl_searchBy.Visible = false;
                click = true;
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            pnl_searchBy.Visible = false;
        }

        private void dgv_BranchList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmSysUpdateBranch up = new frmSysUpdateBranch();
            up.GetData(dt,e.RowIndex);
            this.Hide();
            up.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}