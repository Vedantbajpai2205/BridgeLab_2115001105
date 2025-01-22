using System;

class Calc
{
	//Method for make Calculator
	public static void Calculator()
	{
		
		Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Perform the arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = (number2 != 0) ? number1 / number2 : double.NaN;  // Handling division by zero

		Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " + number1 + "and " + number2 + " is " + addition + "," + subtraction + " , " + multiplication + " and " + division);

        // Check for division by zero 
        if (number2 != 0)
        {
            Console.WriteLine($"Division: {number1} / {number2} = {division}");
        }
        else
        {
            Console.WriteLine("Division: Division by zero is not allowed.");
        }
	}
    static void Main(string[] args)
    {
        Calc.Calculator();
    }
}