using System;

class PrimeNum
{
	static void Main(string[] args){
	Console.WriteLine("Enter The Number: ");
	int number = int.Parse(Console.ReadLine());
	
	bool result = FindPrime(number);
	if(result)
	{
		Console.Write("The Given Number " + number + " Is Prime Number.");
	}
	else
	{
		Console.Write("The Given Number " + number + "Is Not A Prime Number.");
	}
}
	
	static bool FindPrime(int number)
	{
		for(int i=2;i<number;i++)
		{
			if(number%i == 0)
			{
				return false;
			}
			
		}
		return true;
	}
}