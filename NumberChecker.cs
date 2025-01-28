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

    // Method to check if the number is a Duck number
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

    // Method to check if the number is an Armstrong number
    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int count = digits.Length;
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, count); 
        }
        return sum == number;
    }

    // Method to find the largest and second largest elements in the digits array
    public static (int largest, int secondLargest,)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit < largest)
            {
                secondLargest = digit;
            }
        }
        return (largest, secondLargest);
    }

    // Method to find the smallest and second smallest elements in the digits array
    public static (int smallest, int secondSmallest)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit > smallest)
            {
                secondSmallest = digit;
            }
        }
        return (smallest, secondSmallest);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int number = 153;

        int digitCount = NumberChecker.FindDigitCount(number);
   
        int[] digits = NumberChecker.StoreDigits(number);
        Console.WriteLine("Digits of the number:");
        foreach (var digit in digits)
        {
            Console.Write(digit + " ");
        }
        Console.WriteLine();

        bool isDuck = NumberChecker.IsDuckNumber(number);
        Console.WriteLine("Is " + number + " a Duck number? " + isDuck);

        bool isArmstrong = NumberChecker.IsArmstrongNumber(number);
        Console.WriteLine("Is " + number + " an Armstrong number? " + isArmstrong);

        var (largest, secondLargest) = NumberChecker.FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest digit: " + largest + " , Second largest digit: " + secondLargest);

        var (smallest, secondSmallest) = NumberChecker.FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest digit: " + smallest + " , Second smallest digit: " + secondSmallest);
    }
}
