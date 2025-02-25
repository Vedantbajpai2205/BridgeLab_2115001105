using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotations
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }
    class Program1
    {
        static void Main()
        {
            Dog myDog = new Dog();
            myDog.MakeSound();
        }
    }
}

