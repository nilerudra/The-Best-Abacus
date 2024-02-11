﻿using AbacusApp.Masters;
using AbacusApp.RegMasters;
using AbacusApp.UpdateMasters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbacusApp.SysBase
{
    public partial class frmSysDashboard : Form
    {
        DataTable dt = new DataTable();
        public static int id;
        public static String name;
        public static int profile_id;

        public frmSysDashboard()
        {
            InitializeComponent();
        }

        public void GetData(DataTable dttt)
        {
            dt = dttt;
            id = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            name = dt.Rows[0].ItemArray[2].ToString();
            profile_id = int.Parse(dt.Rows[0].ItemArray[1].ToString());
            
        }
        private void frmSysDashboard_Load(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_publicConnect_Click_1(object sender, EventArgs e)
        {
            menuDashboards.frmPublicConnectDash a = new menuDashboards.frmPublicConnectDash();
            a.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            a.StartPosition = FormStartPosition.CenterParent;
            a.ShowDialog();
            a.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmSysBranchList bl = new frmSysBranchList();
            bl.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            bl.StartPosition = FormStartPosition.CenterParent;
            bl.ShowDialog();
            bl.Dispose();
        }

        private void btn_trans_Click(object sender, EventArgs e)
        {
            Masters.frmSystransactiion trac = new Masters.frmSystransactiion();
            trac.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            trac.StartPosition = FormStartPosition.CenterParent;
            trac.ShowDialog();
            trac.Dispose();
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            Masters.frmSysExams exam = new Masters.frmSysExams();
            exam.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            exam.StartPosition = FormStartPosition.CenterParent;
            exam.ShowDialog();
            exam.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Masters.frmSysComp comp = new Masters.frmSysComp();
            comp.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            comp.StartPosition = FormStartPosition.CenterParent;
            comp.ShowDialog();
            comp.Dispose();
        }
    }
}