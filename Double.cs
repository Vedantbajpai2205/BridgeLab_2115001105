using System;

class Double
{
	//method for calculate the intOperation
	public static void doubleOpt()
	{
		double a, b, c;

        Console.Write("Enter the value of a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        c = double.Parse(Console.ReadLine());

        // Compute the operations
        double res1 = a + b * c;       
        double res2 = a * b + c;      
        double res3 = c + a / b;      
        double res4 = a % b + c; 

		Console.WriteLine("The results of Double Operations are " + res1 + ", " + res2 + "and " + res3 + ", " + res4);

	}
	static void Main(string[] args)
    {
        Double.doubleOpt();
    }
}