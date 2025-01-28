using System;

class Tallest5
{
    static void Main()
    {
        int[] ages = new int[3];
        double[] heights = new double[3];

        Console.WriteLine("Enter the details for the friends:");

        Console.Write("Enter age of Amar: ");
        ages[0] = int.Parse(Console.ReadLine());
        Console.Write("Enter height of Amar in meters: ");
        heights[0] = double.Parse(Console.ReadLine());

        Console.Write("Enter age of Akbar: ");
        ages[1] = int.Parse(Console.ReadLine());
        Console.Write("Enter height of Akbar in meters: ");
        heights[1] = double.Parse(Console.ReadLine());

        Console.Write("Enter age of Anthony: ");
        ages[2] = int.Parse(Console.ReadLine());
        Console.Write("Enter height of Anthony in meters: ");
        heights[2] = double.Parse(Console.ReadLine());

        string youngestFriend = FindYoungest(ages);

        string tallestFriend = FindTallest(heights);

        Console.WriteLine("\nThe youngest friend is: " + youngestFriend);
        Console.WriteLine("The tallest friend is: " + tallestFriend);
    }

    // Method to find the youngest friend based on age
    static string FindYoungest(int[] ages)
    {
        int minAge = ages[0];
        string youngest = "Amar";

        if (ages[1] < minAge)
        {
            minAge = ages[1];
            youngest = "Akbar";
        }
        if (ages[2] < minAge)
        {
            minAge = ages[2];
            youngest = "Anthony";
        }

        return youngest;
    }

    // Method to find the tallest friend based on height
    static string FindTallest(double[] heights)
    {
        double maxHeight = heights[0];
        string tallest = "Amar";

        if (heights[1] > maxHeight)
        {
            maxHeight = heights[1];
            tallest = "Akbar";
        }
        if (heights[2] > maxHeight)
        {
            maxHeight = heights[2];
            tallest = "Anthony";
        }

        return tallest;
    }
}
