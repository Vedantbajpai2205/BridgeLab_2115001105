using System;

class Rem5
{
    // Method to find the quotient and remainder of a division
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;

        return new int[] { quotient, remainder };
    }

    static void Main()
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        if (divisor == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        else
        {
            int[] result = FindRemainderAndQuotient(number, divisor);
            
            Console.WriteLine("The quotient is: " + result[0]);
            Console.WriteLine("The remainder is: " + result[1]);
        }
    }
}
