using System;

    class DateArth
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a date (yyyy-MM-dd): ");
            DateTime inputDate = DateTime.Parse(Console.ReadLine());

            DateTime resultDate = inputDate
                .AddDays(7)         
                .AddMonths(1)       
                .AddYears(2);       

            resultDate = resultDate.AddDays(-3 * 7); 

            Console.WriteLine("Final date after adjustments: " + resultDate.ToString("yyyy-MM-dd"));
        }
    }

