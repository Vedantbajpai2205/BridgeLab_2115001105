using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Print
{
    class Student
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
    }

    static void Main(string[] args)
    {
        string filePath = "students.csv";
        var students = ReadStudentsFromCSV(filePath);

        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}, Marks: {student.Marks:F2}");
        }
    }

    static List<Student> ReadStudentsFromCSV(string filePath)
    {
        var students = new List<Student>();
        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            var values = line.Split(',');

            if (values.Length == 4)
            {
                int id = int.Parse(values[0]);
                string name = values[1];
                int age = int.Parse(values[2]);
                double marks = double.Parse(values[3]);

                students.Add(new Student(id, name, age, marks));
            }
        }

        return students;
    }
}
