using System;
using System.Collections.Generic;

public abstract class Employee
{
    private int employeeId;
    private string name;
    private double baseSalary;

    public Employee(int employeeId, string name, double baseSalary)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    public int EmployeeId
    {
        get { return employeeId; }
    }

    public string Name
    {
        get { return name; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
    }

    public abstract double CalculateSalary();

    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + employeeId + ", Name: " + name + ", Base Salary: " + baseSalary);
    }
}

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int employeeId, string name, double baseSalary)
        : base(employeeId, name, baseSalary)
    { }

    public override double CalculateSalary()
    {
        return BaseSalary;
    }
}

public class PartTimeEmployee : Employee
{
    private double hoursWorked;

    public PartTimeEmployee(int employeeId, string name, double baseSalary, double hoursWorked)
        : base(employeeId, name, baseSalary)
    {
        this.hoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return BaseSalary * hoursWorked;
    }
}

public interface IDepartment
{
    void AssignDepartment(string departmentName);
    string GetDepartmentDetails();
}

public class Department : IDepartment
{
    private string departmentName;

    public void AssignDepartment(string departmentName)
    {
        this.departmentName = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return departmentName;
    }
}

class Program1
{
    static void Main(string[] args)
    {
        FullTimeEmployee fullTimeEmp1 = new FullTimeEmployee(101, "Yash", 50000);
        PartTimeEmployee partTimeEmp1 = new PartTimeEmployee(102, "Vedant", 200, 80);

        List<Employee> employees = new List<Employee> { fullTimeEmp1, partTimeEmp1 };

        Department department = new Department();
        department.AssignDepartment("HR");

        foreach (Employee employee in employees)
        {
            employee.DisplayDetails();
            Console.WriteLine("Salary: " + employee.CalculateSalary());
            Console.WriteLine("Department: " + department.GetDepartmentDetails() + " \n");
        }
    }
}
