using System.Xml.Serialization;

namespace De_SerializationLibrary
{
    public class De_Serialization
    {
        public static void Serialize<T>(T obj, string path)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (var fs = new FileStream(path, FileMode.Create))
            {
                xml.Serialize(fs, obj);
            }
        }

        public static T? Deserialize<T>(string path) 
        {
            T? obj;
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (var fs = new FileStream(path, FileMode.Open))
            {
                 obj = (T?)xml.Deserialize(fs);
                
            }
            return obj;
        }
    }
}