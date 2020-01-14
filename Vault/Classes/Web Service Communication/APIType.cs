using System.ComponentModel;

namespace Vault.WebServiceCommunication
{
    public enum APIType
    {
        [Description("User")]
        User = 0,

        [Description("VaultData")]
        VaultData = 1
    }
}
