using System;

namespace FactorialUsingRecursion
{
    class FactorialRecursion
    {
        static void Main(string[] args)
        {
            int number = GetInput();

            long factorialResult = CalculateFactorial(number);

            DisplayResult(number, factorialResult);
        }

        static int GetInput()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }

        
        static void DisplayResult(int number, long result)
        {
            Console.WriteLine("The factorial of " + number + " is " + result);
        }
    }
}
