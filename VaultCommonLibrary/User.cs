namespace VaultCommonLibrary
{
    public class User : IUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }

        public User() { }

        public User(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Nickname = UserName;
        }

        public User(string UserName, string Password,string Nickname)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Nickname = Nickname;
        }
    }
}
