using AbacusApp.RegMasters;
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
    public partial class frmEnquiryFollowup : Form
    {
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        int index;
        public frmEnquiryFollowup()
        {
            InitializeComponent();
        }

        private void frmEnquiryFollowup_Load(object sender, EventArgs e)
        {
            pnl_update.Visible = false;
            showStudent();
        }

        public void showStudent()
        {
            dt.Clear();
            String que = "Select id, name, gender, contact, email, address, rmk from enq_master where status = '" + 0 + "'";

            conn.Open();
            ad = new MySqlDataAdapter(que, conn);
            ad.Fill(dt);
            dgv_enqList.DataSource = dt;
            conn.Close();
            dgv_enqList.Columns[0].Visible = false;

            txt_contactNo.Text = "";
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            txt_rmk.Text = "";
        }


        private void dgv_enqList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String rmk = dt.Rows[e.RowIndex].ItemArray[6].ToString();
            pnl_update.Visible = true;
            String na = dt.Rows[e.RowIndex].ItemArray[1].ToString();
            String[] ar = na.Split(" ");
            txt_firstName.Text = ar[0];
            txt_lastName.Text = ar[1];
            txt_contactNo.Text = dt.Rows[e.RowIndex].ItemArray[3].ToString();
            index = e.RowIndex;
            if(rmk.Length > 0)
            {
                txt_rmk.Text = rmk + ", ";
            }
            else
            {
                txt_rmk.Text = "";
            }
        }

        private void chbox_notIntretsed_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbox_notIntretsed.Checked == true)
            {
                dtp_nextFollowupDate.Enabled = false;
                btn_procced.Enabled = false;
            }
            else if (chbox_notIntretsed.Checked == false)
            {
                dtp_nextFollowupDate.Enabled = true;
                btn_procced.Enabled = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            String que;
            DateTime d = new DateTime(dtp_nextFollowupDate.Value.Date.Ticks);
            String da = d.ToShortDateString().ToString();

            int ids = int.Parse(dt.Rows[index].ItemArray[0].ToString());
            String s = dt.Rows[index].ItemArray[6].ToString();


            if (chbox_notIntretsed.Checked == true)
            {
                que = "Update enq_master set status ='" + 2 + "' where id = " + ids + "";
            }
            else
            {
                que = "update enq_master set next_follow_up='" + dtp_nextFollowupDate.Text + "', rmk = '" + txt_rmk.Text + "' where id =" + ids + "";
            }

            conn.Open();
            cmd = new MySqlCommand(que, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            showStudent();
        }

        private void btn_procced_Click(object sender, EventArgs e)
        {
            if (dt.Rows[index].ItemArray[6].ToString().Equals(""))
            {
                txt_rmk.Text = "";
            }

            frmAdmission fd = new frmAdmission();
            fd.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            fd.StartPosition = FormStartPosition.CenterParent;
            fd.getData(dt, index, txt_rmk.Text);
            fd.ShowDialog();
            fd.Dispose();
        }

        private void dgv_enqList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_enquiry_Click(object sender, EventArgs e)
        {
            frmRegEnquiry enquiry = new frmRegEnquiry();
            enquiry.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            enquiry.StartPosition = FormStartPosition.CenterParent;
            enquiry.ShowDialog();
            enquiry.Dispose();
        }
    }
}
