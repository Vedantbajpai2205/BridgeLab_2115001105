using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;

namespace JSON
{

    class Program12
    {
        static void Main()
        {
            string json = @"{
            ""name"": ""Yash"",
            ""age"": 30,
            ""city"": ""Mathura""
        }";

            XmlDocument xmlDoc = JsonConvert.DeserializeXmlNode("{\"root\":" + json + "}", "root");

            Console.WriteLine(xmlDoc.OuterXml);
        }
    }

}
