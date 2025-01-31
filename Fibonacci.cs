using System;

class Fibonacci
{
	static void Main(string[] args)
	{
	Console.WriteLine("Enter The Number: ");
	int n = int.Parse(Console.ReadLine());
	
	int a=0;
    int	b=1;
	int next=0;;
	CalculateFibonacci(a, b, next, n);
	}
	public static void CalculateFibonacci(int a, int b, int next, int n)
	{
		for(int i=0;i<=n;i++)
		{
			Console.Write(a + " ");
			next = a+b;
			a=b;
			b=next;
		}
	}
}