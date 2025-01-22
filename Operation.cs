using System;

class Operation
{
	//method for calculate the intOperation
	public static void intOperation()
	{
		int a, b, c;
        Console.Write("Enter the value of a: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        c = int.Parse(Console.ReadLine());

        // Compute the operations
        int res1 = a + b * c;  
        int res2 = a * b + c;       
        int res3 = c + a / b;      
        int res4 = a % b + c;    

		Console.WriteLine("The results of Int Operations are " + res1 + ", " + res2 + "and " + res3 + ", " + res4);

	}
	static void Main(string[] args)
    {
        Operation.intOperation();
    }
}