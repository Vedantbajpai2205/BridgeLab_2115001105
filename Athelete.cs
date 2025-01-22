using System;

class Athelete
{
	//method for calculate the total rounds for complete 5km
	public static void runAthelete()
	{
		Console.Write("Enter the length of the first side of the triangular park in meters: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the second side of the triangular park in meters: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the third side of the triangular park in meters: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the perimeter of the triangular park
        double perimeter = side1 + side2 + side3;

        //5 km = 5000 meters
        double totalDistance = 5000;

        // Calculate the number of rounds needed
        double rounds = totalDistance / perimeter;
		
		Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
	}
	static void Main(string[] args)
    {
        Athelete.runAthelete();
    }
}