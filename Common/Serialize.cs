using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace Game_Store
{
    public interface ISerialize<T>
    {
        public void Serialize(List<T> list);

        public List<T> Deserialize();
    }

    public class XmlSerializer<T> : ISerialize<T>
    {
        private string _way;

        public XmlSerializer(string way)
        {
            _way = way;
        }

        public void Serialize(List<T> list)
        {
        XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

            try
            {
                using TextWriter tw = new StreamWriter(_way);
                serializer.Serialize(tw, list);
            }
            catch (Exception)
            {
                return;
            }
        }

        public List<T> Deserialize()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<T>));
            List<T> result = null;

            try
            {
                using TextReader tr = new StreamReader(_way);
                var objectt = deserializer.Deserialize(tr);
                if (objectt is List<T>)
                {
                    result = (List<T>) objectt;
                }
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }
    }
}
