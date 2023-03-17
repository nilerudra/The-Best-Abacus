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
    public partial class frmRegStud : Form
    {
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlCommand cmd;
        public frmRegStud()
        {
            InitializeComponent();
        }

        private void frmRegStud_Load(object sender, EventArgs e)
        {

        }

        private void rbtn_female_CheckedChanged(object sender, EventArgs e)
        {

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
            else if(rbtn_other.Checked == true)
            {
                s = "Other";
            }
            
            String que = "INSERT INTO stud_profile (first_name, middle_name, last_name, contact_no, email_id, addr, gender, pwd, branch_id, city_name, current_subscrp_id, status) " +
            "values ('" + txt_firstName.Text + "','" + txt_middleName.Text + "','" + txt_lastName.Text + "','" + txt_contactNo.Text + "','" + txt_email.Text + "','" + txt_addr.Text + "','" + s + "','" + 12345 + "'," + frmSysDashboard.id + ",'" + txt_city.Text + "'," + 1 + ",'" + 1 + "')";
            conn.Open();
            cmd = new MySqlCommand(que, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            String que1 = "Insert into enq_master (name, contact, email, address, status, enq_type, rmk , branch_id) " +
                "values('" + txt_firstName.Text + " " + txt_lastName.Text+"','" + txt_contactNo.Text + "','" + txt_email.Text + "','" + txt_addr.Text + "','" + 1 + "','Offline Enquiry','Admitted by " + frmSysDashboard.name + "'," + frmSysDashboard.id +")";

            cmd = new MySqlCommand(que1, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            this.Close();
        }
    }
}
