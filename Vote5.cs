using System;

public class Vote5
{
    // Method to check if the student can vote based on age
    public static bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false;
        }

        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false; 
        }
    }

    public static void Main(string[] args)
    {
        int[] studentAges = new int[10];

        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write("Enter age of student " + (i + 1) + " :");
			int age = int.Parse(Console.ReadLine());
			
                bool canVote = CanStudentVote(age);
                if (canVote)
                {
                    Console.WriteLine("Student " + (i + 1) + " can vote.");
                }
                else
                {
                    Console.WriteLine("Student " + (i + 1) + " cannot vote.");
                }
            }
        }
    }

