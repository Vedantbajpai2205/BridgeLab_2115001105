using System;

class Numbers
{
	//method for calculate the 
	public static void findqueandRem()
	{
		Console.Write("Enter the first number: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int n2 = int.Parse(Console.ReadLine());

        // Calculate quotient and remainder
        int quotient = n1 / n2; 
        int remainder = n1 % n2;
		
		Console.WriteLine("The Quotient is " + n1 + "and Remainder is " + n2 + "of two numbers " + quotient + "and " + remainder);

	}
	static void Main(string[] args)
    {
        Numbers.findqueandRem();
    }
}