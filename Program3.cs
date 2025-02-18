using System;
using System.Collections.Generic;
public abstract class CourseType
{
    public string CourseName { get; set; }
    public string Department { get; set; }

    protected CourseType(string courseName, string department)
    {
        CourseName = courseName;
        Department = department;
    }

    public abstract void DisplayInfo();
}
public class ExamCourse : CourseType
{
    public int ExamWeightage { get; set; }

    public ExamCourse(string courseName, string department, int examWeightage) 
        : base(courseName, department)
    {
        ExamWeightage = examWeightage;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Exam Course - Name: " + CourseName + ", Department: " + Department + ", Exam Weightage: " + ExamWeightage + "%");
    }
}
public class AssignmentCourse : CourseType
{
    public int AssignmentWeightage { get; set; }

    public AssignmentCourse(string courseName, string department, int assignmentWeightage) 
        : base(courseName, department)
    {
        AssignmentWeightage = assignmentWeightage;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Assignment Course - Name: " + CourseName + ", Department: " + Department + ", Assignment Weightage: " + AssignmentWeightage + "%");
    }
}
public class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();
    public void AddCourse(T course)
    {
        courses.Add(course);
        Console.WriteLine(course.CourseName + " added to courses.");
    }
    public void DisplayAllCourses()
    {
        Console.WriteLine("Courses offered:");
        foreach (T course in courses)
        {
            course.DisplayInfo();
        }
    }
}

class Program3
{
    static void Main(string[] args)
    {
        ExamCourse mathCourse = new ExamCourse("Dsa", "CSE", 90);
        AssignmentCourse historyCourse = new AssignmentCourse("Physics", "Science", 70);
        Course<CourseType> courseCatalog = new Course<CourseType>();
        courseCatalog.AddCourse(mathCourse);
        courseCatalog.AddCourse(historyCourse);
        courseCatalog.DisplayAllCourses();
    }
}