using System;

class Greater5
{
    static void Main()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPositive(numbers[i]))
            {
                Console.WriteLine(numbers[i] + " is positive.");
                if (IsEven(numbers[i]))
                    Console.WriteLine(numbers[i] + " is even.");
                else
                    Console.WriteLine(numbers[i] + " is odd.");
            }
            else
            {
                Console.WriteLine(numbers[i] + " is negative.");
            }
        }

        int comparisonResult = Compare(numbers[0], numbers[numbers.Length - 1]);
        if (comparisonResult == 1)
            Console.WriteLine("The first number " + numbers[0] + " is greater than the last number " + numbers[numbers.Length - 1]);
        else if (comparisonResult == 0)
            Console.WriteLine("The first number " + numbers[0] + " is equal to the last number " + numbers[numbers.Length - 1]);
        else
            Console.WriteLine("The first number " + numbers[0] + " is less than the last number " + numbers[numbers.Length - 1]);
    }

    static bool IsPositive(int number)
    {
        return number > 0;
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static int Compare(int number1, int number2)
    {
        if (number1 > number2)
            return 1; // number1 is greater
        else if (number1 < number2)
            return -1;
        else
            return 0; 
    }
}
