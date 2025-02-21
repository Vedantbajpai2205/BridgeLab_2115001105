using System;

class FinallyBlock
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Operation completed.");
        }
    }
}
