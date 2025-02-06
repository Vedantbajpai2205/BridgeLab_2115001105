using System;
using System.Collections.Generic;
class Faculty
{
    public string Name { get; set; }

    public Faculty(string name)
    {
        Name = name;
    }
	
    public void Display()
    {
        Console.WriteLine("Faculty Member: " + Name);
    }
}
class Department
{
    public string Name { get; set; }

    private List<Faculty> facultyMembers = new List<Faculty>();

    public Department(string name)
    {
        Name = name;
    }

    public void AddFaculty(Faculty faculty)
    {
        facultyMembers.Add(faculty);
    }

    public void DisplayFaculty()
    {
        Console.WriteLine("Faculty in Department: " + Name);
        foreach (var faculty in facultyMembers)
        {
            Console.WriteLine(faculty.Name);
        }
    }
}

class University
{
    private List<Department> departments = new List<Department>();

    public string Name { get; set; }

    public University(string name)
    {
        Name = name;
    }

    public void AddDepartment(Department department)
    {
        departments.Add(department);
    }

    public void DeleteUniversity()
    {
        Console.WriteLine("Deleting University: " + Name);
        departments.Clear();
    }

    public void DisplayDepartments()
    {
        Console.WriteLine("Departments in " + Name);
        foreach (var department in departments)
        {
            Console.WriteLine(department.Name);
        }
    }
    static void Main(string[] args)
    {
        Faculty faculty1 = new Faculty("Yash");
        Faculty faculty2 = new Faculty("Vedant");
        Faculty faculty3 = new Faculty("Raghav");

        Department csDepartment = new Department("Computer Science");
        csDepartment.AddFaculty(faculty1);
        csDepartment.AddFaculty(faculty2);

        Department mathDepartment = new Department("Mathematics");
        mathDepartment.AddFaculty(faculty3);

        University university = new University("Gla University");
        university.AddDepartment(csDepartment);
        university.AddDepartment(mathDepartment);

        university.DisplayDepartments();
        csDepartment.DisplayFaculty();
        mathDepartment.DisplayFaculty();

        faculty1.Display();
        faculty2.Display();
        faculty3.Display();

        university.DeleteUniversity();

        university.DisplayDepartments();
    }
}
