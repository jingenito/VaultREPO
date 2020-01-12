namespace VaultCommonLibrary
{
    interface IUser
    {
        string UserName { get; set; }
        string Password { get; set; }
        string Nickname { get; set; }
    }
}
