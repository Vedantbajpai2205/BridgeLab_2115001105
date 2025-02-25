using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }

    [Author("Yash")]
    class MyClass
    {
        // Class content
    }

    class Program6
    {
        static void Main()
        {
            Type type = typeof(MyClass);
            object[] attributes = type.GetCustomAttributes(typeof(AuthorAttribute), false);

            if (attributes.Length > 0)
            {
                AuthorAttribute authorAttribute = (AuthorAttribute)attributes[0];
                Console.WriteLine($"Author: {authorAttribute.Name}");
            }
            else
            {
                Console.WriteLine("No Author attribute found.");
            }
        }
    }

}
