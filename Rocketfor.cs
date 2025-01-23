using System;

class Rocketfor
{
    static void Main()
    {
            Console.Write("Enter the countdown starting number: ");
            int counter = int.Parse(Console.ReadLine());

            Console.WriteLine("Starting countdown:");

            // Countdown using a for loop
            for (int i = counter; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Rocket Launched!!");
    }
}
