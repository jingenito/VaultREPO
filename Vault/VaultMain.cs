using System;
using System.Data;
using System.Windows.Forms;

namespace Vault
{
    public partial class VaultMain : Form
    {
        private enum Action
        {
            Load,
            Save
        }

        public VaultMain()
        {
            InitializeComponent();
        }

        private void VaultMain_Load(object sender, EventArgs e)
        {
           
        }

        protected void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var dr = dgv.CurrentRow;
            //var app = dr.Cells[0].Value.ToString();
            //var user = dr.Cells[1].Value.ToString();
            //var pword = dr.Cells[2].Value.ToString();
            //if(!string.IsNullOrWhiteSpace(app) && !string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pword))
            //{
            //    var frm = new AddNew();
            //    frm.Index = dr.Index;
            //    frm.SetControls(app, user, pword, true);
            //    frm.Submit += frmAdd_Submit;
            //    frm.Delete += frmAdd_Delete;
            //    frm.ShowDialog();
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new AddNew();
            frm.Submit += frmAdd_Submit;
            frm.ShowDialog();
        }

        protected void frmAdd_Submit(object sender, AddNewEventArgs e)
        {
            //if(e.index <= 0)
            //{
            //    DataRow dr = dgvSource.Rows.Add();
            //    dr["Application"] = e.AppName;
            //    dr["UserID"] = e.UserID;
            //    dr["Password"] = e.Password;
            //}
            //else
            //{
            //    if(e.index >= dgvSource.Rows.Count) { return; }
            //    DataRow dr = dgvSource.Rows[e.index];
            //    if(dr != null)
            //    {
            //        dr["Application"] = e.AppName;
            //        dr["UserID"] = e.UserID;
            //        dr["Password"] = e.Password;
            //    }
            //}

            //dgv.DataSource = dgvSource;
        }

        private void frmAdd_Delete(object sender, AddNewEventArgs e)
        {
            //if(e.index < 0 || e.index >= dgvSource.Rows.Count) { return; }
            //DataRow dr = dgvSource.Rows[e.index];
            //if(dr != null)
            //{
            //    dgvSource.Rows.Remove(dr);
            //    dgv.DataSource = dgvSource;
            //}
        }
    }
}
