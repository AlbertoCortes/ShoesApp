using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;

namespace ShoesAppCommon
{
    public class Common
    {
        public static Out SerializeJson<In, Out>(In obj)
        {
            string output = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<Out>(output);
        }





        public static T DeserializeFromXml<T>(string xml)
        {
            T result;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }

        public static  void SerializeToXml<T>(T obj)
        {
            string fileName = $@"C:\Users\Curso\Documents\Academia\ShoesApp\Watcher\XML/Productos.xml";
            XmlSerializer ser = new XmlSerializer(typeof(T));
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fileStream, obj);
            fileStream.Close();
        }

        public static List<T> GetList<T>()
        {
            List<T> pr = new List<T>();
            if (File.Exists($@"C:\Users\Curso\Documents\Academia\ShoesApp\Watcher\XML/Productos.xml"))
            {
                XmlDocument lista = new XmlDocument();

                lista.Load($@"C:\Users\Curso\Documents\Academia\ShoesApp\Watcher\XML/Productos.xml");
                pr.AddRange(DeserializeFromXml<List<T>>(lista.OuterXml));
                return pr;
            }
            return pr;

        }









    }
}
