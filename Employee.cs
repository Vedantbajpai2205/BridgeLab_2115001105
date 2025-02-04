using System;

class Employee
{
	public static string CompanyName{get; set;}
	private static int totalEmployees= 0;
	public static void DisplayTotalEmployees() 
	{
		Console.WriteLine("Total Employees : " + totalEmployees);
	}
	public string Name {get; set;}
	private readonly string Id;
	public string Designation{get; set;}
	
	public Employee(string name, string id, string designation)
	{
		this.Name = name;
		this.Id = id;
		this.Designation = designation;
		totalEmployees++;
	}
	public void DisplayEmployeesDetails()
	{
		if(this is Employee)
		{
			Console.WriteLine("Company Name :" + CompanyName);
			Console.WriteLine("Employee name : " + Name);
			Console.WriteLine("Employee id : " + Id);
			Console.WriteLine("Employee designation : " + Designation);
		}
		else
		{
			Console.WriteLine("Invalid Details, Please Enter Correct Details.");
		}
	}
	public static void Main(string[] args)
	{
		Employee.CompanyName = "Yo Grow";
		Console.WriteLine();
		Employee E1= new Employee("Yash","1234","Data Analyst");
		Employee E2= new Employee("Vedant","5678","Senior Analyst");
		E1.DisplayEmployeesDetails();
		Console.WriteLine();
		E2.DisplayEmployeesDetails();
		DisplayTotalEmployees();
	}
	
}