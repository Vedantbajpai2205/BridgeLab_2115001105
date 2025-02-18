using System;
using System.Collections.Generic;

public abstract class JobRole
{
    public string RoleName { get; set; }
    public string RequiredSkills { get; set; }

    protected JobRole(string roleName, string requiredSkills)
    {
        RoleName = roleName;
        RequiredSkills = requiredSkills;
    }

    public abstract void ProcessResume();
}

public class SoftwareEngineer : JobRole
{
    public SoftwareEngineer(string roleName, string requiredSkills)
        : base(roleName, requiredSkills) { }

    public override void ProcessResume()
    {
        Console.WriteLine("Processing resume for Software Engineer: " + RoleName + ", Required Skills: " + RequiredSkills);
    }
}

public class DataScientist : JobRole
{
    public DataScientist(string roleName, string requiredSkills)
        : base(roleName, requiredSkills) { }

    public override void ProcessResume()
    {
        Console.WriteLine("Processing resume for Data Scientist: " + RoleName + ", Required Skills: "  + RequiredSkills);
    }
}

public class Resume<T> where T : JobRole
{
    public T JobRole { get; set; }
    public string ApplicantName { get; set; }
    public string ResumeContent { get; set; }

    public Resume(T jobRole, string applicantName, string resumeContent)
    {
        JobRole = jobRole;
        ApplicantName = applicantName;
        ResumeContent = resumeContent;
    }

    public void ScreenResume()
    {
        Console.WriteLine("Screening resume for " + ApplicantName);
        JobRole.ProcessResume();
    }
}

class Program5
{
    static void Main(string[] args)
    {
        var softwareEngineerRole = new SoftwareEngineer("Vedant", "C#, .NET, sql");
        var dataScientistRole = new DataScientist("Yash", "Python, ML, Data Analysis");

        var softwareEngineerResume = new Resume<SoftwareEngineer>(softwareEngineerRole, "Vedant", "Resume content for Vedant.");
        var dataScientistResume = new Resume<DataScientist>(dataScientistRole, "Yash", "Resume content for Yash.");

        List<JobRole> jobRoles = new List<JobRole> { softwareEngineerRole, dataScientistRole };

        softwareEngineerResume.ScreenResume();
        dataScientistResume.ScreenResume();

        Console.WriteLine("Screening all job roles:");
        foreach (var role in jobRoles)
        {
            role.ProcessResume();
        }
    }
}
