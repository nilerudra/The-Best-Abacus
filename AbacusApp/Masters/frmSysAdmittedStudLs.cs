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
    public partial class frmSysAdmittedStudLs : Form
    {
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        ListView temp;

        public frmSysAdmittedStudLs()
        {
            InitializeComponent();
        }

        public void admittedStud()
        {
            lsv_admittedStud.LargeImageList = imageList1;
            lsv_admittedStud.View = View.LargeIcon;
//            bool flag = true;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //if (dt.Rows[i].ItemArray[6].ToString() == "1" && dt.Rows[i].ItemArray[4].ToString() == "Male")
                //{
                //    String name = dt.Rows[i].ItemArray[1].ToString() + " " + dt.Rows[i].ItemArray[2].ToString() + " " + dt.Rows[i].ItemArray[3].ToString();
                //    lsv_admittedStud.Items.Add(new ListViewItem(name, 2));
                //    flag = false;
                //}
                //else
                //{
                //    String name = dt.Rows[i].ItemArray[1].ToString() + " " + dt.Rows[i].ItemArray[2].ToString() + " " + dt.Rows[i].ItemArray[3].ToString();
                //    lsv_admittedStud.Items.Add(new ListViewItem(name, 3));
                //    flag = false;
                //}

                //if (dt.Rows[i].ItemArray[6].ToString() == "1" && dt.Rows[i].ItemArray[4].ToString() == "Female")
                //{
                //    String name = dt.Rows[i].ItemArray[1].ToString() + " " + dt.Rows[i].ItemArray[2].ToString() + " " + dt.Rows[i].ItemArray[3].ToString();
                //    lsv_admittedStud.Items.Add(new ListViewItem(name, 0));
                //}

                //else if(flag)
                //{
                //    String name = dt.Rows[i].ItemArray[1].ToString() + " " + dt.Rows[i].ItemArray[2].ToString() + " " + dt.Rows[i].ItemArray[3].ToString();
                //    lsv_admittedStud.Items.Add(new ListViewItem(name, 1));
                //}

                ListViewItem a = new ListViewItem(dt.Rows[i].ItemArray[1].ToString());
                a.ImageKey = dt.Rows[i].ItemArray[2].ToString() + "_" + dt.Rows[i].ItemArray[4].ToString() + ".png";
                lsv_admittedStud.Items.Add(a);
            }
            temp = lsv_admittedStud;
        }

        private void frmSysAdmittedStudLs_Load(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("Select stud_profile.id,concat(first_name,' ',middle_name,' ',last_name) as name,IF(stud_profile.gender=\"Male\",\"male\",\"female\") as gender, branch_master.name,IF(stud_profile.status=1,\"active\",\"inactive\") as status from stud_profile\r\njoin branch_master on branch_master.id=stud_profile.branch_id", conn);
            ad.Fill(dt);
            admittedStud();

        }

        private void btn_newAdmission_Click(object sender, EventArgs e)
        {
            RegMasters.frmRegStud stud = new RegMasters.frmRegStud();
            stud.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            stud.StartPosition = FormStartPosition.CenterParent;
            stud.ShowDialog();
            stud.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListView listView = lsv_admittedStud;
            //MessageBox.Show(listView.Items[1].Text);
            listView.Items.Clear();
            
            foreach (ListViewItem item in temp.Items)
            {
                MessageBox.Show(item.Text.ToLower()+"   "+ textBox1.Text.ToLower());

                if (item.Text.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    MessageBox.Show(item.Text.ToLower());
                    listView.Items.Add(item);
                    //MessageBox.Show(item.Text);
                }
            }
            lsv_admittedStud.Clear();
            lsv_admittedStud = listView;
        }
    }
}
