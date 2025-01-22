using System;

class Salary
{
	//method for calculate the total salary
	public static void totalSalary()
	{
		  double salary, bonus;

        Console.Write("Enter your salary: ");
        salary = double.Parse(Console.ReadLine());

        Console.Write("Enter your bonus: ");
        bonus = double.Parse(Console.ReadLine());

        // Calculate total income
        double totalIncome = salary + bonus;

        Console.WriteLine("The salary is INR  " + salary+ "and bonus is INR " + bonus + "Hence Total Income is INR " + totalIncome);

	}
	static void Main(string[] args)
    {
        Salary.totalSalary();
    }
}