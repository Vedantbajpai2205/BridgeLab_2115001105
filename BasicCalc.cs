using System;

namespace BasicCalculator
{
    class BasicCalc
    {
        // Main function for made a Calculator
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter the number corresponding to the operation: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = Divide(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation choice.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine("The result is: " + result);
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
