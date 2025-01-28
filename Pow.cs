using System;

public class Pow
{
    // Method to find the factors of a number and return them in an array
    public static int[] FindFactors(int num)
    {
        int count = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    // Method to calculate the sum of the factors
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to calculate the product of the factors
    public static int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    public static double SumOfSquaresOfFactors(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.Write("Factors of " + number + ": ");
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        int sum = SumOfFactors(factors);
        Console.WriteLine("Sum of factors: " + sum);

        int product = ProductOfFactors(factors);
        Console.WriteLine("Product of factors: " + product);

        double sumOfSquares = SumOfSquaresOfFactors(factors);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
    }
}
