namespace Vault
{
    class VaultUser : IUser
    {
        public string UserName { get; set; } 
        public string Password { get; set; }
        public string Nickname { get; set; }
        public SerializationType PreferredType { get; set; }

        public VaultUser(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Nickname = UserName;
            this.PreferredType = SerializationType.JSON;
        }

        public VaultUser(string UserName, string Password, SerializationType PreferredType)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Nickname = UserName;
            this.PreferredType = PreferredType;
        }

        public VaultUser(string UserName, string Password, string Nickname, SerializationType PreferredType)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Nickname = Nickname;
            this.PreferredType = PreferredType;
        }
    }
}
