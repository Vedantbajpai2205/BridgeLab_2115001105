using System;

class Sum
{
    static void Main()
    {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the number is a natural number
            if (number >= 0)
            {
                // Calculate the sum of n natural numbers
                int sumOfNumbers = number * (number + 1) / 2;
                Console.WriteLine("The sum of " + sumOfNumbers + " natural numbers is " + number);
            }
            else
            {
                Console.WriteLine("The number " + number + " is not a natural number.");
            }
    }
}
