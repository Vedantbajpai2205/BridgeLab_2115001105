using System;

class Area
{
	//Method for Calculate the area of triangle
	public static void areaTriangle()
	{
        Console.Write("Enter the base of the triangle in inches: ");
        double baseInInches = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle in inches: ");
        double heightInInches = Convert.ToDouble(Console.ReadLine());

        // Calculate area in square inches
        double areaInSquareInches = 0.5 * baseInInches * heightInInches;

        // Convert square inches to square centimeters
        double areaInSquareCentimeters = areaInSquareInches * 6.4516;

		Console.WriteLine("The height of the triangle in square inches is" + areaInSquareInches + " and in square centimeter is " + areaInSquareCentimeters) ;
	}
    static void Main(string[] args)
    {
        Area.areaTriangle();
    }
}