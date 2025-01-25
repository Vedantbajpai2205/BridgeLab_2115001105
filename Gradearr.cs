using System;

class Gradearr
{
	//calculate the grade for student
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents;
        while (!int.TryParse(Console.ReadLine(), out numberOfStudents) || numberOfStudents <= 0)
        {
            Console.Write("Please enter a valid positive integer: ");
        }

        int[,] marks = new int[numberOfStudents, 3]; // 3 subjects: Physics, Chemistry, Maths
        double[] percentage = new double[numberOfStudents];
        char[] grade = new char[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("\nEnter marks for Student :" + (i+1));

            for (int j = 0; j < 3; j++)
            {
                string subject = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Maths";
                Console.Write("Enter marks for subject : ");

                while (!int.TryParse(Console.ReadLine(), out marks[i, j]) || marks[i, j] < 0)
                {
                    Console.Write("Invalid input! Please enter positive marks for subject: ");
                }
            }

            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentage[i] = (totalMarks / 3.0);

        if (percentage[i] >= 80)
        {
            grade[i] = 'A';
        }
        else if (percentage[i] >= 70)
        {
            grade[i] = 'B';
        }
        else if (percentage[i] >= 60)
        {
            grade[i] = 'C';
        }
        else if (percentage[i] >= 50)
        {
            grade[i] = 'D';
        }
		else if (percentage[i] >= 40)
        {
            grade[i] = 'E';
        }
        else
        {
            grade[i] = 'R';
        }
        }

        Console.WriteLine("\n{0,-15} {1,-10} {2,-10} {3,-10} {4,-15} {5,-10}", 
                          "Student", "Physics", "Chemistry", "Maths", "Percentage", "Grade");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("{0,-15} {1,-10} {2,-10} {3,-10} {4,-15:F2} {5,-10}", 
                              "Student "  + (i + 1) , marks[i, 0], marks[i, 1], marks[i, 2], percentage[i], grade[i]);
        }
    }
}
