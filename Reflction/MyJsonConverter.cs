using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflction
{
    public class MyJsonConverter
    {
        public static string Serialize<T>(T obj)
        {
            StringBuilder json = new StringBuilder();
            json.Append("{");
            Type type = obj.GetType();
            var properties = type.GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                var prop = properties[i];
                var value = prop.GetValue(obj);
                if (i > 0) json.Append(",");
                json.AppendFormat("\"{0}\":\"{1}\"", prop.Name, value);
            }

            json.Append("}");
            return json.ToString();
        }

       
    }
}
