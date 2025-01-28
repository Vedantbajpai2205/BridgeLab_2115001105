using System;

public class Unit5_6
{
    // Method to convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double fahrenheitToCelsius = (fahrenheit - 32) * 5 / 9; 
        return fahrenheitToCelsius;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double celsiusToFahrenheit = (celsius * 9 / 5) + 32; 
        return celsiusToFahrenheit;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        double poundsToKilograms = 0.453592; 
        return pounds * poundsToKilograms;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilogramsToPounds = 2.20462; 
        return kilograms * kilogramsToPounds;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallonsToLiters = 3.78541; 
        return gallons * gallonsToLiters;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        double litersToGallons = 0.264172; 
        return liters * litersToGallons;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine(fahrenheit + "° Fahrenheit is equal to " + celsius + " ° Celsius.");

        Console.Write("Enter temperature in Celsius: ");
        double celsiusInput = Convert.ToDouble(Console.ReadLine());
        double fahrenheitResult = ConvertCelsiusToFahrenheit(celsiusInput);
        Console.WriteLine(celsiusInput + "° Celsius is equal to " + fahrenheitResult + " ° Fahrenheit.");

        Console.Write("Enter weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        double kilograms = ConvertPoundsToKilograms(pounds);
        Console.WriteLine(pounds + " pounds is equal to " + kilograms + " kilograms.");

        Console.Write("Enter weight in kilograms: ");
        double kilogramsInput = Convert.ToDouble(Console.ReadLine());
        double poundsResult = ConvertKilogramsToPounds(kilogramsInput);
        Console.WriteLine(kilogramsInput + " kilograms is equal to " + poundsResult + " pounds.");

        Console.Write("Enter volume in gallons: ");
        double gallons = Convert.ToDouble(Console.ReadLine());
        double liters = ConvertGallonsToLiters(gallons);
        Console.WriteLine(gallons + " gallons is equal to " + liters + " liters.");

        Console.Write("Enter volume in liters: ");
        double litersInput = Convert.ToDouble(Console.ReadLine());
        double gallonsResult = ConvertLitersToGallons(litersInput);
        Console.WriteLine(litersInput + " liters is equal to " + gallonsResult + " gallons.");
    }
}
