using System;

class Factorialfor
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

            // Calculate factorial using a for loop
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of " + n + " is " + factorial);
    }
}
