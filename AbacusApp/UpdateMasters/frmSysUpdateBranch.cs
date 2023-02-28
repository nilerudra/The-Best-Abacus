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

namespace AbacusApp.UpdateMasters
{
    public partial class frmSysUpdateBranch : Form
    {
        String ids;
        MySqlCommand cmd;
        DataTable dt = new DataTable();
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;


        int index;
        public void GetData(DataTable dtt,int ind)
        {
            dt = dtt;
            index = ind;
        }
        public frmSysUpdateBranch()
        {
            InitializeComponent();
        }

        private void frmSysUpdateBranch_Load(object sender, EventArgs e)
        {
            ids = dt.Rows[index].ItemArray[0].ToString();
            txt_name.Text = dt.Rows[index].ItemArray[1].ToString();
            cmbo_city.Text = dt.Rows[index].ItemArray[2].ToString();
            txt_contactPersonName.Text = dt.Rows[index].ItemArray[3].ToString();
            txt_contact.Text = dt.Rows[index].ItemArray[4].ToString();
            txt_email.Text = dt.Rows[index].ItemArray[5].ToString();
            txt_addr.Text = dt.Rows[index].ItemArray[8].ToString();

            if(dt.Rows[index].ItemArray[7].ToString() == "1")
            {
                cmbo_status.Text = "Active";
            }
            else
            {
                cmbo_status.Text = "Inactive";
            }


            string que = "Select name from city_master";
            DataTable dt1 = new DataTable();
            conn.Open();
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt1);
            int i = 0;
            while (i < dt1.Rows.Count)
            {
                cmbo_city.Items.Add(dt1.Rows[i].ItemArray[0]);
                i++;
            }
            conn.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sts;
            if(cmbo_status.Text == "Active")
            {
                sts = "1";
            }
            else
            {
                sts = "0";
            }
            String que = "Update branch_master set name = '" + txt_name.Text + "',city = '" + cmbo_city.Text + "', contact_person = '" + txt_contactPersonName.Text + 
                         "', contact_email = '" + txt_email.Text + "', addr = '" + txt_addr.Text + "', status = '" + sts + "' where id = " + int.Parse(dt.Rows[index].ItemArray[0].ToString()) + "";
            String que1 = "Update lgn_master set name = '" + txt_contactPersonName.Text + "', status = " + sts + " where profile_id = '" + ids + "'";
            
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(que, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            cmd = new MySqlCommand(que1, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            MessageBox.Show("Done");
            this.Hide();
            new frmSysBranchList().Show();
        }
    }
}
