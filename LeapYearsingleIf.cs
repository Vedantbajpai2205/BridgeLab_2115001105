using System;

class LeapYearsingleIf
{
    static void Main(string[] args)
    {
			Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            CheckLeapYearSingleIf(year);
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