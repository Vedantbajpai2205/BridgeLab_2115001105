using System;

class Interest
{
	//method for calculate simple interest
	public static void simpInterest()
	{
		Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());
		
        Console.Write("Enter the Rate of interest in %: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time period in years: ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = (principal * rate * time) / 100;
		
		Console.WriteLine("The Simple Interest is " + simpleInterest + "for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
	}
	static void Main(string[] args)
    {
        Interest.simpInterest();
    }
}