using System;

class Numbers
{
	//Method for find the quotient and remainder
	public static void quotientandremainder()
	{
		
		Console.Write("Enter the first number (dividend): ");
        int dividend = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number (divisor): ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        // Check if divisor is zero or not
        if (divisor == 0)
        {
            Console.WriteLine(" Division by zero is not allowed.");
        }
        else
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

           Console.WriteLine(" The Quotient is " + quotient + "and Remainder is " +  remainder + "of two numbers " + dividend + "and " + divisor);
        }

	}
    static void Main(string[] args)
    {
        Numbers.quotientandremainder();
    }
}