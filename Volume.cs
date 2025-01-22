using System;

class Volume
{
	//Method for Calculate the volume of earth
	public static void volumeEarth()
	{
        double radiusKm = 6378;

        // Conversion factor from km^3 to miles^3 (1 km = 0.621371 miles)
        double conversionFactor = Math.Pow(0.621371, 3);

        // Volume of the Earth (in km^3)
        double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

        // Volume of the Earth (in miles^3)
        double volumeMiles3 = volumeKm3 * conversionFactor;
		Console.WriteLine("The volume of earth in cubic kilometers is" + volumeKm3 + " and cubic miles is " + volumeMiles3) ;
	}
    static void Main(string[] args)
    {
        Volume.volumeEarth();
    }
}