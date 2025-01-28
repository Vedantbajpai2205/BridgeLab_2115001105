using System;

public class NaturalNumberSum
{
    // Method to find the sum of n natural numbers using recursion
    public static int SumUsingRecursion(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n + SumUsingRecursion(n - 1);
    }

    public static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
		int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            int sumRecursion = SumUsingRecursion(n);

            int sumFormula = SumUsingFormula(n);

            Console.WriteLine("Sum using recursion: " + sumRecursion);
            Console.WriteLine("Sum using formula: " + sumFormula);

            if (sumRecursion == sumFormula)
            {
                Console.WriteLine("The results match. The sum is correct.");
            }
            else
            {
                Console.WriteLine("The results do not match. Something went wrong.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a positive integer.");
        }
    }
}
