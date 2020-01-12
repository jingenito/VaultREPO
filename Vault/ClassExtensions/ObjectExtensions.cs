namespace Vault
{
    public static class ObjectExtensions
    {
        public static string ToXMLString(this object obj)
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(obj.GetType());
                serializer.Serialize(stringwriter, obj);

                return stringwriter.ToString();
            }
        }
    }
}
