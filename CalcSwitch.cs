using System;

    class CalcSwitch
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double second = double.Parse(Console.ReadLine());

            Console.Write("Enter the operator (+, -, *, /): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("Result: " + (first + second));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (first - second));
                    break;
                case "*":
                    Console.WriteLine("Result: " + (first * second));
                    break;
                case "/":
                    if (second != 0)
                    {
                        Console.WriteLine("Result: " + (first / second));
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Operator.");
                    break;
            }
        }
    }
