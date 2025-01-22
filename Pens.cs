using System;

class Pens
{
	//Method for Calculate pens per student and remaining pens
	public static void penPerstudent()
	{
		int totalPens = 14;
        int totalStudents = 3;

        int pensPerStudent = totalPens / totalStudents; 
        int remainingPens = totalPens % totalStudents; 
		Console.WriteLine("The Pen per Student is "+ penPerstudent + "and the remaining pen not distributed is" + remainingPens);
	}
    static void Main(string[] args)
    {
        Pens.penPerstudent();
    }
}