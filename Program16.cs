using System;
using System.Reflection;
namespace Annotation
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class BugReportAttribute : Attribute
    {
        public string Description { get; }

        public BugReportAttribute(string description)
        {
            Description = description;
        }
    }
    public class TaskManager2
    {
        [BugReport("Bug report 1")]
        [BugReport("Bug report 2")]
        public void SomeMethod()
        {
            Console.WriteLine("Executing SomeMethod.");
        }
    }
    class Program5
    {
        static void Main()
        {
            MethodInfo methodInfo = typeof(TaskManager).GetMethod("SomeMethod");
            object[] attributes = methodInfo.GetCustomAttributes(typeof(BugReportAttribute), false);

            foreach (BugReportAttribute attribute in attributes)
            {
                Console.WriteLine($"Bug Report: {attribute.Description}");
            }
        }
    }
}