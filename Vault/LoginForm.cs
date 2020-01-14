using System;
using System.Windows.Forms;
using Vault.WebServiceCommunication;

namespace Vault
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            var user = WebServiceCom.SendLoginRequest(username, password);
            if (user == null)
            {
                MessageBox.Show("Incorrect login information.");
            }
            else
            {
                //set Global User
                GlobalAppInfo.User = user;

                var frm = new VaultMain();
                frm.WindowState = FormWindowState.Maximized;
                frm.StartPosition = FormStartPosition.WindowsDefaultLocation;
                frm.FormClosed += OnVaultMain_FormClosed;
                frm.ShowDialog();
            }
        }

        protected void OnVaultMain_FormClosed(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();
        }

        protected void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(btnLogin, new EventArgs());
            }
        }
    }
}
