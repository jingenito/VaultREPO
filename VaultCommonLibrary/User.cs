using VaultCommonLibrary.Interfaces;

namespace VaultCommonLibrary
{
    public class User : IUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }
    }
}
