using System;

class Tallest
{
    static void Main()
    {
        int[] ages = new int[3];
        double[] heights = new double[3];

        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter age for friend " + (i + 1) + " (Amar, Akbar, Anthony): ");
            while (true)
            {
				int age = int.Parse(Console.ReadLine());
                if (age > 0)
                {
                    ages[i] = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive age.");
                }
            }

            Console.WriteLine("Enter height for friend " + (i + 1) + " (Amar, Akbar, Anthony): ");
            while (true)
            {
				double height = double.Parse(Console.ReadLine());
                if (height > 0)
                {
                    heights[i] = height;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive height.");
                }
            }
        }

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }

            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        string[] friends = { "Amar", "Akbar", "Anthony" };
        Console.WriteLine("\nThe youngest friend is " + friends[youngestIndex]+ " with age " + ages[youngestIndex]);
        Console.WriteLine("The tallest friend is " + friends[tallestIndex] + " with height " + heights[tallestIndex] + " meters.");
    }
}
