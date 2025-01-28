using System;

public class Unit5
{
    public static double ConvertYardsToFeet(double yards)
    {
        double yardsToFeet = 3; 
        return yards * yardsToFeet;
    }

    public static double ConvertFeetToYards(double feet)
    {
        double feetToYards = 0.333333;
        return feet * feetToYards;
    }

    public static double ConvertMetersToInches(double meters)
    {
        double metersToInches = 39.3701; 
        return meters * metersToInches;
    }

    public static double ConvertInchesToMeters(double inches)
    {
        double inchesToMeters = 0.0254; 
        return inches * inchesToMeters;
    }

    public static double ConvertInchesToCentimeters(double inches)
    {
        double inchesToCentimeters = 2.54; 
        return inches * inchesToCentimeters;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter distance in yards:");
        double yards = Convert.ToDouble(Console.ReadLine());
        double feet = ConvertYardsToFeet(yards);
        Console.WriteLine(yards + " yards is equal to " + feet + " feet.");

        Console.WriteLine("Enter distance in feet:");
        double feetInput = Convert.ToDouble(Console.ReadLine());
        double yardsResult = ConvertFeetToYards(feetInput);
        Console.WriteLine(feetInput + " feet is equal to" + yardsResult + " yards.");

        Console.WriteLine("Enter distance in meters:");
        double meters = Convert.ToDouble(Console.ReadLine());
        double inches = ConvertMetersToInches(meters);
        Console.WriteLine(meters + " meters is equal to " + inches + " inches.");

        Console.WriteLine("Enter distance in inches:");
        double inchesInput = Convert.ToDouble(Console.ReadLine());
        double metersResult = ConvertInchesToMeters(inchesInput);
        Console.WriteLine(inchesInput + " inches is equal to " + metersResult + " meters.");

        Console.WriteLine("Enter distance in inches:");
        double inchesForCm = Convert.ToDouble(Console.ReadLine());
        double centimeters = ConvertInchesToCentimeters(inchesForCm);
        Console.WriteLine(inchesForCm + " inches is equal to " + centimeters + " centimeters.");
    }
}
