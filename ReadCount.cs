using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class ReadCount
{
    static void Main(string[] args)
    {
        string filePath = "employees.csv";

        int rowCount = CountRowsInCSV(filePath);

        Console.WriteLine($"Number of records (excluding header): {rowCount}");
    }

    static int CountRowsInCSV(string filePath)
    {
        int rowCount = 0;

        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);

            rowCount = lines.Length - 1;
        }

        return rowCount;
    }
}
