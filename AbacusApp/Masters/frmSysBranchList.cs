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
            ad = new MySqlDataAdapter("select id, name, city, contact_person, contact_no, contact_email, IF(status='1', \"active\",\"inactive\") as status, addr from branch_master", conn);
            ad.Fill(dt);
            ShowBranch();
        }

        public void ShowBranch()
        {
            lsv_branchLs.LargeImageList = imageList1;
            lsv_branchLs.View = View.LargeIcon;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem a = new ListViewItem(dt.Rows[i].ItemArray[1].ToString());
                a.ImageKey = "branch_" + dt.Rows[i].ItemArray[6].ToString() + ".png";
                lsv_branchLs.Items.Add(a);
            }
        }

        private void btn_newBranch_Click(object sender, EventArgs e)
        {
            frmRegBranch freg = new frmRegBranch();
            freg.ShowDialog();
            freg.Dispose();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void dgv_BranchList_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmSysUpdateBranch up = new frmSysUpdateBranch();
            up.GetData(dt, e.RowIndex);
            this.Hide();
            up.Show();
        }
    }
}