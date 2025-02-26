using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSON
{
    class Program9
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main()
        {
            string jsonData = @"
        [
            { 'Name': 'Yash', 'Age': 30 },
            { 'Name': 'Vedant', 'Age': 25 },
            { 'Name': 'Raghav', 'Age': 28 },
            { 'Name': 'Harsh', 'Age': 24 }
        ]";

            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(jsonData);

            var filteredPeople = people.FindAll(p => p.Age > 25);

            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }

}
