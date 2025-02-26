using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Xml;

public class Student2
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
}

class Convert
{
    static void Main(string[] args)
    {
        string jsonFilePath = "students.json";
        string csvFilePath = "students.csv";

        ConvertJsonToCsv(jsonFilePath, csvFilePath);

        ConvertCsvToJson(csvFilePath, "students_converted.json");
    }

    public static void ConvertJsonToCsv(string jsonFilePath, string csvFilePath)
    {
        try
        {
            string jsonData = File.ReadAllText(jsonFilePath);
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonData);

            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(students);
            }

            Console.WriteLine("JSON successfully converted to CSV.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error converting JSON to CSV: {ex.Message}");
        }
    }

    public static void ConvertCsvToJson(string csvFilePath, string jsonFilePath)
    {
        try
        {
            List<Student> students;
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                students = new List<Student>(csv.GetRecords<Student>());
            }

            string jsonData = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonData);

            Console.WriteLine("CSV successfully converted to JSON.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error converting CSV to JSON: {ex.Message}");
        }
    }
}

