using System;

class Math5
{
    // Method to calculate various trigonometric functions (sine, cosine, tangent)
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double radians = angle * Math.PI / 180.0;

        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }

    static void Main()
    {
        Console.Write("Enter the angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] results = CalculateTrigonometricFunctions(angle);

        Console.WriteLine("Sine({angle}°) = " + results[0]);
        Console.WriteLine("Cosine({angle}°) = " + results[1]);
        Console.WriteLine("Tangent({angle}°) = " + results[2]);
    }
}
