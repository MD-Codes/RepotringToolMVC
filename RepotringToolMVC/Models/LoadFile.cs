using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RepotringToolMVC.Models
{
    public class LoadFiles<T> : ILoadFiles<T>
    {
        public T LoadFile(string filename)
        {
            T result = default(T);

            // Create a StringReader from the XML content
            using (StringReader stringReader = new StringReader(filename))
            {
                // Deserialize XML from StringReader
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                result = (T)serializer.Deserialize(stringReader);
            }

            return result;
        }
    }
}
