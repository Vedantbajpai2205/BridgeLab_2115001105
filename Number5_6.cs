using System;

class NumberChecker
{
    // Method to find factors of a number and return them as an array
    public static int[] FindFactors(int number)
    {
        int[] tempFactors = new int[number];
        int count = 0;
        
        // Loop to find factors of the number
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) // If i is a factor
            {
                tempFactors[count] = i;
                count++;
            }
        }
        
        // Resize array to fit the actual number of factors
        int[] factors = new int[count];
        Array.Copy(tempFactors, factors, count);
        
        return factors;
    }

    // Method to find the greatest factor of a number using the factors array
    public static int FindGreatestFactor(int number)
    {
        int[] factors = FindFactors(number);
        return factors[factors.Length - 1]; // The greatest factor will be the last one
    }

    // Method to find the sum of the factors using the factors array
    public static int FindSumOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors using the factors array
    public static int FindProductOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cube of the factors using the factors array
    public static double FindProductOfCubesOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        double productOfCubes = 1;
        foreach (int factor in factors)
        {
            productOfCubes *= Math.Pow(factor, 3); 
        }
        return productOfCubes;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sumOfProperDivisors = 0;
        
        // Sum the factors excluding the number itself (proper divisors)
        for (int i = 0; i < factors.Length - 1; i++) 
        {
            sumOfProperDivisors += factors[i];
        }
        
        return sumOfProperDivisors == number;
    }
}

class Number5_6
{
    static void Main(string[] args)
    {
        int number = 28;

        int[] factors = NumberChecker.FindFactors(number);
        Console.WriteLine("Factors of " + number);
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        int greatestFactor = NumberChecker.FindGreatestFactor(number);
        Console.WriteLine("Greatest factor of " + number + " : " + greatestFactor);

        int sumOfFactors = NumberChecker.FindSumOfFactors(number);
        Console.WriteLine("Sum of factors of " + number + " : " + sumOfFactors);

        int productOfFactors = NumberChecker.FindProductOfFactors(number);
        Console.WriteLine("Product of factors of " + number + " : " + productOfFactors);

        double productOfCubes = NumberChecker.FindProductOfCubesOfFactors(number);
        Console.WriteLine("Product of cubes of the factors of number: " + productOfCubes);

        bool isPerfect = NumberChecker.IsPerfectNumber(number);
        Console.WriteLine("Is " + number + " a perfect number? " + isPerfect);
    }
}
