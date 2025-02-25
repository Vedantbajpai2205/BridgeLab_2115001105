using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Reflection
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program9
    {
        static string ToJson(object obj)
        {
            StringBuilder json = new StringBuilder();
            json.Append("{");

            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo[] properties = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            bool first = true;

            foreach (var field in fields)
            {
                if (!first) json.Append(", ");
                json.Append($"\"{field.Name}\": \"{field.GetValue(obj)}\"");
                first = false;
            }

            foreach (var property in properties)
            {
                if (!first) json.Append(", ");
                json.Append($"\"{property.Name}\": \"{property.GetValue(obj)}\"");
                first = false;
            }

            json.Append("}");
            return json.ToString();
        }

        static void Main()
        {
            Person person = new Person { Name = "Yash", Age = 30 };
            string jsonString = ToJson(person);
            Console.WriteLine(jsonString);
        }
    }

}
