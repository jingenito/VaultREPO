using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vault.WebServiceCommunication;

namespace Vault
{
    public partial class VaultMain : Form
    {
        public VaultMain()
        {
            InitializeComponent();
        }

        private void VaultMain_Load(object sender, EventArgs e)
        {
            ConfigureDGV();
            var colsToHide = new List<string>(new string[] { "RecordNumber" });

            var dSource = WebServiceCom.SendLoadInfoRequest();
            dgv.DataSource = dSource;

            foreach(DataGridViewColumn col in dgv.Columns)
            {
                col.Visible = !colsToHide.Contains(col.Name);
            }
        }

        private void ConfigureDGV()
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoGenerateColumns = false;

            var cols = new string[]{ "Email","Password","UserName"};
            foreach(var c in cols)
            {
                dgv.Columns.Add(c,c);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new AddNew();
            frm.ShowDialog();
        }
    }
}
