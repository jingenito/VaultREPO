namespace VaultCommonLibrary
{
    public interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }
        string Nickname { get; set; }
    }
}
