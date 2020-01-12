using System;
using System.Security.Cryptography;
using System.Text;

namespace VaultCommonLibrary
{
    class ObjectSerializer
    {
        private static string Key = "1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a";
        private static string IV = "1a1a1a1a1a1a1a1a";

        private static string Encrypt(string data)
        {
            byte[] textbytes = ASCIIEncoding.ASCII.GetBytes(data);

            using (AesCryptoServiceProvider endec = new AesCryptoServiceProvider())
            {
                endec.BlockSize = 128;
                endec.KeySize = 256;
                endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
                endec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
                endec.Padding = PaddingMode.PKCS7;
                endec.Mode = CipherMode.CBC;
                
                ICryptoTransform icrypt = endec.CreateEncryptor(endec.Key, endec.IV);
                byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);

                return Convert.ToBase64String(enc);
            }
        }

        private static string Decrypt(string encryptedData)
        {
            byte[] textbytes = ASCIIEncoding.ASCII.GetBytes(encryptedData);

            using (AesCryptoServiceProvider endec = new AesCryptoServiceProvider())
            {
                endec.BlockSize = 128;
                endec.KeySize = 256;
                endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
                endec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
                endec.Padding = PaddingMode.PKCS7;
                endec.Mode = CipherMode.CBC;

                ICryptoTransform icrypt = endec.CreateEncryptor(endec.Key, endec.IV);
                byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);

                return ASCIIEncoding.ASCII.GetString(enc);
            }
        }

        /// <summary>
        /// Serialize an object to an encrypted XML file.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filename"></param>
        public static void SerializeToXML(object data, string filename)
        {
            try
            {
                var encryptedData = Encrypt(data.ToXMLString());
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filename))
                {
                    streamWriter.WriteLine(encryptedData);
                }

            }
            catch(Exception ex)
            {
                throw new ObjectSerializerException("Object Serialization Error", ex);
            }
        }
        
        /// <summary>
        /// Serialize an object to an encryoted JSON string stored in the specified JSON file.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        public static void SerializeToJSON(object data, string filename)
        {
            try
            {
                var jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                var encryptedData = Encrypt(jsonData);

                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filename))
                {
                    streamWriter.WriteLine(encryptedData);
                }
            }
            catch (Exception ex)
            {
                throw new ObjectSerializerException("Object Serialization Error", ex);
            }
        }

        public static T DeserializeFromXML<T>(string filename)
        {
            try
            {
                using(System.IO.StreamReader streamReader = new System.IO.StreamReader(filename))
                {
                    var encryptedData = streamReader.ReadToEnd();
                    var decryptedData = Decrypt(encryptedData);

                    var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                   

                }

                throw new NotImplementedException();
            }
            catch(Exception ex)
            {
                throw new ObjectSerializerException("Object Deserialization Error", ex);
            }
        }

        public static T DeserializeFromJSON<T>(string filename,bool FileExtensionIncluded = true)
        {
            filename = FileExtensionIncluded ? filename : string.Format("{0}.json", filename);

            try
            {
                using (System.IO.StreamReader streamReader = new System.IO.StreamReader(filename))
                {
                    var encryptedData = streamReader.ReadToEnd();
                    var decryptedData = Decrypt(encryptedData);

                    return (T)Newtonsoft.Json.JsonConvert.DeserializeObject(decryptedData);
                }
            }
            catch(Exception ex)
            {
                throw new ObjectSerializerException("Object Deserialization Error.", ex);
            }
        }
    }
}
