using System;

class LeapYear
{
    static void Main(string[] args)
    {
			Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            // Using multiple if-else statements
            Console.WriteLine("Using multiple if-else statements: ");
            CheckLeapYearMultipleIfElse(year);

            // Using a single if statement with logical operators
            Console.WriteLine("Using a single if statement with logical operators: ");
            CheckLeapYearSingleIf(year);
    }
	// method for check leap year using multiple if-else statements
    static void CheckLeapYearMultipleIfElse(int year)
    {
        // Check if the year is valid for the Gregorian calendar
        if (year < 1582)
        {
            Console.WriteLine("The year is not valid. The Gregorian calendar starts from 1582.");
            return;
        }
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine(year + " is a Leap Year.");
                }
                else
                {
                    Console.WriteLine(year + " is not a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
	//method for single if statement with multiple logical operators
    static void CheckLeapYearSingleIf(int year)
    {
        if (year < 1582)
        {
            Console.WriteLine("The year is not valid. The Gregorian calendar starts from 1582.");
            return;
        }

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}