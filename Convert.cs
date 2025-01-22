using System;

class Convert
{
	//Method for Convert distance km in miles
	public static void convertDistance()
	{
        double km;
        Console.Write("Enter the distance in kilometers: ");
        km = Convert.ToDouble(Console.ReadLine());  

        // Conversion factor from kilometers to miles (1 mile = 1.6 km)
        double miles = km / 1.6;
		
		Console.WriteLine("The volume of earth in cubic kilometers is" + volumeKm3 + " and cubic miles is " + volumeMiles3) ;
	}
    static void Main(string[] args)
    {
        Convert.convertDistance("The total miles is " + miles + "mile for the given " + km + "km");
    }
}