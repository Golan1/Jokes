using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jokes
{
    public static class XmlUtils
    {
        public static T desirialize<T>(string path)
        {
            var serializer = new XmlSerializer(typeof(T));
            T result = default(T);

            using (var reader = new StreamReader(path))
            {
                result = (T)serializer.Deserialize(reader);
            }

            return result;
        }
    }
}
