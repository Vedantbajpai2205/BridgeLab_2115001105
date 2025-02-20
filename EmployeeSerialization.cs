using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string department, double salary)
    {
        Id = id;
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class EmployeeSerialization
{
    private const string FilePath = "employees.dat";

    public static void SerializeEmployees(List<Employee> employees)
    {
        try
        {
            using (FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, employees);
                Console.WriteLine("Employees have been serialized and saved to the file.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error during serialization: " + ex.Message);
        }
    }

    public static List<Employee> DeserializeEmployees()
    {
        try
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("The file does not exist.");
                return null;
            }

            using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<Employee> employees = (List<Employee>)formatter.Deserialize(fs);
                return employees;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error during deserialization: " + ex.Message);
            return null;
        }
    }

    public static void DisplayEmployees(List<Employee> employees)
    {
        if (employees != null)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("ID: " + employee.Id + ", Name: " + employee.Name + ", Department: " + employee.Department + ", Salary: " + employee.Salary.ToString("C"));
            }
        }
        else
        {
            Console.WriteLine("No employees to display.");
        }
    }

    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee(1, "Yash", "HR", 50000),
            new Employee(2, "Vedant", "IT", 60000),
            new Employee(3, "Vatsal", "HOD", 55000)
        };

        SerializeEmployees(employees);

        List<Employee> deserializedEmployees = DeserializeEmployees();
        DisplayEmployees(deserializedEmployees);
    }
}
