using System;

class SpringSeason
{
    static void Main()
    {
            Console.Write("Enter the month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter the day: ");
            int day = int.Parse(Console.ReadLine());

            // Check if the input is valid
            if (month < 1 || month > 12 || day < 1 || day > 31)
            {
                Console.WriteLine(" Please enter a valid month and day.");
                return;
            }

            // Determine if it is Spring Season
            bool isSpring = (month == 3 && day >= 20 && day <= 31) || (month == 4 && day >= 1 && day <= 30) || (month == 5 && day >= 1 && day <= 31) ||
                            (month == 6 && day >= 1 && day <= 20);

            if (isSpring)
            {
                Console.WriteLine("It is a Spring Season.");
            }
            else
            {
                Console.WriteLine("Not a Spring Season.");
            }
    }
}