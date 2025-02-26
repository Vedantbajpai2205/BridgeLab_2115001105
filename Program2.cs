using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSON
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    class Program2
    {
        static void Main()
        {
            string filePath = "data.json";
            string json = File.ReadAllText(filePath);

            var person = JsonConvert.DeserializeObject<Person>(json);

            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Email: {person.Email}");
        }
    }

}
