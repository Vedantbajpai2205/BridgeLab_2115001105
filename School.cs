using System;
using System.Collections.Generic;

class Course
{
    public string CourseName { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    public Course(string courseName)
    {
        CourseName = courseName;
        EnrolledStudents = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        if (!EnrolledStudents.Contains(student))
        {
            EnrolledStudents.Add(student);
            student.EnrollInCourse(this); 
        }
    }

    public void DisplayEnrolledStudents()
    {
        Console.WriteLine("Course: " + CourseName);
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine(student.Name);
        }
    }
}

class Student
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

    public Student(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }

    public void EnrollInCourse(Course course)
    {
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
        }
    }

    public void DisplayCourses()
    {
        Console.WriteLine(Name + " is enrolled in:");
        foreach (var course in Courses)
        {
            Console.WriteLine(course.CourseName);
        }
    }
}

class School
{
    public string SchoolName { get; set; }
    public List<Student> Students { get; set; }

    public School(string schoolName)
    {
        SchoolName = schoolName;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        if (!Students.Contains(student))
        {
            Students.Add(student);
        }
    }

    public void DisplayStudents()
    {
        Console.WriteLine("Students in " + SchoolName + ":");
        foreach (var student in Students)
        {
            Console.WriteLine(student.Name);
        }
    }
    static void Main()
    {
        School school = new School("Gyan Niketan High");

        Student student1 = new Student("Yash");
        Student student2 = new Student("Vedant");

        school.AddStudent(student1);
        school.AddStudent(student2);

        Course course1 = new Course("Math 101");
        Course course2 = new Course("History 101");

        course1.EnrollStudent(student1);
        course1.EnrollStudent(student2);
        course2.EnrollStudent(student1);

        school.DisplayStudents();

        student1.DisplayCourses();
        student2.DisplayCourses();

        course1.DisplayEnrolledStudents();
        course2.DisplayEnrolledStudents();
    }
}
