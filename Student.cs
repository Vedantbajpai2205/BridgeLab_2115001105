using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Student
{
    static void Main(string[] args)
    {
        string filePath = "students.csv";

        FilterAndPrintStudents(filePath);
    }

    static void FilterAndPrintStudents(string filePath)
    {
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);

            Console.WriteLine("ID,Name,Age,Marks");

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');

                if (values.Length == 4)
                {
                    int id = int.Parse(values[0]);
                    string name = values[1];
                    int age = int.Parse(values[2]);
                    double marks = double.Parse(values[3]);

                    if (marks > 80)
                    {
                        Console.WriteLine($"{id},{name},{age},{marks:F2}");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
