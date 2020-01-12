namespace Vault
{
    interface IUser
    {
        string UserName { get; set; }
        string Password { get; set; }
        string Nickname { get; set; }
        SerializationType PreferredType { get; set; }
    }
}
