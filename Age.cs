using System;

class Age
{
	//Method for find the age
	public static void calAge()
	{
		int birthYear = 2000; 
        int currentYear = 2024; 
		
		//calculate age
        int age = currentYear - birthYear; 
		 
		Console.WriteLine(" Harry's age in 2024 is " + age);

	}
    static void Main(string[] args)
    {
        Age.calAge();
    }
}