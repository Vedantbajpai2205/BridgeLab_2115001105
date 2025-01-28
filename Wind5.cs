using System;

class Wind5
{
    // Method to calculate the wind chill temperature
    public static double CalculateWindChill(double temperature, double windSpeed)
    {
		//given in question
        double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * windSpeed * 0.16;
        return windChill;
    }

    static void Main()
    {
        Console.Write("Enter the temperature in Fahrenheit : ");
        double temperature = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the wind speed in miles per hour: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        double windChill = CalculateWindChill(temperature, windSpeed);
        
        Console.WriteLine("The wind chill temperature is: " + windChill + "°F");
    }
}
