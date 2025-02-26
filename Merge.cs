using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }
    public string Grade { get; set; }

    public Student(int id, string name, int age, double marks, string grade)
    {
        ID = id;
        Name = name;
        Age = age;
        Marks = marks;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"{ID},{Name},{Age},{Marks},{Grade}";
    }
}

class Merge
{
    static void Main(string[] args)
    {
        string students1FilePath = "students1.csv";
        string students2FilePath = "students2.csv";
        string outputFilePath = "merged_students.csv";

        List<Student> mergedStudents = MergeCSVFiles(students1FilePath, students2FilePath);
        WriteMergedDataToCSV(mergedStudents, outputFilePath);

        Console.WriteLine("Merged file created successfully: " + outputFilePath);
    }

    static List<Student> MergeCSVFiles(string students1FilePath, string students2FilePath)
    {
        List<Student> students1 = ReadStudentsFromCSV(students1FilePath);
        List<Student> students2 = ReadStudentsFromCSVWithMarksAndGrade(students2FilePath);

        var mergedStudents = from s1 in students1
                             join s2 in students2 on s1.ID equals s2.ID
                             select new Student(s1.ID, s1.Name, s1.Age, s2.Marks, s2.Grade);

        return mergedStudents.ToList();
    }

    static List<Student> ReadStudentsFromCSV(string filePath)
    {
        List<Student> students = new List<Student>();

        try
        {
            var lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++) 
            {
                var values = lines[i].Split(',');

                if (values.Length == 3)
                {
                    int id = int.Parse(values[0]);
                    string name = values[1];
                    int age = int.Parse(values[2]);

                    students.Add(new Student(id, name, age, 0, ""));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }

        return students;
    }

    static List<Student> ReadStudentsFromCSVWithMarksAndGrade(string filePath)
    {
        List<Student> students = new List<Student>();

        try
        {
            var lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');

                if (values.Length == 3)
                {
                    int id = int.Parse(values[0]);
                    double marks = double.Parse(values[1]);
                    string grade = values[2];

                    students.Add(new Student(id, "", 0, marks, grade));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }

        return students;
    }

    static void WriteMergedDataToCSV(List<Student> students, string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Age,Marks,Grade");

                foreach (var student in students)
                {
                    writer.WriteLine(student);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing file: " + ex.Message);
        }
    }
}
