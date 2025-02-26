using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace JSON
{
    class Program7
    {
        static void Main()
        {
            string json = File.ReadAllText("file.json");
            JObject jsonObject = JObject.Parse(json);
            PrintKeysAndValues(jsonObject);
        }

        static void PrintKeysAndValues(JObject jsonObject)
        {
            foreach (var property in jsonObject.Properties())
            {
                Console.WriteLine($"{property.Name}: {property.Value}");
            }
        }
    }

}
