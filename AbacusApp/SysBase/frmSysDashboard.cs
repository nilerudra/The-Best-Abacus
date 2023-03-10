using AbacusApp.Masters;
using AbacusApp.RegMasters;
using AbacusApp.UpdateMasters;
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
    public partial class frmSysDashboard : Form
    {
        DataTable dt = new DataTable();
        public static int id;
        public static String name;
        public frmSysDashboard()
        {
            InitializeComponent();
        }

        public void GetData(DataTable dttt)
        {
            dt = dttt;
            id = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            name = dt.Rows[0]["Name"].ToString();
            lbl_name.Text = name;
        }
        private void frmSysDashboard_Load(object sender, EventArgs e)
        {

        }

        private void createBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSysBranchList().Show();
            this.Hide();
        }

        private void btn_branches_Click(object sender, EventArgs e)
        {
            new frmSysBranchList().Show();
            this.Hide();
        }

        private void btn_enquiry_Click(object sender, EventArgs e)
        {
            //new RegMasters.frmRegStud().Show();
            //new RegMasters.frmRegEnquiry().Show();
            new frmEnquiryFollowup().Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_techSupport_Click(object sender, EventArgs e)
        {

        }

        private void btn_competition_Click(object sender, EventArgs e)
        {
            new frmRegStud().Show();
            this.Hide();

        }

        private void btn_testSerise_Click(object sender, EventArgs e)
        {
            new frmRegEnquiry().Show();
            this.Hide();
        }

        private void btn_publicConnect_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSysContactUs().Show();
        }
    }
}
