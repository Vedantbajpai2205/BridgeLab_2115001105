using System;

class Division
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the numerator: ");
            string numeratorInput = Console.ReadLine();
            int numerator = int.Parse(numeratorInput);

            Console.Write("Enter the denominator: ");
            string denominatorInput = Console.ReadLine();
            int denominator = int.Parse(denominatorInput);

            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
