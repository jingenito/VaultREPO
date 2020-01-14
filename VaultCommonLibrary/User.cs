namespace VaultCommonLibrary
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }

        public User() { }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public User(string Username, string Password,string Nickname)
        {
            this.Username = Username;
            this.Password = Password;
            this.Nickname = Nickname;
        }
    }
}
