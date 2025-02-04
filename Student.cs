using System;

public class Student
{
    public static string UniversityName = "Gla University";
 
    private static int totalStudents = 0;

    public readonly string RollNumber;

    public string Name { get; set; }
    public string Grade { get; set; }

    public Student(string name, string rollNumber, string grade)
    {
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;

        totalStudents++;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }

    public void DisplayStudentDetails()
    {
		if(this is Student)
		{
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Grade: " + Grade);
        Console.WriteLine("University: " + UniversityName);
		}
		else
		{
			Console.WriteLine("Invalid Details! please enter correct details.");
		}
    }
    public static void Main(string[] args)
    {
        Student student1 = new Student("Yash", "123", "A");
        Student student2 = new Student("Vedant", "124", "B");

        Student.DisplayTotalStudents();

        student1.DisplayStudentDetails();
        student2.DisplayStudentDetails();
	}
}

