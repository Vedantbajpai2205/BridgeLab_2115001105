using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Annotation
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public class TaskInfoAttribute : Attribute
    {
        public string Priority { get; }
        public string AssignedTo { get; }

        public TaskInfoAttribute(string priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }
    public class TaskManager
    {
        [TaskInfo("High", "Vedant")]
        public void ImportantTask()
        {
            Console.WriteLine("Executing important task.");
        }
    }
    class Program4
    {
        private const string Task = "ImportantTask";

        static void Main()
        {
            MethodInfo methodInfo = typeof(TaskManager).GetMethod(Task);
            object[] attributes = methodInfo.GetCustomAttributes(typeof(TaskInfoAttribute), false);

            if (attributes.Length > 0)
            {
                TaskInfoAttribute taskInfo = (TaskInfoAttribute)attributes[0];
                Console.WriteLine($"Priority: {taskInfo.Priority}");
                Console.WriteLine($"Assigned To: {taskInfo.AssignedTo}");
            }
        }
    }
}