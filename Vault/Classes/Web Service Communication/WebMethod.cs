using System.ComponentModel;

namespace Vault.WebServiceCommunication
{
    public enum WebMethod
    {
        [Description("GET")]
        @GET = 0,
        [Description("POST")]
        POST = GET + 1
    }
}
