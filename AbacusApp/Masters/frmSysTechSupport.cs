using AbacusApp.SysBase;
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
    public partial class frmSysTechSupport : Form
    {
        DataTable dt = new DataTable();
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        MySqlCommand cmd;
        public frmSysTechSupport()
        {
            InitializeComponent();
        }

        public void Show_Table()
        {
            dt.Clear();
            String que = "Select * from tech_support where status = '0'";
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt);
        }
        private void frmSysTechSupport_Load(object sender, EventArgs e)
        {
            Show_Table();
            dgv_techSupport.DataSource = dt;
            dgv_techSupport.Columns[0].Visible = false;
            dgv_techSupport.Columns[1].Visible = false;
            dgv_techSupport.Columns[2].Visible = false;
            dgv_techSupport.Columns[6].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String que = "Insert into tech_support (stud_id, branch_id, msg, status) Values(0," + frmSysDashboard.profile_id + ",'" + txt_msg.Text + "','" + 0 + "')";
            conn.Open();
            cmd = new MySqlCommand(que, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Dispose();
            Show_Table();
        }
    }
}
