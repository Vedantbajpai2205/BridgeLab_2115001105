using System;

class Bonus
{
    static void Main()
    {
        Console.Write("Enter the employee's salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the employee's years of job: ");
        int yearsOfjob = Convert.ToInt32(Console.ReadLine());

        // Check if years is more than 5
        if (yearsOfjob > 5)
        {
            // Calculate bonus 5% of salary
            double bonus = 0.05 * salary;
            Console.WriteLine("The employee's bonus amount is " + bonus);
        }
        else
        {
            // No bonus for less than or equal to 5 yr
            Console.WriteLine("The employee is not eligible for a bonus.");
        }
    }
}