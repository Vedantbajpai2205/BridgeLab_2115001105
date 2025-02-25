using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Reflection
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program4
    {
        static void Main()
        {
            Type studentType = typeof(Student);
            ConstructorInfo constructor = studentType.GetConstructor(new Type[] { typeof(string), typeof(int) });
            object studentInstance = constructor.Invoke(new object[] { "Yash", 20 });

            MethodInfo displayMethod = studentType.GetMethod("Display");
            displayMethod.Invoke(studentInstance, null);
        }
    }

}
