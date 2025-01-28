using System;

class Shortest
{
    static void Main(string[] args)
    {
        int[] heights = new int[11];

        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = int.Parse(Console.ReadLine());
        }

        int sum = FindSum(heights);

        double mean = FindMean(sum, heights.Length);

        int shortest = FindShortest(heights);

        int tallest = FindTallest(heights);

        Console.WriteLine("Heights of players in cms:");
        foreach (int height in heights)
        {
            Console.Write(height + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Sum of heights: " + sum + " cms");
        Console.WriteLine("Mean height: " + mean + " cms");
        Console.WriteLine("Shortest height: " + shortest + " cms");
        Console.WriteLine("Tallest height: " + tallest + " cms");
    }

    // Method to calculate the sum of all elements in the array
    public static int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    public static double FindMean(int sum, int numberOfPlayers)
    {
        return (double)sum / numberOfPlayers;
    }

    public static int FindShortest(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    public static int FindTallest(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }
}
