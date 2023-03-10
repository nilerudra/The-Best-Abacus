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
    public partial class frmSysContactUs : Form
    {
        DataTable dt = new DataTable();
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        public frmSysContactUs()
        {
            InitializeComponent();
        }

        private void frmSysContactUs_Load(object sender, EventArgs e)
        {
            String que = "Select name, email, contact, subject, reg_date from contact_us where status = '0'";
            conn.Open();
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt);
            dgv_contactUs.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }

        private void dgv_contactUs_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Hide();
            frmSysShowMsg msg = new frmSysShowMsg();
            msg.GetData(dt);
            msg.Show();
        }
    }
}
