using System;

class Simpleinterest
{
    // Method to calculate Simple Interest
    static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }

    static void Main()
    {
        Console.Write("Enter Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time in years: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = CalculateSimpleInterest(principal, rate, time);

        Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + " , Rate of Interest " + rate + " , and Time " + time);
    }
}