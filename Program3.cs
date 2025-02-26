using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSON
{
    class Program3
    {
        static void Main()
        {
            string json1 = @"{
                            'name': 'Yash',
                            'email': 'yash.baj@example.com'
                         }";

            string json2 = @"{
                            'age': 30,
                            'address': '359/3'
                         }";

            JObject obj1 = JObject.Parse(json1);
            JObject obj2 = JObject.Parse(json2);

            obj1.Merge(obj2, new JsonMergeSettings
            {
                MergeArrayHandling = MergeArrayHandling.Union
            });

            Console.WriteLine(obj1.ToString());
        }
    }

}
