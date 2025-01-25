using System;

class Bonussalary
{
	//method for calculate salary with bonus
    static void Main()
    {
        const int employeeCount = 10;

        double[] salaries = new double[employeeCount];
        double[] yearsOfService = new double[employeeCount];
        double[] newSalaries = new double[employeeCount];
        double[] bonuses = new double[employeeCount];

        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        for (int i = 0; i < employeeCount; i++)
        {
           
            Console.WriteLine("Enter salary for employee " + (i + 1) + ": ");
            while (true)
            {
				double salary = double.Parse(Console.ReadLine());  
                if (salary > 0)
                {
                    salaries[i] = salary;
                    totalOldSalary += salary;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid salary. Please enter a valid positive number.");
                }
            }

            Console.WriteLine("Enter years of service for employee " + (i + 1) + ": ");
            while (true)
            {
				double years = double.Parse(Console.ReadLine());  
                if (years >= 0)
                {
                    yearsOfService[i] = years;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid years of service. Please enter a valid number greater than or equal to 0.");
                }
            }
        }

        for (int i = 0; i < employeeCount; i++)
        {
            double bonusPercentage = yearsOfService[i] > 5 ? 0.05 : 0.02;
            bonuses[i] = salaries[i] * bonusPercentage;
            newSalaries[i] = salaries[i] + bonuses[i];

            totalBonus += bonuses[i];
            totalNewSalary += newSalaries[i];
        }

        Console.WriteLine("\n--- Employee Salary and Bonus Details ---");
        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine("Employee:" + (i+1));
            Console.WriteLine("  Old Salary: " + salaries[i]);
            Console.WriteLine("  Bonus: " + bonuses[i]);
            Console.WriteLine("  New Salary: " + newSalaries[i]);
            Console.WriteLine();
        }

        Console.WriteLine("Total Bonus Payout: " + totalBonus);
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
}
