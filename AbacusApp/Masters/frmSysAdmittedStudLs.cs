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
    public partial class frmSysAdmittedStudLs : Form
    {
        MySqlConnection conn = new MySqlConnection("server= 115.96.168.103; port=3306;database=prj130abacus;user=prj130;password=prj130@abacus");
        //MySqlConnection conn = new MySqlConnection("server= localhost; port=3306;database=abacus;user=root;password=nile@064");
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        ListView temp = new ListView();

        public frmSysAdmittedStudLs()
        {
            InitializeComponent();
        }

        public void admittedStud()
        {
            lsv_admittedStud.LargeImageList = imageList1;
            lsv_admittedStud.View = View.LargeIcon;

            if (SysBase.frmSysLogin.usrid == "admin")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem a = new ListViewItem(dt.Rows[i].ItemArray[1].ToString());
                    a.ImageKey = dt.Rows[i].ItemArray[2].ToString() + "_" + dt.Rows[i].ItemArray[4].ToString() + ".png";
                    lsv_admittedStud.Items.Add(a);
                }
            }
            else
            {
                MessageBox.Show("HEllo");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MessageBox.Show(SysBase.frmSysDashboard.name + " " + dt.Rows[i].ItemArray[3].ToString());
                    if (SysBase.frmSysDashboard.name == dt.Rows[i].ItemArray[3].ToString())
                    {
                        ListViewItem a = new ListViewItem(dt.Rows[i].ItemArray[1].ToString());
                        a.ImageKey = dt.Rows[i].ItemArray[2].ToString() + "_" + dt.Rows[i].ItemArray[4].ToString() + ".png";
                        lsv_admittedStud.Items.Add(a);
                    }
                }
            }
            temp.Items.Clear();
            for (int i = 0; i < lsv_admittedStud.Items.Count; i++)
            {
                ListViewItem item = (ListViewItem)lsv_admittedStud.Items[i].Clone();
                temp.Items.Add(item);
            }
        }

        public void ShowBranches()
        {
            if (SysBase.frmSysLogin.usrid == "admin")
            {
                DataTable dtb = new DataTable();
                string que = "Select name from branch_master";
                conn.Open();
                ad = new MySqlDataAdapter(que, conn);
                ad.Fill(dtb);
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    cmbo_branch.Items.Add(dt.Rows[i].ItemArray[0]);
                    i++;
                }
                conn.Close();
            }
            else
            {
                cmbo_branch.Hide();
            }
        }

        private void frmSysAdmittedStudLs_Load(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("Select stud_profile.id,concat(first_name,' ',middle_name,' ',last_name) as name,IF(stud_profile.gender=\"Male\",\"male\",\"female\") as gender, branch_master.name,IF(stud_profile.status=1,\"active\",\"inactive\") as status from stud_profile\r\njoin branch_master on branch_master.id=stud_profile.branch_id", conn);
            ad.Fill(dt);
            ShowBranches();
            
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
            lsv_admittedStud.Items.Clear();
            for(int i = 0; i < temp.Items.Count; i++)
            {
                ListViewItem item = (ListViewItem)temp.Items[i].Clone();
                if (item.Text.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    lsv_admittedStud.Items.Add(item);
                }
            }

        }

        private void btn_promote_Click(object sender, EventArgs e)
        {
            Masters.frmSysPromoteLevel pl = new Masters.frmSysPromoteLevel();
            pl.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            pl.StartPosition = FormStartPosition.CenterParent;
            pl.ShowDialog();
            pl.Dispose();
        }

        private void btn_shift_Click(object sender, EventArgs e)
        {
            Masters.frmSysStudBranchShift shift = new Masters.frmSysStudBranchShift();
            shift.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            shift.StartPosition = FormStartPosition.CenterParent;
            shift.ShowDialog();
            shift.Dispose();
        }
    }
}
