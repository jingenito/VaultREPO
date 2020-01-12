namespace Vault
{
    interface IApplication
    {
        IUser User { get; set; }
        void Login(string UserName, string Password);

    }
}
