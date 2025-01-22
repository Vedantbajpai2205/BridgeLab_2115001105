using System;

class Temp
{
	//method for temprature conversion form fahrenheit to celsius
	public static void tempConv()
	{
		double fahrenheit;

        Console.Write("Enter the temperature in Fahrenheit: ");
        fahrenheit = double.Parse(Console.ReadLine());

        // Perform the conversion to Celsius
        double celsius = (fahrenheit - 32) * 5 / 9;
		
		Console.WriteLine("The " + fahrenheit + "Fahrenheit is " + celsius + "celsius" );
	}
	static void Main(string[] args)
    {
        Temp.tempConv();
    }
}