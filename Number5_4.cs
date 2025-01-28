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

    // Method to reverse the digits array
    public static int[] ReverseDigits(int[] digits)
    {
        Array.Reverse(digits);
        return digits;
    }

    // Method to compare two arrays and check if they are equal
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }
        return true;
    }

    // Method to check if a number is a palindrome using the digits array
    public static bool IsPalindrome(int number)
    {
        int[] digits = StoreDigits(number);
        int[] reversedDigits = ReverseDigits((int[])digits.Clone());
        return AreArraysEqual(digits, reversedDigits);
    }

    // Method to check if a number is a duck number using the digits array
    public static bool IsDuckNumber(int number)
    {
        int[] digits = StoreDigits(number);
        foreach (int digit in digits)
        {
            if (digit != 0)
            {
                return true; 
            }
        }
        return false;
    }
}

class Number5_4
{
    static void Main(string[] args)
    {
        int number = 12321;

        int digitCount = NumberChecker.FindDigitCount(number);
        Console.WriteLine("Count of digits in {number}: {digitCount}");

        int[] digits = NumberChecker.StoreDigits(number);
        Console.WriteLine("Digits of the number:");
        foreach (var digit in digits)
        {
            Console.Write(digit + " ");
        }
        Console.WriteLine();

        int[] reversedDigits = NumberChecker.ReverseDigits((int[])digits.Clone());
        Console.WriteLine("Reversed digits:");
        foreach (var digit in reversedDigits)
        {
            Console.Write(digit + " ");
        }
        Console.WriteLine();

        bool isPalindrome = NumberChecker.IsPalindrome(number);
        Console.WriteLine("Is " + number + " a palindrome? " + isPalindrome);

        bool isDuckNumber = NumberChecker.IsDuckNumber(number);
        Console.WriteLine("Is " + number + " a Duck number? " + isDuckNumber);
    }
}
