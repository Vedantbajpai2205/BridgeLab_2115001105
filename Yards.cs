using System;

class Yards
{
	//Method for find the distance in yards
	public static void yardDist()
	{
		
		Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Convert distance in feet to yards
        double distanceInYards = distanceInFeet / 3;

        // Convert distance in feet to miles
        double distanceInMiles = distanceInFeet / (3 * 1760);
		
		Console.WriteLine("Your distance in yards is " + distanceInYards + " and miles is " + distanceInMiles + " while in feet is " + distanceInFeet)
	}
    static void Main(string[] args)
    {
        Yards.yardDist();
    }
}