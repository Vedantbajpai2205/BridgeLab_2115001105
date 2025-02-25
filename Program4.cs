using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class Program5
    {
        static void Main()
        {
            MathOperations mathOps = new MathOperations();
            Console.WriteLine("Enter the operation (Add, Subtract, Multiply): ");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            MethodInfo method = typeof(MathOperations).GetMethod(operation, BindingFlags.Public | BindingFlags.Instance);

            if (method != null)
            {
                object result = method.Invoke(mathOps, new object[] { num1, num2 });
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid operation.");
            }
        }
    }

}
