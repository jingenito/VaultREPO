using System;
using System.IO;
using System.Net;
using System.Text;
using VaultCommonLibrary;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Vault.WebServiceCommunication
{
    public class WebServiceCom
    {
        private const string Scheme = "https";
        private const string Host = "localhost";
        private const bool UsePortNumber = true;
        private const int Port = 44306; //localhost port for the web service

        private static Uri APIMapper(APIType api)
        {
            var uBuilder = new UriBuilder();
            uBuilder.Scheme = Scheme;
            uBuilder.Host = Host;
            if (UsePortNumber)
            {
                uBuilder.Port = Port;
            }

            uBuilder.Path = "api/" + api.Description();
            return uBuilder.Uri;
        }

        private static string SubmitRequestToWebService(APIType api,
                                                    string uri,
                                                    WebMethod method,
                                                    ContentType contentType,
                                                    string data = "")
        {
            return SubmitRequestToWebService(api, uri, method, contentType, contentType, data);
        }

        private static string SubmitRequestToWebService(APIType api,
                                              string uri,
                                              WebMethod method,
                                              ContentType contentType,
                                              ContentType acceptType,
                                              string data = "")
        {
            var uBuilder = new UriBuilder(APIMapper(api));
            uBuilder.Path += uri;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //3072
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uBuilder.Uri);

            if (GlobalAppInfo.User != null)
            {
                var auth = string.Format("{0}:{1}", GlobalAppInfo.User.Username, GlobalAppInfo.User.Password);
                var enc = Convert.ToBase64String(Encoding.ASCII.GetBytes(auth));
                var cred = string.Format("{0} {1}", "Basic", enc);

                request.Headers.Add("Authorization", cred);
            }

            request.Method = method.Description();
            request.Accept = acceptType.Description();
            request.ContentType = contentType.Description();
            if (method == WebMethod.POST && !string.IsNullOrWhiteSpace(data))
            {
                var edata = Encoding.ASCII.GetBytes(data);
                request.ContentLength = edata.Length;
                using (var stm = request.GetRequestStream())
                {
                    stm.Write(edata, 0, edata.Length);
                }
            }

            var response = "";
            try
            {
                using (var responseStm = request.GetResponse().GetResponseStream())
                {
                    using (var sReader = new StreamReader(responseStm))
                    {
                        response = sReader.ReadToEnd();
                    }
                }
            }
            catch
            {

            }

            return response;
        }

        public static User SendLoginRequest(string username, string password)
        {
            var user = new { Username = username, Password = password };
            var jsonData = JsonConvert.SerializeObject(user);
            var response = SubmitRequestToWebService(APIType.User,
                                                     "/authenticate",
                                                     WebMethod.POST,
                                                     ContentType.JSON,
                                                     jsonData);

            User responseUser = null;
            try
            {
                responseUser = JsonConvert.DeserializeObject<User>(response);
            }
            catch
            {

            }

            return responseUser;
        }

        public static IEnumerable<VaultDataObject> SendLoadInfoRequest()
        {
            var response = SubmitRequestToWebService(APIType.VaultData, "", WebMethod.GET, ContentType.JSON);

            IEnumerable<VaultDataObject> vaultInfo = null;
            try
            {
                vaultInfo = JsonConvert.DeserializeObject<IEnumerable<VaultDataObject>>(response);
            }
            catch
            {

            }

            return vaultInfo;
        }
    }
}
