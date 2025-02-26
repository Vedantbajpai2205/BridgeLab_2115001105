using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public List<String> Subjects { get; set; }

        public Student(string name, int age, List<string> subjects)
        {
            Name = name;
            Age = age;
            Subjects = subjects;

        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Yash", 21, new List<string> { "Dsa", "C#", "Cloud" });
            string Json = JsonConvert.SerializeObject(student, Formatting.Indented);
            Console.WriteLine(Json);
        }
    }
}
