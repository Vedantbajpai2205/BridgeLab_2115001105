using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program2
    {
        static void Main()
        {
            Person person = new Person();
            Type personType = typeof(Person);
            FieldInfo ageField = personType.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            if (ageField != null)
            {
                ageField.SetValue(person, 30);
            }

            if (ageField != null)
            {
                int age = (int)ageField.GetValue(person);
                Console.WriteLine($"Age: {age}");
            }
        }
    }

    public class Person
    {
        private int age;

        public Person() { }
    }

}
