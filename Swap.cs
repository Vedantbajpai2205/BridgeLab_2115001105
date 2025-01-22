using System;

class Swap
{
	//method for calculate the total salary
	public static void swapTwo()
	{
		int n1,n2,temp;
		
		Console.Write("Enter the first number: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        n2 = int.Parse(Console.ReadLine());

        // Swap the numbers using a temporary variable
        temp = n1;
        n1 = n2;
        n2 = temp;
		
		Console.WriteLine("The Swapped Num are " + n1 + "and " + n2);
	}
	static void Main(string[] args)
    {
        Swap.swapTwo();
    }
}