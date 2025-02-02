using System;

class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; }  
    public double Fee { get; set; }

    public static string InstituteName = "Tech Academy";  

    public Course(string courseName, int duration, double fee)
    {
        CourseName = courseName;
        Duration = duration;
        Fee = fee;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " days");
        Console.WriteLine("Fee: " + Fee.ToString("F2"));
        Console.WriteLine("Institute Name: " + InstituteName);
    }

    public static void UpdateInstituteName(string newInstituteName)
    {
        InstituteName = newInstituteName;
        Console.WriteLine("Institute name updated to: " + InstituteName);
    }
}

class OnlineCourse
{
    static void Main()
    {
        Course course1 = new Course("C# Programming", 30, 199.99);
        Course course2 = new Course("Web Development", 45, 249.99);
        Course course3 = new Course("Data Science", 60, 499.99);

        Console.WriteLine("Course 1 Details:");
        course1.DisplayCourseDetails();
        Console.WriteLine();

        Console.WriteLine("Course 2 Details:");
        course2.DisplayCourseDetails();
        Console.WriteLine();

        Console.WriteLine("Course 3 Details:");
        course3.DisplayCourseDetails();
        Console.WriteLine();

        Course.UpdateInstituteName("Global Learning Hub");

        Console.WriteLine("\nAfter updating the institute name:");

        Console.WriteLine("Course 1 Details:");
        course1.DisplayCourseDetails();
        Console.WriteLine();

        Console.WriteLine("Course 2 Details:");
        course2.DisplayCourseDetails();
        Console.WriteLine();

        Console.WriteLine("Course 3 Details:");
        course3.DisplayCourseDetails();
    }
}
