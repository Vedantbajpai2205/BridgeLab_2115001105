using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Modify
{
    static void Main(string[] args)
    {
        string inputFilePath = "employees.csv";
        string outputFilePath = "employees_updated.csv";

        ModifySalary(inputFilePath, outputFilePath);
    }

    static void ModifySalary(string inputFilePath, string outputFilePath)
    {
        if (File.Exists(inputFilePath))
        {
            var lines = File.ReadAllLines(inputFilePath);
            var updatedLines = new string[lines.Length];

            updatedLines[0] = lines[0];

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');

                if (values.Length == 4)
                {
                    string department = values[2];
                    double salary = double.Parse(values[3]);

                    if (department.Equals("IT", StringComparison.OrdinalIgnoreCase))
                    {
                        salary += salary * 0.10;
                        values[3] = salary.ToString("F2");
                    }

                    updatedLines[i] = string.Join(",", values);
                }
            }

            File.WriteAllLines(outputFilePath, updatedLines);
            Console.WriteLine($"Updated CSV file saved to {outputFilePath}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
