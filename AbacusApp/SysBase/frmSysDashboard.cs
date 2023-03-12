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
        public static int profile_id;
        public frmSysDashboard()
        {
            InitializeComponent();
        }

        public void GetData(DataTable dttt)
        {
            dt = dttt;
            id = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            name = dt.Rows[0]["Name"].ToString();
            profile_id = int.Parse(dt.Rows[0].ItemArray[3].ToString());
            lbl_name.Text = name;
        }
        private void frmSysDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_branches_Click(object sender, EventArgs e)
        {
            frmSysBranchList bls = new frmSysBranchList();
            bls.ShowDialog();
            bls.Dispose();
        }

        private void btn_enquiry_Click(object sender, EventArgs e)
        {
            //new RegMasters.frmRegStud().Show();
            //new RegMasters.frmRegEnquiry().Show();
            frmEnquiryFollowup up = new frmEnquiryFollowup();
            up.ShowDialog();
            up.Dispose();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_techSupport_Click(object sender, EventArgs e)
        {
            frmSysTechSupport btech = new frmSysTechSupport();
            btech.ShowDialog();
            btech.Dispose();
        }

        private void btn_competition_Click(object sender, EventArgs e)
        {
            new frmRegStud().Show();
            this.Hide();

        }

        private void btn_testSerise_Click(object sender, EventArgs e)
        {
            frmRegEnquiry rstud = new frmRegEnquiry();
            rstud.ShowDialog();
            rstud.Dispose();
        }

        private void btn_publicConnect_Click(object sender, EventArgs e)
        {
            frmSysContactUs a=new frmSysContactUs();
            a.ShowDialog();
            a.Dispose();
        }

        private void btn_notification_Click(object sender, EventArgs e)
        {
            frmSysStudBranchShift shift = new frmSysStudBranchShift();
            shift.ShowDialog();
            shift.Dispose();
        }

        private void btn_transaction_Click(object sender, EventArgs e)
        {
            frmSysPromoteLevel f = new frmSysPromoteLevel();
            f.ShowDialog();
            f.Dispose();
        }

        private void btn_exams_Click(object sender, EventArgs e)
        {
            frmSysBranchSupport bsup = new frmSysBranchSupport();
            bsup.ShowDialog();  
            bsup.Dispose();
        }
    }
}
