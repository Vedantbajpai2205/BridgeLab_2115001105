using System;

class Factorial
{
    static void Main()
    {
            Console.Write("Enter a positive integer to find its factorial: ");
            int n = int.Parse(Console.ReadLine());

            // Check if the input is a positive integer
            if (n < 0)
            {
                Console.WriteLine("The input is not a positive integer.");
                return;
            }

            // Calculate factorial using a while loop
            int factorial = 1;
            int counter = n;
            while (counter > 0)
            {
                factorial *= counter;
                counter--;
            }

            Console.WriteLine("The factorial of " + n + " is " + factorial);
    }
}
