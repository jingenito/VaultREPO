namespace VaultCommonLibrary
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }

        public User() { }

        public User(int Id, string Username, string Password)
        {
            this.Id = Id;
            this.Username = Username;
            this.Password = Password;
        }

        public User(int Id, string Username, string Password,string Nickname)
        {
            this.Id = Id;
            this.Username = Username;
            this.Password = Password;
            this.Nickname = Nickname;
        }
    }
}
