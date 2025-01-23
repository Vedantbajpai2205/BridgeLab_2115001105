using System;

class Divisible
{
	//method for check divisible by 5 or not
	public static void checkDiv()
	{
		int n;
		
		Console.Write("Enter the number: ");
        n = int.Parse(Console.ReadLine());

		string result = (n % 5 == 0) ? "Yes" : "No";
		
		Console.WriteLine("Is the number " + n + "divisible by 5? " + result);
	}
	static void Main(string[] args)
    {
        Divisible.checkDiv();
    }
}