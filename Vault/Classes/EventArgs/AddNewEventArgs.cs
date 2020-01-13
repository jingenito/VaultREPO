using System;

namespace Vault
{
    public class AddNewEventArgs : EventArgs
    {
        public int index { get; set; }
        public string AppName { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        
        public AddNewEventArgs(int index, string AppName, string UserID, string Password)
        {
            this.index = index;
            this.AppName = AppName;
            this.UserID = UserID;
            this.Password = Password;
        }
    }
}
