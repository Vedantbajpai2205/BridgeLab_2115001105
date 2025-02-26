using System;
using System.Collections.Generic;
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

    public Student(int id, string name, int age, double marks)
    {
        ID = id;
        Name = name;
        Age = age;
        Marks = marks;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks}";
    }
}

class Object
{
    static void Main(string[] args)
    {
        string filePath = "students.csv";
        List<Student> students = ReadStudentsFromCSV(filePath);

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
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

                if (values.Length == 4)
                {
                    int id = int.Parse(values[0]);
                    string name = values[1];
                    int age = int.Parse(values[2]);
                    double marks = double.Parse(values[3]);

                    Student student = new Student(id, name, age, marks);
                    students.Add(student);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }

        return students;
    }
}
