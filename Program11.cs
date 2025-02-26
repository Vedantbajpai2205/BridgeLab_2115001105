using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace JSON
{
    class Program11
    {
        static void Main()
        {
            string jsonFile1 = "path1.json";
            string jsonFile2 = "path2.json";

            string json1 = File.ReadAllText(jsonFile1);
            string json2 = File.ReadAllText(jsonFile2);

            JObject jsonObj1 = JObject.Parse(json1);
            JObject jsonObj2 = JObject.Parse(json2);

            jsonObj1.Merge(jsonObj2, new JsonMergeSettings
            {
                MergeArrayHandling = MergeArrayHandling.Union
            });

            string mergedJson = jsonObj1.ToString();
            Console.WriteLine(mergedJson);
        }
    }

}
