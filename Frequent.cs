using System;

class Frequent
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char mostFrequent = FindMostFrequentCharacter(input);

        Console.WriteLine("Most Frequent Character: " + mostFrequent);
    }

    static char FindMostFrequentCharacter(string input)
    {
        int[] frequency = new int[256]; 

        foreach (char c in input)
        {
            frequency[c]++;
        }

        char mostFrequentChar = '\0';
        int maxFrequency = 0;

        for (int i = 0; i < 256; i++)
        {
            if (frequency[i] > maxFrequency)
            {
                maxFrequency = frequency[i];
                mostFrequentChar = (char)i; 
            }
        }

        return mostFrequentChar;
    }
}
