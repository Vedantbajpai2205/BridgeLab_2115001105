using System;

class NumberChecker
{
    // Method to check if a number is a prime number
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false; // Prime numbers are greater than 1
        for (int i = 2; i <= Math.Sqrt(number); i++) // Check divisibility up to sqrt(number)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Method to check if a number is a neon number
    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;
        
        // Calculate the sum of digits of the square
        while (square != 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }

        return sumOfDigits == number;
    }

    // Method to check if a number is a spy number
    public static bool IsSpyNumber(int number)
    {
        int sum = 0, product = 1;
        
        // Calculate sum and product of digits
        int temp = number;
        while (temp != 0)
        {
            int digit = temp % 10;
            sum += digit;
            product *= digit;
            temp /= 10;
        }

        // Spy number condition: sum of digits equals product of digits
        return sum == product;
    }

    // Method to check if a number is an automorphic number
    public static bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        
        // Check if the square ends with the number itself
        return square % (int)Math.Pow(10, FindDigitCount(number)) == number;
    }

    // Method to check if a number is a buzz number
    public static bool IsBuzzNumber(int number)
    {
        return number % 7 == 0 || number % 10 == 7; 
    }

    // Method to find the count of digits in the number (for Automorphic check)
    private static int FindDigitCount(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }
}

class Number5_5
{
    static void Main(string[] args)
    {
        int number = 25;

        bool isPrime = NumberChecker.IsPrime(number);
        Console.WriteLine("Is " + number + " a prime number?" + isPrime);

        bool isNeon = NumberChecker.IsNeonNumber(number);
        Console.WriteLine("Is " + number + " a neon number? " + isNeon);

        bool isSpy = NumberChecker.IsSpyNumber(number);
        Console.WriteLine("Is " + number + " a spy number? " + isSpy);

        bool isAutomorphic = NumberChecker.IsAutomorphicNumber(number);
        Console.WriteLine("Is " + number + " an automorphic number?  " + isAutomorphic);

        bool isBuzz = NumberChecker.IsBuzzNumber(number);
        Console.WriteLine("Is " + number + " a buzz number? " + isBuzz);
    }
}
