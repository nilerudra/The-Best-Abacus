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
    public partial class frmSysShowMsg : Form
    {
        DataTable dt;
        public void GetData(DataTable d)
        {
            dt = d;
        }
        public frmSysShowMsg()
        {
            InitializeComponent();
        }

        private void frmSysShowMsg_Load(object sender, EventArgs e)
        {
            txt_name.Text = dt.Rows[0].ItemArray[0].ToString();
            txt_subject.Text = dt.Rows[0].ItemArray[1].ToString();
            txt_msg.Text = dt.Rows[0].ItemArray[2].ToString();
        }
    }
}
