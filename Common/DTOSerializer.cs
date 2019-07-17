using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Common
{
    public class DTOSerializer
    {
        public static XmlDocument Serialize(object obj)
        {
            XmlSerializer s = new XmlSerializer(obj.GetType());
            XmlDocument xml = null;
            MemoryStream ms = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(ms, new UTF8Encoding());
            writer.Formatting = Formatting.Indented;
            writer.IndentChar = ' ';
            writer.Indentation = 5;

            try
            {
                s.Serialize(writer, obj);
                xml = new XmlDocument();
                string xmlString = ASCIIEncoding.UTF8.GetString(ms.ToArray());
                xml.LoadXml(xmlString);
            }
            finally
            {
                writer.Close();
                ms.Close();
            }
            return xml;
        }

        public static object Deserialize(string xml, Type type)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlSerializer s = new XmlSerializer(type);
            string xmlString = doc.OuterXml.ToString();
            byte[] buffer = ASCIIEncoding.UTF8.GetBytes(xmlString);
            MemoryStream ms = new MemoryStream(buffer);
            XmlReader reader = new XmlTextReader(ms);
            object o = null;
            try
            {
                o = s.Deserialize(reader);
            }
            finally
            {
                reader.Close();
            }
            return o;
        }
    }
}
