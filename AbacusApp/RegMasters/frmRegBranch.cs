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

namespace AbacusApp.RegMasters
{
    public partial class frmRegBranch : Form
    {
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        MySqlCommand cmd;
        DataTable dt = new DataTable();
        public frmRegBranch()
        {
            InitializeComponent();
        }


        private void frmRegBranch_Load(object sender, EventArgs e)
        {
            string que = "Select name from city_master";
            conn.Open();
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt);
            int i = 0;
            while (i < dt.Rows.Count)
            {
                cmbo_city.Items.Add(dt.Rows[i].ItemArray[0]);
                i++;
            }
            conn.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSysBranchList().Show();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            String que = "Insert into branch_master (name,city,contact_person,contact_no,contact_email,addr,status) values('" + txt_name.Text + "','" + cmbo_city.Text + "','" + txt_contactPersonName.Text + "','" + txt_ContactNo.Text + "','" + txt_email.Text + "','" + txt_addr.Text + "'," + 1 + ")";
            String que1 = "Insert into lgn_master (name, role, usrid, pwd, profile_id, status) values('" + txt_contactPersonName.Text + "','" + 1 + "','" + txt_ContactNo.Text + "','" + 123 + "'," + "(Select count(*) from branch_master)" + ",'" + 1 +"')";
            conn.Open();
            cmd = new MySqlCommand(que,conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Branch Created");

            cmd = new MySqlCommand(que1, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Lgn info inserted");
            conn.Close();
            
            conn.Dispose();
            this.Hide();
            new frmSysBranchList().Show();
        }
    }
}
