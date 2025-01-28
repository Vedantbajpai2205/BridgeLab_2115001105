using System;

class Random5
{
    static void Main(string[] args)
    {
        int[] randomNumbers = Generate4DigitRandomArray(5);

        Console.WriteLine("Generated 4-digit random numbers:");
        foreach (int number in randomNumbers)
        {
            Console.WriteLine(number);
        }

        double[] results = FindAverageMinMax(randomNumbers);

        Console.WriteLine("\nAverage: " + results[0]);
        Console.WriteLine("Minimum: " + results[1]);
        Console.WriteLine("Maximum: " + results[2]);
    }

    // Method to generate an array of 4-digit random numbers
    public static int[] Generate4DigitRandomArray(int size)
    {
        Random rand = new Random();
        int[] randomArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            randomArray[i] = rand.Next(1000, 10000);
        }

        return randomArray;
    }

    // Method to find the average, min, and max values of an array
    public static double[] FindAverageMinMax(int[] numbers)
    {
        double average = 0;
        int min = numbers[0];
        int max = numbers[0];

        foreach (int num in numbers)
        {
            average += num;
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        average /= numbers.Length;

        return new double[] { average, min, max };
    }
}
