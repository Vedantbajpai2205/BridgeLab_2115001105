using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program1
    {
        static void Main()
        {
            Console.Write("Enter the class name : ");
            string className = Console.ReadLine();
            Type type = Type.GetType(className);

            if (type == null)
            {
                Console.WriteLine("Class not found.");
                return;
            }

            Console.WriteLine("Methods:");
            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine($"- {method.Name}");
            }

            Console.WriteLine("Fields:");
            FieldInfo[] fields = type.GetFields();
            foreach (var field in fields)
            {
                Console.WriteLine($"- {field.Name} ({field.FieldType})");
            }

            Console.WriteLine("Constructors:");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (var constructor in constructors)
            {
                Console.WriteLine($"- {constructor.Name} with parameters: {constructor.GetParameters().Length}");
            }
        }
    }

    public class MyClass
    {
        public int Field1;
        private string Field2;

        public MyClass() { }
        public MyClass(int field1, string field2)
        {
            Field1 = field1;
            Field2 = field2;
        }

        public void Method1() { }
        public void Method2(int x) { }
        private void Method3(string y) { }
    }

}
