namespace VaultCommonLibrary
{
    public class VaultDataObject
    {
        public int RecordNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public VaultDataObject() 
        {
            this.RecordNumber = 0;
        }

        public VaultDataObject(int RecordNumber, string Email, string Username, string Password)
        {
            this.RecordNumber = RecordNumber;
            this.Email = Email;
            this.Password = Password;
            this.Username = Username;
        }
    }
}
