using System;

class NumberChecker
{
    // Method to find the count of digits in the number
    public static int FindDigitCount(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    // Method to store the digits of the number in a digits array
    public static int[] StoreDigits(int number)
    {
        int count = FindDigitCount(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to find the sum of the digits of a number using the digits array
    public static int FindDigitSum(int number)
    {
        int sum = 0;
        int[] digits = StoreDigits(number);
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    // Method to find the sum of the squares of the digits of a number using the digits array
    public static double FindSquareSum(int number)
    {
        double sumOfSquares = 0;
        int[] digits = StoreDigits(number);
        foreach (int digit in digits)
        {
            sumOfSquares += Math.Pow(digit, 2); 
        }
        return sumOfSquares;
    }

    // Method to check if a number is a Harshad number
    public static bool IsHarshadNumber(int number)
    {
        int sum = FindDigitSum(number);
        return number % sum == 0; 
    }

    // Method to find the frequency of each digit in the number
    public static void FindDigitFrequency(int number)
    {
        int[] digits = StoreDigits(number);
        int[,] frequency = new int[10, 2];

        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i; 
            frequency[i, 1] = 0; 
        }

        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0) 
            {
                Console.WriteLine("Digit " + frequency[i, 0] + " : " + frequency[i, 1] + " times");
            }
        }
    }
}

class Number5_3
{
    static void Main(string[] args)
    {
        int number = 153;

        int digitCount = NumberChecker.FindDigitCount(number);
        Console.WriteLine("Count of digits in " + number + " : " + digitCount);
        int[] digits = NumberChecker.StoreDigits(number);
        Console.WriteLine("Digits of the number:");
        foreach (var digit in digits)
        {
            Console.Write(digit + " ");
        }
        Console.WriteLine();

        int digitSum = NumberChecker.FindDigitSum(number);
        Console.WriteLine("Sum of digits: " + digitSum);

        double squareSum = NumberChecker.FindSquareSum(number);
        Console.WriteLine("Sum of the squares of digits: " + squareSum);

        bool isHarshad = NumberChecker.IsHarshadNumber(number);
        Console.WriteLine("Is " + number + " a Harshad number? " + isHarshad);

        NumberChecker.FindDigitFrequency(number);
    }
}
