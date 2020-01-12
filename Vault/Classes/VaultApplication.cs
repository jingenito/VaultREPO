namespace Vault
{
    class VaultApplication : IApplication
    {
        public IUser User { get; set; }

        public VaultApplication()
        {

        }

        public void Login(string UserName, string Password)
        {
            var user = new VaultUser(UserName, Password);
            this.User = user;
        }

        public void Login(IUser user)
        {
            this.User = user;
        }
    }
}
