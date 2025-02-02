using System;

class Employee
{
    public int EmployeeID { get; set; }
    protected string Department { get; set; }
    private double Salary { get; set; }

    public Employee(int employeeID, string department, double salary)
    {
        EmployeeID = employeeID;
        Department = department;
        Salary = salary;
    }

    public void ModifySalary(double newSalary)
    {
        if (newSalary > 0)
        {
            Salary = newSalary;
        }
        else
        {
            Console.WriteLine("Invalid salary value.");
        }
    }

    public double GetSalary()
    {
        return Salary;
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee ID: " + EmployeeID);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Manager : Employee
{
    public Manager(int employeeID, string department, double salary)
        : base(employeeID, department, salary)
    {
    }

    public void DisplayManagerDetails()
    {
        Console.WriteLine("Manager Details:");
        Console.WriteLine("Employee ID: " + EmployeeID);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Salary: " + GetSalary());
    }
}

class EmployeeRecord
{
    static void Main()
    {
        Employee employee = new Employee(101, "HR", 50000);
        employee.DisplayEmployeeDetails();
        employee.ModifySalary(55000);
        Console.WriteLine("Updated Salary: " + employee.GetSalary());
        Console.WriteLine();

        Manager manager = new Manager(201, "IT", 80000);
        manager.DisplayManagerDetails();
    }
}
