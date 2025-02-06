using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }

    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public string GetEmployeeDetails()
    {
        return "Employee Name: " + Name + ", Position: " + Position;
    }
}

class Department
{
    public string DepartmentName { get; set; }
    public List<Employee> Employees { get; set; }
    public Department(string departmentName)
    {
        DepartmentName = departmentName;
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public void ShowEmployees()
    {
        Console.WriteLine("Department: " + DepartmentName);
        foreach (var employee in Employees)
        {
            Console.WriteLine(employee.GetEmployeeDetails());
        }
    }
}

class Company
{
    public string CompanyName { get; set; }
    public List<Department> Departments { get; set; }

    public Company(string companyName)
    {
        CompanyName = companyName;
        Departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }

    public void ShowCompanyDetails()
    {
        Console.WriteLine("Company: " + CompanyName);
        foreach (var department in Departments)
        { 
            department.ShowEmployees();
        }
    }
	static void Main()
    {
        Company company = new Company("Capgemini");

        Department devDept = new Department("Development");
        Department DaDept = new Department("Data Analyst");

        devDept.AddEmployee(new Employee("Yash", "Software Engineer"));
        devDept.AddEmployee(new Employee("Vedant", "Senior Developer"));
        DaDept.AddEmployee(new Employee("Raghav", "Analyst"));

        company.AddDepartment(devDept);
        company.AddDepartment(DaDept);

        company.ShowCompanyDetails();
    }
}
