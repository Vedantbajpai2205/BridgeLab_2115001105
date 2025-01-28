using System;

class Distance5
{
    // Method to calculate Euclidean distance between two points
    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    // Method to find the equation of the line given two points
    static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1);
   
        double b = y1 - m * x1;

        return new double[] { m, b };
    }

    static void Main()
    {
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("The Euclidean distance between the points " + x1 + "," + y1 + " and " + x2 + "," + y2 + " is: " + distance);

        double[] lineEquation = FindLineEquation(x1, y1, x2, y2);

        Console.WriteLine("The equation of the line is: y = " + lineEquation[0] + "x" + lineEquation[1]);
    }
}
