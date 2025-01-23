using System;

class Smallest
{
	//method for check the  smallest
	public static void checkSmall()
	{
		int n1,n2,n3;
		
		Console.Write("Enter the first number: ");
        n1 = int.Parse(Console.ReadLine());
		
		Console.Write("Enter the second number: ");
        n2 = int.Parse(Console.ReadLine());
		
		Console.Write("Enter the third number: ");
        n3 = int.Parse(Console.ReadLine());

		string result = (n1 < n2 && n1 < n3) ? "Yes" : "No";
		
		Console.WriteLine("Is the first number the smallest? " + result);
	}
	static void Main(string[] args)
    {
        Smallest.checkSmall();
    }
}