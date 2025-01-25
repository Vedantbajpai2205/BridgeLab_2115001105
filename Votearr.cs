using System;

class Vote
{
	//method for check that stident in class can vote or not
    static void Main()
    {
        int[] studentAges = new int[10];
		
        Console.WriteLine("Enter the age of 10 students:");
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write("Enter age for student: " + (i+1) + "\n");
            int age = int.Parse(Console.ReadLine());
            studentAges[i] = age;
        }

        foreach (int age in studentAges)
        {
            if (age < 0)
            {
                Console.WriteLine("Invalid age entered.");
            }
            else if (age >= 18)
            {
                Console.WriteLine("The student with the age " + age + " can vote.");
            }
            else
            {
                Console.WriteLine("The student with the age " + age + " cannot vote.");
            }
        }
    }
}