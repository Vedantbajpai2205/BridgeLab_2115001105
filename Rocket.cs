using System;

class Rocket
{
    static void Main()
    {
            Console.Write("Enter the countdown starting number: ");
            int counter = int.Parse(Console.ReadLine());

            Console.WriteLine("Starting countdown:");

            // Countdown using a while loop
            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--;
            }

            Console.WriteLine("Rocket Launched!!");
    }
}
