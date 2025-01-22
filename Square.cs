using System;

class Square
{
	//Method for find the side of the square
	public static void sideSquare()
	{
		
		Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the side of the square
        double side = perimeter / 4;
		
		Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);

	}
    static void Main(string[] args)
    {
        Side.sideSquare();
    }
}