using System;
using System.Reflection;
namespace Annotation
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class TodoAttribute : Attribute
    {
        public string Task { get; }
        public string AssignedTo { get; }
        public string Priority { get; }

        public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = priority;
        }
    }

    public class Project
    {
        [Todo("Implement login feature", "Yash", "HIGH")]
        [Todo("Fix navigation bug", "Vedant")]
        public void FeatureA()
        {

        }

        [Todo("Optimize database queries", "Raghav", "LOW")]
        public void FeatureB()
        {

        }

        [Todo("Write unit tests", "Suyash")]
        public void FeatureC()
        {

        }
    }

    class Program7
    {
        static void Main()
        {
            MethodInfo[] methods = typeof(Project).GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (MethodInfo method in methods)
            {
                object[] attributes = method.GetCustomAttributes(typeof(TodoAttribute), false);
                foreach (TodoAttribute attribute in attributes)
                {
                    Console.WriteLine($"Method: {method.Name}, Task: {attribute.Task}, Assigned To: {attribute.AssignedTo}, Priority: {attribute.Priority}");
                }
            }
        }
    }
}