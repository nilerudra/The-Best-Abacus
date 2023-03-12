using AbacusApp.SysBase;
using AbacusApp.UpdateMasters;
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
    public partial class frmAdmission : Form
    {
        DataTable dt = new DataTable();
        int index;
        String gen;
        String remark;
        frmEnquiryFollowup fr;

        public frmAdmission()
        {
            InitializeComponent();
        }

        private void frmAdmission_Load(object sender, EventArgs e)
        {
            String na = dt.Rows[index].ItemArray[1].ToString();
            String[] ar = na.Split(" ");
            txt_fname.Text = ar[0];
            txt_lname.Text = ar[1];
            txt_contact.Text = dt.Rows[index].ItemArray[3].ToString();
            txt_email.Text = dt.Rows[index].ItemArray[4].ToString();
            txt_addr.Text = dt.Rows[index].ItemArray[5].ToString();
            gen = dt.Rows[index].ItemArray[2].ToString();

            DataTable dta = new DataTable();
            string que = "Select name from city_master";
            MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
            //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
            MySqlDataAdapter ad;
            conn.Open();
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dta);
            int i = 0;
            while (i < dta.Rows.Count)
            {
                cmbo_city.Items.Add(dta.Rows[i].ItemArray[0]);
                i++;
            }
            conn.Close();
        }
        public void getData(DataTable dtt, int i, String s, frmEnquiryFollowup e)
        {
            dt = dtt;
            index = i;
            remark = s;
            fr = e;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String que = "Update enq_master set rmk = '" + remark + ", Admitted By " + frmSysDashboard.name + "', status = '1' where id = " + int.Parse(dt.Rows[index].ItemArray[0].ToString());
            String que2 = "INSERT INTO stud_profile (first_name, middle_name, last_name, contact_no, email_id, addr, gender, pwd, branch_id, city_name, current_subscrp_id, status) " +
            "values ('" + txt_fname.Text + "','" + txt_mname.Text + "','" + txt_lname.Text + "','" + txt_contact.Text + "','" + txt_email.Text + "','" + txt_addr.Text + "','" + gen + "','" + 12345 + "'," + frmSysDashboard.profile_id + ",'" + cmbo_city.Text + "'," + 0 + ",'" + 1 + "')";
            
            
            MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
            //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(que, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();


            cmd = new MySqlCommand(que2, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            this.Dispose();
            fr.showStudent();
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new frmSysDashboard().Show();
            this.Hide();
        }
    }
}
