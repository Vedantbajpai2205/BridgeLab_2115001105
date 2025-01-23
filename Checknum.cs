using System;

class Checknum
{
    static void Main()
    {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the number is positive, negative, or zero
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
    }
}
