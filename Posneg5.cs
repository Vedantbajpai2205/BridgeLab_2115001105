using System;

class Posneg5
{
    // Method to check whether the number is positive, negative, or zero
    static int CheckNumber(int number)
    {
        if (number < 0)
        {
            return -1; 
        }
        else if (number > 0)
        {
            return 1; 
        }
        else
        {
            return 0;
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = CheckNumber(number);

        if (result == -1)
        {
            Console.WriteLine("The number is negative.");
        }
        else if (result == 1)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
