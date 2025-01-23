using System;

class Sumnumfor
{
    static void Main()
    {
            Console.Write("Enter a natural number: ");
            int n = int.Parse(Console.ReadLine());

            // Check if the input is a natural number
            if (n < 1)
            {
                Console.WriteLine("The input is not a natural number.");
                return;
            }

            // Calculate sum using formula
            int formulaSum = n * (n + 1) / 2;

            // Calculate sum using for loop
            int loopSum = 0;
            for (int i = 1; i <= n; i++)
            {
                loopSum += i;
            }

            Console.WriteLine("Sum calculated using formula " + formulaSum);
            Console.WriteLine("Sum calculated using for loop " + loopSum);

            if (formulaSum == loopSum)
            {
                Console.WriteLine("Both results match and are correct.");
            }
            else
            {
                Console.WriteLine("There is a mismatch in the results.");
            }
    }
}
