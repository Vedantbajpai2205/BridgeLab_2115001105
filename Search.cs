using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Search
{
    static void Main(string[] args)
    {
        string filePath = "employees.csv";
        string searchName = "Yash";

        SearchEmployeeByName(filePath, searchName);
    }

    static void SearchEmployeeByName(string filePath, string name)
    {
        bool found = false;

        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');

                if (values.Length == 4)
                {
                    string employeeName = values[1];

                    if (employeeName.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        string department = values[2];
                        string salary = values[3];

                        Console.WriteLine($"Employee found: {name}");
                        Console.WriteLine($"Department: {department}");
                        Console.WriteLine($"Salary: {salary}");
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"Employee {name} not found.");
            }
        }
    }
}

