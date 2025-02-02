using System;

class Student
{
    public int RollNumber { get; set; }

    protected string Name { get; set; }

    private double CGPA { get; set; }

    public Student(int rollNumber, string name, double cgpa)
    {
        RollNumber = rollNumber;
        Name = name;
        CGPA = cgpa;
    }

    public double GetCGPA()
    {
        return CGPA;
    }

    public void SetCGPA(double cgpa)
    {
        if (cgpa >= 0 && cgpa <= 4.0)
        {
            CGPA = cgpa;
        }
        else
        {
            Console.WriteLine("Invalid CGPA value. It should be between 0 and 4.0.");
        }
    }

    public void DisplayStudentDetails()
    {
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("CGPA: " + CGPA);
    }
}

class PostgraduateStudent : Student
{
    public PostgraduateStudent(int rollNumber, string name, double cgpa)
        : base(rollNumber, name, cgpa)
    {
    }

    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine("Postgraduate Student Details:");
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Name: " + Name); // Accessing the protected 'Name' from the base class
        Console.WriteLine("CGPA: " + GetCGPA()); // Using the public method to access CGPA
    }
}

class University
{
    static void Main()
    {
        Student student = new Student(1001, "John Doe", 3.8);
      
        student.DisplayStudentDetails();
        
        student.SetCGPA(3.9);
        Console.WriteLine("Updated CGPA: " + student.GetCGPA());
        Console.WriteLine();

        PostgraduateStudent pgStudent = new PostgraduateStudent(2001, "Alice Smith", 3.7);
   
        pgStudent.DisplayPostgraduateDetails();
    }
}
