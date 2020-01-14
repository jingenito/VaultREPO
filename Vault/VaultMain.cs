using System;
using System.Data;
using System.Windows.Forms;

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
        }

        private void ConfigureDGV()
        {
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
