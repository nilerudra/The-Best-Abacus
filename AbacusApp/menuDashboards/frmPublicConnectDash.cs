using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbacusApp.menuDashboards
{
    public partial class frmPublicConnectDash : Form
    {
        public frmPublicConnectDash()
        {
            InitializeComponent();
        }

        private void frmPublicConnectDash_Load(object sender, EventArgs e)
        {

        }

        private void btn_admissions_Click(object sender, EventArgs e)
        {
            Masters.frmSysAdmittedStudLs adls = new Masters.frmSysAdmittedStudLs();
            adls.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            adls.StartPosition = FormStartPosition.CenterParent;
            adls.ShowDialog();
            adls.Dispose();
        }

        private void btn_enquiries_Click(object sender, EventArgs e)
        {
            UpdateMasters.frmEnquiryFollowup enq = new UpdateMasters.frmEnquiryFollowup();
            enq.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            enq.StartPosition = FormStartPosition.CenterParent;
            enq.ShowDialog();
            enq.Dispose();
        }

        private void btn_webContacts_Click(object sender, EventArgs e)
        {
            Masters.frmSysContactUs conus = new Masters.frmSysContactUs();
            conus.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            conus.StartPosition = FormStartPosition.CenterParent;
            conus.ShowDialog();
            conus.Dispose();
        }
    }
}
