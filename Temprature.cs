using System;

class Temprature
{
	//method for temprature conversion
	public static void tempConverstion()
	{
		double celsius;

        Console.Write("Enter the temperature in Celsius: ");
        celsius = double.Parse(Console.ReadLine());

        // Perform the conversion to Fahrenheit
        double fahrenheitResult = (celsius * 9 / 5) + 32;


		Console.WriteLine("The" + celsius + " celsius is " + fahrenheitResult + " Fahrenheit");
	}
	static void Main(string[] args)
    {
        Temprature.tempConverstion();
    }
}