using System.ComponentModel;

namespace Vault.WebServiceCommunication
{
    public enum ContentType
    {
        [Description("application/xml")]
        XML = 0,
        [Description("application/json")]
        JSON = XML + 1
    }
}
