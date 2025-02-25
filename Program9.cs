using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    public interface IGreeting
    {
        void SayHello(string name);
    }

    public class Greeting : IGreeting
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }

    public class LoggingProxy : IGreeting
    {
        private readonly IGreeting _target;

        public LoggingProxy(IGreeting target)
        {
            _target = target;
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Logging: Calling method SayHello with parameter {name}");
            _target.SayHello(name);
        }

        class Program10
        {
            static void Main()
            {
                IGreeting greeting = new Greeting();
                IGreeting proxy = new LoggingProxy(greeting);

                proxy.SayHello("Yash");
            }
        }
    }
}
