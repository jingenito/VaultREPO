using System;
using System.Windows.Forms;

namespace Vault
{
    public partial class AddNew : Form
    {
        public delegate void SubmitEventHandler(object sender, AddNewEventArgs e);
        public SubmitEventHandler Submit;
        public SubmitEventHandler Delete;

        public int Index { get; set; }

        public AddNew()
        {
            InitializeComponent();
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            lblValid.Text = "";

            txtApp.KeyDown += OnKeyDown;
            txtUser.KeyDown += OnKeyDown;
            txtPassword.KeyDown += OnKeyDown;
        }

        public void SetControls(string AppName, string UserID, string Password, bool ShowDeleteButton = false)
        {
            txtApp.Text = AppName;
            txtUser.Text = UserID;
            txtPassword.Text = Password;
            btnDelete.Visible = ShowDeleteButton;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtApp.Text) && !string.IsNullOrWhiteSpace(txtUser.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                OnSubmit(txtApp.Text, txtUser.Text, txtPassword.Text);
            }
            else
            {
                lblValid.Text = "All fields are required.";
            }
        }
        
        protected void OnSubmit(string AppName, string UserID, string Password)
        {
            if(Submit != null)
            {
                Submit(this, new AddNewEventArgs(Index, AppName, UserID, Password));
                this.Close();
            }
        }

        protected void OnDelete()
        {
            if(Delete != null)
            {
                Delete(this, new AddNewEventArgs(Index, "", "", ""));
                this.Close();
            }
        }

        protected void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(btnSubmit, new EventArgs());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnDelete();
        }
    }
}
