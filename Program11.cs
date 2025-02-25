using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace Reflection
{
    public class SampleClass
    {
        public void MethodA()
        {
            System.Threading.Thread.Sleep(500); 
            Console.WriteLine("MethodA executed");
        }

        public void MethodB()
        {
            System.Threading.Thread.Sleep(300); 
            Console.WriteLine("MethodB executed");
        }

        public int Add(int a, int b)
        {
            System.Threading.Thread.Sleep(100);
            return a + b;
        }
    }

    public class MethodExecutionTimer
    {
        public static void MeasureExecutionTime(object obj, string methodName, params object[] parameters)
        {
            MethodInfo methodInfo = obj.GetType().GetMethod(methodName);

            if (methodInfo != null)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                methodInfo.Invoke(obj, parameters);

                stopwatch.Stop();

                Console.WriteLine($"Execution time of {methodName}: {stopwatch.ElapsedMilliseconds} ms");
            }
            else
            {
                Console.WriteLine($"Method '{methodName}' not found.");
            }
        }
    }

    class Program12
    {
        static void Main()
        {
            var sample = new SampleClass();

            MethodExecutionTimer.MeasureExecutionTime(sample, "MethodA");
            MethodExecutionTimer.MeasureExecutionTime(sample, "MethodB");

            MethodExecutionTimer.MeasureExecutionTime(sample, "Add", 5, 7);
        }
    }

}
