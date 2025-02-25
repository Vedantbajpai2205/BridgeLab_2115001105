using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace Annotation
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LoExecutionTimeAttribute : Attribute
    {
    }

    public class MethodInterceptor : DispatchProxy
    {
        private object _decorated;

        public static T Create<T>(T decorated)
        {
            object proxy = Create<T, MethodInterceptor>();
            ((MethodInterceptor)proxy).SetParameters(decorated);
            return (T)proxy;
        }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            var attribute = targetMethod.GetCustomAttribute(typeof(LogExecutionTimeAttribute));
            if (attribute == null)
            {
                return targetMethod.Invoke(_decorated, args);
            }

            Stopwatch stopwatch = Stopwatch.StartNew();
            var result = targetMethod.Invoke(_decorated, args);
            stopwatch.Stop();

            Console.WriteLine($"Execution time for {targetMethod.Name}: {stopwatch.ElapsedMilliseconds} ms");

            return result;
        }
        private void SetParameters(object decorated)
        {
            _decorated = decorated;
        }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class MaxLengthAttribute : Attribute
    {
        public int Length { get; }

        public MaxLengthAttribute(int length)
        {
            Length = length;
        }
    }
    public class User
    {
        [MaxLength(10)]
        public string Username { get; set; }

        public User(string username)
        {
            Username = username;

            var type = typeof(User);
            var field = type.GetProperty(nameof(Username));
            var maxLengthAttribute = (MaxLengthAttribute)Attribute.GetCustomAttribute(field, typeof(MaxLengthAttribute));

            if (maxLengthAttribute != null && Username.Length > maxLengthAttribute.Length)
            {
                throw new ArgumentException($"The length of {nameof(Username)} cannot exceed {maxLengthAttribute.Length} characters.");
            }
        }
    }
    public class SampleClass
    {
        [LogExecutionTime]
        public void Method1()
        {
            System.Threading.Thread.Sleep(100);
        }

        [LogExecutionTime]
        public void Method2()
        {
            System.Threading.Thread.Sleep(200);
        }
    }
    public class Program9
    {
        public static void Main()
        {
            var sample = MethodInterceptor.Create(new SampleClass());
            sample.Method1();
            sample.Method2();

            try
            {
                var user1 = new User("ShortName");
                Console.WriteLine($"User created with username: {user1.Username}");

                var user2 = new User("VeryLongUsername");
                Console.WriteLine($"User created with username: {user2.Username}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}