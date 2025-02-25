using System;
using System.Diagnostics;
using System.Reflection;
namespace Annotation
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public class LogExecutionTimeAttribute : Attribute
    {
    }

    public class PerformanceTester
    {
        [LogExecutionTime]
        public void MethodA()
        {
            System.Threading.Thread.Sleep(100);
        }

        [LogExecutionTime]
        public void MethodB()
        {
            System.Threading.Thread.Sleep(200);
        }
    }

    class Program8
    {
        static void Main()
        {
            PerformanceTester tester = new PerformanceTester();


            MeasureExecutionTime(tester, "MethodA");
            MeasureExecutionTime(tester, "MethodB");
        }

        static void MeasureExecutionTime(object obj, string methodName)
        {
            MethodInfo method = obj.GetType().GetMethod(methodName);
            if (method != null && method.GetCustomAttribute<LogExecutionTimeAttribute>() != null)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                method.Invoke(obj, null);

                stopwatch.Stop();
                Console.WriteLine($"Execution Time for {methodName}: {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}