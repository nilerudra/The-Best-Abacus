using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace AbacusApp.SysBase
{
    public partial class frmSysLogin : Form
    {
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        public frmSysLogin()
        {
            InitializeComponent();
        }

        private void frmSysLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_lgn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                String que = "Select id, name, role, profile_id from lgn_master where usrid = '" + txt_user.Text + "'" + "and pwd = '" + txt_pwd.Text + "' and status = '" + 1 + "'";
                ad = new MySqlDataAdapter(que, conn);
                ad.Fill(dt);

                

                if (dt.Rows.Count > 0)
                {
                    frmSysDashboard fd = new frmSysDashboard();
                    fd.GetData(dt);
                    this.Hide();
                    fd.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password !");
                }
            }
            catch (MySqlException sqe)
            {
                MessageBox.Show("Internet Connection Error!! \n Please Connect To Internet.", "Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
