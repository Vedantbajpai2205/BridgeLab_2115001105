using System;

    class DateCompare
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first date (yyyy-MM-dd): ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the second date (yyyy-MM-dd): ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            int comparisonResult = DateTime.Compare(firstDate, secondDate);

            if (comparisonResult < 0)
            {
                Console.WriteLine("The first date is before the second date.");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("The first date is after the second date.");
            }
            else
            {
                Console.WriteLine("The first date is the same as the second date.");
            }

            int comparisonResult2 = firstDate.CompareTo(secondDate);

            if (comparisonResult2 < 0)
            {
                Console.WriteLine("Using CompareTo: The first date is before the second date.");
            }
            else if (comparisonResult2 > 0)
            {
                Console.WriteLine("Using CompareTo: The first date is after the second date.");
            }
            else
            {
                Console.WriteLine("Using CompareTo: The first date is the same as the second date.");
            }

            if (firstDate < secondDate)
            {
                Console.WriteLine("Using direct comparison: The first date is before the second date.");
            }
            else if (firstDate > secondDate)
            {
                Console.WriteLine("Using direct comparison: The first date is after the second date.");
            }
            else
            {
                Console.WriteLine("Using direct comparison: The first date is the same as the second date.");
            }
        }
    }
