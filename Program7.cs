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

    class Program8
    {
        static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new()
        {
            T obj = new T();
            foreach (var property in properties)
            {
                PropertyInfo propInfo = clazz.GetProperty(property.Key);
                if (propInfo != null && propInfo.CanWrite)
                {
                    propInfo.SetValue(obj, Convert.ChangeType(property.Value, propInfo.PropertyType));
                }
            }
            return obj;
        }

        static void Main()
        {
            Dictionary<string, object> personProperties = new Dictionary<string, object>
        {
            { "Name", "Yash" },
            { "Age", 30 }
        };

            Person person = ToObject<Person>(typeof(Person), personProperties);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }

}
