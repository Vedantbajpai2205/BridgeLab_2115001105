using System;

class Nested
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int[] array = { 10, 20, 30, 40, 50 };

            try
            {
                int element = array[index];
                try
                {
                    int result = element / divisor;
                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format!");
        }
    }
}
