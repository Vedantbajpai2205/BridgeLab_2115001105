using System;

class Grade
{
	//method for give grade and remarks according to marks
    static void Main()
    {
        float physicsMarks, chemistryMarks, mathsMarks;
        float totalMarks, percentage, averageMarks;
        string grade, remarks;

        Console.Write("Enter marks for Physics: ");
        physicsMarks = float.Parse(Console.ReadLine());

        Console.Write("Enter marks for Chemistry: ");
        chemistryMarks = float.Parse(Console.ReadLine());

        Console.Write("Enter marks for Maths: ");
        mathsMarks = float.Parse(Console.ReadLine());

        totalMarks = physicsMarks + chemistryMarks + mathsMarks;
		
        averageMarks = totalMarks / 3;

        percentage = (totalMarks / 300) * 100;
		
        if (percentage >= 80)
        {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            remarks = "Level 2, below but approacching agency-normalized standards";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            remarks = "Level 1, well below agency-normalized standards";
        }
		else if (percentage >= 40)
        {
            grade = "E";
            remarks = "Level 1-, too below agency-normalized standards";
        }
        else
        {
            grade = "R";
            remarks = "Remedial standards";
        }

        Console.WriteLine("--- Result ---");
        Console.WriteLine("Total Marks: " + totalMarks + "/300");
        Console.WriteLine("Average Marks: " + averageMarks);
        Console.WriteLine("Percentage: " + percentage + " %");
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Remarks: " + remarks);
    }
}
