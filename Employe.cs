using System;

namespace EmployeeDetails
{
    class Employee
    {
        // Properties (Attributes) of the Employee class
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        // Constructor to initialize the Employee object
        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        // Method to display the employee details
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Salary: " + Salary);
        }
    }

    class Employe
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("John Doe", 101, 55000.50);
            employee1.DisplayDetails();
        }
    }
}
