using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

class Record
{
    static void Main(string[] args)
    {
        string filePath = "employees.csv";
        PrintTop5HighestPaidEmployees(filePath);
    }

    static void PrintTop5HighestPaidEmployees(string filePath)
    {
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);

            var employees = lines.Skip(1) 
                .Select(line => line.Split(','))
                .Where(values => values.Length == 4)
                .Select(values => new
                {
                    ID = int.Parse(values[0]),
                    Name = values[1],
                    Department = values[2],
                    Salary = double.Parse(values[3])
                })
                .OrderByDescending(e => e.Salary)
                .Take(5)
                .ToList();

            Console.WriteLine("Top 5 Highest Paid Employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary:F2}");
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

