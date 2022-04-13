using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Shop
{
    public static class XmlSerialize
    {
        public static void Serialize(List<Book> obj, string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));

            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                formatter.Serialize(sw, obj);
            }
        }
        
        public static List<Book> Deserialize(string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));
            List<Book> products;
            
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                products = (List<Book>) formatter.Deserialize(fs);
            }

            return products;
        }
    }
}