using System;

class Count
{
    public static int CountSubstringOccurrences(string str, string substring)
    {
        int count = 0;
        int strLength = str.Length;
        int subLength = substring.Length;

        // Edge case: If the substring is longer than the string, return 0
        if (subLength > strLength)
        {
            return 0;
        }

        // Loop through the main string, comparing each substring of the same length as the target substring
        for (int i = 0; i <= strLength - subLength; i++)
        {
            bool match = true;

            // Compare the substring starting at index i with the target substring
            for (int j = 0; j < subLength; j++)
            {
                if (str[i + j] != substring[j])
                {
                    match = false;
                    break;
                }
            }

            // If a match is found, increment the count
            if (match)
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the main string:");
        string mainString = Console.ReadLine();

        Console.WriteLine("Enter the substring to search for:");
        string substring = Console.ReadLine();

        int occurrences = CountSubstringOccurrences(mainString, substring);
        Console.WriteLine("The substring " + substring + " occurs " + occurrences + " times.");
    }
}
