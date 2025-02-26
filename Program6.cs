using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSON
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    class Program6
    {
        static void Main()
        {
            string json = @"[
            { 'Name': 'Yash', 'Age': 30, 'Email': 'yash.baj@example.com' },
            { 'Name': 'Raghav', 'Age': 25, 'Email': 'raghav.sh@example.com' },
            { 'Name': 'Vedant', 'Age': 35, 'Email': 'vedant.bj@example.com' },
            { 'Name': 'Harsh', 'Age': 20, 'Email': 'harsh.singh@example.com' }
        ]";

            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(json);

            var filteredPeople = people.Where(p => p.Age > 25).ToList();

            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Email: {person.Email}");
            }
        }
    }
}