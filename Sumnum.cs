using System;

class Sumnum
{
    static void Main()
    {
            Console.Write("Enter a natural number: ");
            int n = int.Parse(Console.ReadLine());

           
            if (n < 1)
            {
                Console.WriteLine("The input is not a natural number.");
                return;
            }

            // Calculate sum using formula
            int formulaSum = n * (n + 1) / 2;

            // Calculate sum using while loop
            int loopSum = 0;
            int counter = 1;
            while (counter <= n)
            {
                loopSum += counter;
                counter++;
            }

            // Display the results
            Console.WriteLine("Sum calculated using formula " + formulaSum);
            Console.WriteLine("Sum calculated using while loop " + loopSum);

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
