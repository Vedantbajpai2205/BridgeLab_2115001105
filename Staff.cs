using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayRole()
    {
        Console.WriteLine("This is a general person.");
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine(Name + " is a Teacher, teaching " + Subject + ".");
    }
}

public class Student : Person
{
    public string Grade { get; set; }

    public Student(string name, int age, string grade)
        : base(name, age)
    {
        Grade = grade;
    }

    public override void DisplayRole()
    {
        Console.WriteLine(Name + " is a Student, studying in grade " + Grade + ".");
    }
}

public class Staff : Person
{
    public string Department { get; set; }

    public Staff(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }

    public override void DisplayRole()
    {
        Console.WriteLine(Name + " is a Staff member, working in the " + Department + " department.");
    }
    public static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Yash", 35, "Mathematics");
        Student student = new Student("Vedant", 16, "10th Grade");
        Staff staff = new Staff("Raghav", 45, "Administration");

        Console.WriteLine("Role Info Teacher:");
        teacher.DisplayRole();
        Console.WriteLine();

        Console.WriteLine("Role Info Student:");
        student.DisplayRole();
        Console.WriteLine();

        Console.WriteLine("Role Info Staff:");
        staff.DisplayRole();
    }
}
