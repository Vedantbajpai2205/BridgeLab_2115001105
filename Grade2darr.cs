using System;

class Grade2darr
{
	//method for calculate marks and grade foe each student using 2d array
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents;
        while (!int.TryParse(Console.ReadLine(), out numberOfStudents) || numberOfStudents <= 0)
        {
            Console.Write("Invalid input! Please enter a valid positive number of students: ");
        }

        double[,] studentData = new double[numberOfStudents, 5]; 

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("\nEnter marks for Student :" +(i+1));

            for (int j = 0; j < 3; j++) 
            {
                string subject = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Maths";
                Console.Write("Enter marks for subject: ");

                while (!double.TryParse(Console.ReadLine(), out studentData[i, j]) || studentData[i, j] < 0)
                {
                    Console.Write("Invalid input! Please enter positive marks for subject : ");
                }
            }

            double totalMarks = studentData[i, 0] + studentData[i, 1] + studentData[i, 2];
            studentData[i, 3] = (totalMarks / 300) * 100; 

            if (studentData[i, 3] >= 80)
        {
            studentData[i, 4] = 'A';
        }
        else if (studentData[i, 3] >= 70)
        {
            studentData[i, 4] = 'B';
        }
        else if (studentData[i, 3] >= 60)
        {
            studentData[i, 4] = 'C';
        }
        else if (studentData[i, 3] >= 50)
        {
            studentData[i, 4] = 'D';
        }
		else if (studentData[i, 3] >= 40)
        {
            studentData[i, 4] = 'E';
        }
        else
        {
            studentData[i, 4] = 'R';
        }
        }

        Console.WriteLine("\n{0,-15} {1,-10} {2,-10} {3,-10} {4,-15} {5,-10}", 
                          "Student", "Physics", "Chemistry", "Maths", "Percentage", "Grade");

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("{0,-15} {1,-10:F2} {2,-10:F2} {3,-10:F2} {4,-15:F2} {5,-10}", 
                              "Student " + (i + 1) , studentData[i, 0], studentData[i, 1], studentData[i, 2], 
                              studentData[i, 3], (char)studentData[i, 4]);
        }
    }
}
