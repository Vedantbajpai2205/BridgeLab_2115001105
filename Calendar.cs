using System;

class Calendar
{
    // Method to get the name of the month
    static string GetMonthName(int month)
    {
        string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return months[month - 1];
    }

    // Method to check if the year is a leap year
    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // Method to get the number of days in a month
    static int GetDaysInMonth(int month, int year)
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        if (month == 2 && IsLeapYear(year))
        {
            return 29;
        }

        return daysInMonth[month - 1];
    }

    // Method to get the first day of the month using the Gregorian calendar formula
    static int GetFirstDayOfMonth(int month, int year)
    {
        // Gregorian calendar formula
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + (31 * m0) / 12) % 7;

        return d0;
    }

    // Method to display the calendar for the given month and year
    static void PrintCalendar(int month, int year)
    {
        string monthName = GetMonthName(month);
        int firstDay = GetFirstDayOfMonth(month, year);
        int totalDays = GetDaysInMonth(month, year);

        Console.WriteLine(monthName + year);

        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        Console.Write(new string(' ', firstDay * 4));

        for (int day = 1; day <= totalDays; day++)
        {
            Console.Write(day);  

            if ((firstDay + day) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the year (e.g., 2025): ");
        int year = int.Parse(Console.ReadLine());
        PrintCalendar(month, year);
    }
}
