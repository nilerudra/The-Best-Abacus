using AbacusApp.SysBase;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
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
            String que = "Select * from contact_us";
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt);
            dgv_contactUs.DataSource = dt;
            dgv_contactUs.Columns[5].Visible = false;
            dgv_contactUs.Columns[0].Visible = false;
            dgv_contactUs.Columns[7].Visible = false;



            for (int i = 0; i < dgv_contactUs.Rows.Count; i++)
            {
                if (dgv_contactUs.Rows[i].Cells[7].Value.ToString()=="0")
                {
                    dgv_contactUs.Rows[i].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
                else
                {
                    dgv_contactUs.Rows[i].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void dgv_contactUs_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(dt.Rows[e.RowIndex].ItemArray[0].ToString());
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("update contact_us set status = '1' where id = " + id +"" , conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            frmSysShowMsg msg = new frmSysShowMsg();
            msg.GetData(dt);
            msg.ShowDialog();
            msg.Dispose();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frmSysDashboard d = new frmSysDashboard();
            this.Hide();
            d.Show();
        }
    }
}
