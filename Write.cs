using System;
using System.IO;

class Write
{
    static void Main(string[] args)
    {
        string filePath = "employees.csv";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("ID,Name,Department,Salary");
            writer.WriteLine("1,Yash,HR,55000");
            writer.WriteLine("2,Vedant,IT,75000");
            writer.WriteLine("3,Vatsal,Finance,68000");
            writer.WriteLine("4,Suyash,Marketing,60000");
            writer.WriteLine("5,Tushar,Sales,50000");
        }

        Console.WriteLine($"CSV file created at {filePath}");
    }
}