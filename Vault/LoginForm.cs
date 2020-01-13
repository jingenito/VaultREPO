using System;
using System.Windows.Forms;
using Vault.WebServiceCommunication;

namespace Vault
{
    public partial class LoginForm : Form
    {
        public EventHandler LoginConfirm;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            var uri = string.Format("/{0}/{1}",username,password);
            var response = WebServiceCom.SubmitBodyToWebService(APIType.User, 
                                                                uri, 
                                                                WebMethod.GET, 
                                                                ContentType.JSON, 
                                                                ContentType.JSON);

            
        }

        protected void OnLoginConfirm()
        {
            if(LoginConfirm != null)
            {
                LoginConfirm(this, new EventArgs());
                this.Close();
            }
        }

        protected void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(btnLogin, new EventArgs());
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.txtUsername.KeyDown += OnKeyDown;
            this.txtPassword.KeyDown += OnKeyDown;
        }
    }
}
