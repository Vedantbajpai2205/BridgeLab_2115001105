using System;

class Athlete5
{
    // Method to calculate the perimeter of the triangle
    static double CalculatePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    static double CalculateRounds(double perimeter)
    {
        double totalDistance = 5000; 
        return totalDistance / perimeter;
    }

    static void Main()
    {
        Console.Write("Enter the first side of the triangle in meters: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second side of the triangle in meters: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third side of the triangle in meters: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = CalculatePerimeter(side1, side2, side3);

        double round = CalculateRounds(perimeter);
		int rounds = Convert.ToInt32(round);

        Console.WriteLine("The athlete needs to complete " + rounds + " rounds to cover 5 km.");
    }
}
