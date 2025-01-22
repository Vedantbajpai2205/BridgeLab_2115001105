using System;

class Average
{
    static void Main(string[] args)
    {
        int marksMath = 94;
        int marksPhysics = 95;
		int marksChemistry = 96;

        int aveMarks = (marksMath+marksPhysics+marksChemistry)/3;
		int maxMarks=300;
		double percentage = (aveMarks/maxMarks)*100;

        Console.WriteLine("Sam’s average mark in PCM is " + percentage + "%");
    }
}