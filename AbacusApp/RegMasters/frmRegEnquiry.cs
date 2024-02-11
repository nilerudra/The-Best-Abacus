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
    public partial class frmRegEnquiry : Form
    {
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlCommand cmd;
        public frmRegEnquiry()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            String s = "";
            if (rbtn_male.Checked == true)
            {
                s = "Male";
            }
            else if (rbtn_female.Checked == true)
            {
                s = "Female";
            }
            else if (rbtn_other.Checked == true)
            {
                s = "Other";
            }

            String name = txt_name.Text.Trim() + " " + txt_lastName.Text.Trim();

            String que1 = "Insert into enq_master (name, contact, email, address, status, enq_type, branch_id,gender) " +
            "values('" + name + "','" + txt_contactNo.Text + "','" + txt_email.Text + "','" + txt_addr.Text+ "','" + 0 + "','Offline Enquiry'," + frmSysDashboard.profile_id + ",'" + s + "')";
            conn.Open();
            cmd = new MySqlCommand(que1, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            this.Dispose();
        }

        private void lbl_gender_Click(object sender, EventArgs e)
        {

        }

        private void frmRegEnquiry_Load(object sender, EventArgs e)
        {

        }
    }
}
