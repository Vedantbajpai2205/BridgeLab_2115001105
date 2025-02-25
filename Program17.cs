using System;
using System.Reflection;
namespace Annotation
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public class ImportantMethodAttribute : Attribute
    {
        public string Level { get; }

        public ImportantMethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }

    public class TaskManager3
    {
        [ImportantMethod("HIGH")]
        public void CriticalTask()
        {
            Console.WriteLine("Executing critical task.");
        }

        [ImportantMethod("MEDIUM")]
        public void RegularTask()
        {
            Console.WriteLine("Executing regular task.");
        }

        [ImportantMethod]
        public void DefaultLevelTask()
        {
            Console.WriteLine("Executing default level task.");
        }
    }

    class Program6
    {
        static void Main()
        {
            MethodInfo[] methods = typeof(TaskManager).GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (MethodInfo method in methods)
            {
                object[] attributes = method.GetCustomAttributes(typeof(ImportantMethodAttribute), false);
                foreach (ImportantMethodAttribute attribute in attributes)
                {
                    Console.WriteLine($"Method: {method.Name}, Level: {attribute.Level}");
                }
            }
        }
    }
}