using System;

public class LeapYear5
{
    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year)
    {
        if (year < 1582)
        {
            Console.WriteLine("Year must be greater than or equal to 1582.");
            return false;
        }

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
		int year = int.Parse(Console.ReadLine());
            if (IsLeapYear(year))
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year.");
            }
    }
}
