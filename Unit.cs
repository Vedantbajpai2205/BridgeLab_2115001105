using System;

public class Unit
{
    // Method to convert kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        double kmToMiles = 0.621371;
        return km * kmToMiles;
    }

    public static double ConvertMilesToKm(double miles)
    {
        double milesToKm = 1.60934;
        return miles * milesToKm;
    }

    public static double ConvertMetersToFeet(double meters)
    {
        double metersToFeet = 3.28084; 
        return meters * metersToFeet;
    }

    public static double ConvertFeetToMeters(double feet)
    {
        double feetToMeters = 0.3048;
        return feet * feetToMeters;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter distance in kilometers:");
        double km = Convert.ToDouble(Console.ReadLine());
        double miles = ConvertKmToMiles(km);
        Console.WriteLine(km + " kilometers is equal to " + miles + " miles.");

        Console.WriteLine("Enter distance in miles:");
        double milesInput = Convert.ToDouble(Console.ReadLine());
        double kmResult = ConvertMilesToKm(milesInput);
        Console.WriteLine(milesInput + " miles is equal to " + kmResult + " kilometers.");

        Console.WriteLine("Enter distance in meters:");
        double meters = Convert.ToDouble(Console.ReadLine());
        double feet = ConvertMetersToFeet(meters);
        Console.WriteLine(meters + " meters is equal to " + feet + " feet.");

        Console.WriteLine("Enter distance in feet:");
        double feetInput = Convert.ToDouble(Console.ReadLine());
        double metersResult = ConvertFeetToMeters(feetInput);
        Console.WriteLine(feetInput + " feet is equal to " + metersResult + " meters.");
    }
}
