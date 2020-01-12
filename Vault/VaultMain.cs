using System;
using System.Data;
using System.Windows.Forms;

namespace Vault
{
    public partial class VaultMain : Form
    {
        private DataTable dgvSource { get; set; }

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
            this.Hide();

            var frmLogin = new LoginForm();
            frmLogin.LoginConfirm += OnLoginConfirm;
            frmLogin.ShowDialog();
        }

        protected void OnLoginConfirm(object sender, EventArgs e)
        {
            this.Show();
            LoadData();
        }

        private void AddColsToDT(ref DataTable dt, params string[] cols)
        {
            foreach(string c in cols)
            {
                dt.Columns.Add(c);
            }
        }

        private void SelectFile(Action mode)
        {
            if(mode == Action.Load)
            {
                OpenFileDialog cfd = new OpenFileDialog();
                cfd.Filter = "XML-File | *.xml";
                cfd.FilterIndex = 1;
                cfd.Multiselect = false;

                LoadData(cfd.ShowDialog() == DialogResult.OK ? cfd.FileName : "");
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML-File | *.xml";
                sfd.FilterIndex = 1;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveData(sfd.FileName);
                }
            }
        }

        private void SaveData(string filename)
        {
            var err = false;
            try
            {
                var ds = new DataSet();
                var dt = dgvSource.Copy(); //error if dgvSource belongs to another table
                ds.Tables.Add(dt);
                //ObjectSerializer.EncryptSerialize(ds, filename);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                err = true;
            }
            if (!err) { MessageBox.Show("Save Success"); }
        }

        private void LoadData(string filename = "")
        {
            var dt = new DataTable();
            AddColsToDT(ref dt, "Application", "UserID", "Password");

            if (!string.IsNullOrWhiteSpace(filename))
            {
                try
                {
                    //var ds = ObjectSerializer.DecryptDeserialize(filename);
                    //if(ds.Tables.Count > 0)
                    //{
                    //    dt = ds.Tables[0];
                    //}
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            dgvSource = dt;
            dgv.DataSource = dt;
        }

        protected void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dr = dgv.CurrentRow;
            var app = dr.Cells[0].Value.ToString();
            var user = dr.Cells[1].Value.ToString();
            var pword = dr.Cells[2].Value.ToString();
            if(!string.IsNullOrWhiteSpace(app) && !string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pword))
            {
                var frm = new AddNew();
                frm.Index = dr.Index;
                frm.SetControls(app, user, pword, true);
                frm.Submit += frmAdd_Submit;
                frm.Delete += frmAdd_Delete;
                frm.ShowDialog();
            }
        }

        protected void OnClientSizeChanged(object sender, EventArgs e)
        {
            pnlButtons.Left = (this.ClientSize.Width - pnlButtons.ClientSize.Width) / 2;
            dgv.Top = pnlButtons.ClientSize.Height + 25;
            dgv.Height = this.ClientSize.Height - dgv.Top;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new AddNew();
            frm.Submit += frmAdd_Submit;
            frm.ShowDialog();
        }

        protected void frmAdd_Submit(object sender, AddNewEventArgs e)
        {
            if(e.index <= 0)
            {
                DataRow dr = dgvSource.Rows.Add();
                dr["Application"] = e.AppName;
                dr["UserID"] = e.UserID;
                dr["Password"] = e.Password;
            }
            else
            {
                if(e.index >= dgvSource.Rows.Count) { return; }
                DataRow dr = dgvSource.Rows[e.index];
                if(dr != null)
                {
                    dr["Application"] = e.AppName;
                    dr["UserID"] = e.UserID;
                    dr["Password"] = e.Password;
                }
            }

            dgv.DataSource = dgvSource;
        }

        private void frmAdd_Delete(object sender, AddNewEventArgs e)
        {
            if(e.index < 0 || e.index >= dgvSource.Rows.Count) { return; }
            DataRow dr = dgvSource.Rows[e.index];
            if(dr != null)
            {
                dgvSource.Rows.Remove(dr);
                dgv.DataSource = dgvSource;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dgvSource != null && dgvSource.Rows.Count > 0)
            {
                SelectFile(Action.Save);
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            SelectFile(Action.Load);
        }
    }
}
