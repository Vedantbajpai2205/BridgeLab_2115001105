using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program5
    {
        static void Main()
        {
            List<Person> people = new List<Person>
        {
            new Person { Name = "Yash", Age = 30 },
            new Person { Name = "Vedant", Age = 25 },
            new Person { Name = "Raghav", Age = 35 }
        };

            string jsonArray = JsonConvert.SerializeObject(people);

            Console.WriteLine(jsonArray);
        }
    }

}
