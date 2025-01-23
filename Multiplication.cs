using System;

class Multiplication
{
	static void Main()
	{
		Console.Write("Enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		for(int i=6;i<=9;i++)
		{
			Console.WriteLine(number + " * " + i + " = " + number*i );
		}
	}
}