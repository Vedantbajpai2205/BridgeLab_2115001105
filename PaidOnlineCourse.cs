using System;

public class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; }  

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public virtual void DisplayCourseInfo()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " hours");
    }
}

public class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Recorded: " + (IsRecorded ? "Yes" : "No"));
    }
}

public class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; }

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        Console.WriteLine("Fee: " + Fee);
        Console.WriteLine("Discount: " + Discount + "%");
        Console.WriteLine("Final Price: " + (Fee - (Fee * Discount / 100)));
    }
    public static void Main(string[] args)
    {
        Course basicCourse = new Course("Basic C# Programming", 40);
        OnlineCourse onlineCourse = new OnlineCourse("Advanced Python Programming", 60, "Udemy", true);
        PaidOnlineCourse paidCourse = new PaidOnlineCourse("OOPS with C#", 80, "Coursera", true, 199.99, 20);

        Console.WriteLine("Course Info Basic:");
        basicCourse.DisplayCourseInfo();
        Console.WriteLine();

        Console.WriteLine("Course Info Online:");
        onlineCourse.DisplayCourseInfo();
        Console.WriteLine();

        Console.WriteLine("Course Info Paid Online:");
        paidCourse.DisplayCourseInfo();
    }
}
