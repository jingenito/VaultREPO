namespace VaultCommonLibrary
{
    public class VaultDataObject
    {
        public int RecordNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public VaultDataObject() 
        {
            this.RecordNumber = 0;
        }

        public VaultDataObject(string Email,string Password,string UserName)
        {
            this.RecordNumber = 0;
            this.Email = Email;
            this.Password = Password;
            this.UserName = UserName;
        }

        public VaultDataObject(int RecordNumber,string Email,string Password,string UserName)
        {
            this.RecordNumber = RecordNumber;
            this.Email = Email;
            this.Password = Password;
            this.UserName = UserName;
        }
    }
}
