using System;
using System.Collections.Generic;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public List<Course> EnrolledCourses { get; set; }

    public Student(int studentId, string name)
    {
        StudentId = studentId;
        Name = name;
        EnrolledCourses = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
        if (!EnrolledCourses.Contains(course))
        {
            EnrolledCourses.Add(course);
            course.AddStudent(this);  
        }
    }

    public string ToStringCustom()
    {
        return "Student: " + Name + " (ID: " + StudentId + ")";
    }
}
public class Professor
{
    public int ProfessorId { get; set; }
    public string Name { get; set; }
    public List<Course> TeachingCourses { get; set; }

    public Professor(int professorId, string name)
    {
        ProfessorId = professorId;
        Name = name;
        TeachingCourses = new List<Course>();
    }

    public void AssignProfessor(Course course)
    {
        if (!TeachingCourses.Contains(course))
        {
            TeachingCourses.Add(course);
            course.AssignProfessor(this);  
        }
    }

    public string ToStringCustom()
    {
        return "Professor: " + Name + " (ID: " + ProfessorId + ")";
    }
}
public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public List<Student> EnrolledStudents { get; set; }
    public Professor CourseProfessor { get; set; }

    public Course(int courseId, string courseName)
    {
        CourseId = courseId;
        CourseName = courseName;
        EnrolledStudents = new List<Student>();
        CourseProfessor = null;
    }

    public void AddStudent(Student student)
    {
        if (!EnrolledStudents.Contains(student))
        {
            EnrolledStudents.Add(student);
        }
    }

    public void AssignProfessor(Professor professor)
    {
        if (CourseProfessor == null)
        {
            CourseProfessor = professor;
        }
    }

    public string ToStringCustom()
    {
        string professorInfo = (CourseProfessor != null) ? ("Professor: " + CourseProfessor.Name) : "No professor assigned";
        return "Course: " + CourseName + " (ID: " + CourseId + "), " + professorInfo;
    }
    public static void Main(string[] args)
    {
        
        Student student1 = new Student(1, "Yash");
        Student student2 = new Student(2, "Vedant");

        Professor professor1 = new Professor(1, "Dr.Vansh");
        Professor professor2 = new Professor(2, "Dr. Vatsal");

        Course course1 = new Course(101, "OOPS Programming");
        Course course2 = new Course(102, "Data Structures");

        student1.EnrollCourse(course1);
        student2.EnrollCourse(course2); 

        professor1.AssignProfessor(course1); 
        professor2.AssignProfessor(course2);

        Console.WriteLine(course1.ToStringCustom()); 
        Console.WriteLine(course2.ToStringCustom()); 

        Console.WriteLine(student1.ToStringCustom());
        Console.WriteLine(student2.ToStringCustom());
        Console.WriteLine(professor1.ToStringCustom());
        Console.WriteLine(professor2.ToStringCustom());
    }
}
