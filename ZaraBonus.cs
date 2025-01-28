using System;

class ZaraBonus
{
    // Method to determine salary and years of service using random values
    static double[,] GetEmployeeData()
    {
        Random rand = new Random();
        double[,] employeeData = new double[10, 2]; // 2D Array for 10 employees: [0] = Salary, [1] = Years of Service

        for (int i = 0; i < 10; i++)
        {
            employeeData[i, 0] = rand.Next(10000, 100000);  
            employeeData[i, 1] = rand.Next(1, 21); 
        }

        return employeeData;
    }

    static double[,] CalculateNewSalaryAndBonus(double[,] employeeData)
    {
        double[,] updatedData = new double[10, 3]; // 2D Array: [0] = Old Salary, [1] = New Salary, [2] = Bonus

        for (int i = 0; i < 10; i++)
        {
            double oldSalary = employeeData[i, 0];
            double yearsOfService = employeeData[i, 1];
            double bonusPercentage = (yearsOfService >= 5) ? 0.05 : 0.02;  
            double bonus = oldSalary * bonusPercentage;
            double newSalary = oldSalary + bonus;

            updatedData[i, 0] = oldSalary;     
            updatedData[i, 1] = newSalary;     
            updatedData[i, 2] = bonus;        
        }

        return updatedData;
    }

    // Method to calculate the sum of the old salary, new salary, and total bonus, then display it in a tabular format
    static void DisplaySummary(double[,] employeeData, double[,] updatedData)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Employee No | Old Salary | New Salary | Bonus");
        Console.WriteLine("-----------------------------------------------");

        for (int i = 0; i < 10; i++)
        {
            double oldSalary = updatedData[i, 0];
            double newSalary = updatedData[i, 1];
            double bonus = updatedData[i, 2];

            Console.WriteLine((i + 1) + " | " + oldSalary + " | " + newSalary + " | " + bonus);

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;
        }

        // Displaying the totals
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(" Total | " + totalOldSalary + " | " + totalNewSalary + " | " + totalBonus);
    }

    static void Main()
    {
        double[,] employeeData = GetEmployeeData();

        double[,] updatedData = CalculateNewSalaryAndBonus(employeeData);

        DisplaySummary(employeeData, updatedData);
    }
}
