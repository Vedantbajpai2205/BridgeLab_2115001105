using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{

    class Calculator
    {
        private int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class Program3
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            MethodInfo method = typeof(Calculator).GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
            object result = method.Invoke(calc, new object[] { 5, 10 });
            Console.WriteLine(result);
        }
    }

}
