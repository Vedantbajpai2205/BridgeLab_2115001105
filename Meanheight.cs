using System;

class Meanheight
{
	//method for calculate the mean height
    static void Main()
    {
        double[] heights = new double[11];
        double totalHeight = 0.0; 

        Console.WriteLine("Enter the heights of 11 players in meters:");
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Enter height for player " + (i + 1) + "\n");
            double height = double.Parse(Console.ReadLine());
            heights[i] = height;
            totalHeight += height; 
        }

        double meanHeight = totalHeight / heights.Length;

        Console.WriteLine("\nThe mean height of the football team is: " + meanHeight + " meters");
    }
}