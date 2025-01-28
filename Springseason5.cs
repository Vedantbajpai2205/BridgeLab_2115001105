using System;

class Springseason5
{
    // Method to check if the given month and day fall within Spring Season (March 20 to June 20)
    static bool IsSpringSeason(int month, int day)
    {
        if ((month == 3 && day >= 20) || 
            (month == 4) || 
            (month == 5) || 
            (month == 6 && day <= 20))
        {
            return true;
        }
        return false;
    }

    static void Main(string[] args)
    {
        if (args.Length == 2)
        {
            int month = Convert.ToInt32(args[0]);
            int day = Convert.ToInt32(args[1]);

            if (IsSpringSeason(month, day))
            {
                Console.WriteLine("It's a Spring Season.");
            }
            else
            {
                Console.WriteLine("Not a Spring Season.");
            }
        }
        else
        {
            Console.WriteLine("Please provide two arguments: month and day.");
        }
    }
}
