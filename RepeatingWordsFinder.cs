using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class RepeatingWordsFinder
{
    public static void FindRepeatingWords(string text)
    {
        var words = Regex.Split(text.ToLower(), @"\W+"); 
        var wordCount = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }
        }

        var repeatingWords = new List<string>();
        foreach (var entry in wordCount)
        {
            if (entry.Value > 1)
            {
                repeatingWords.Add(entry.Key);
            }
        }

        Console.WriteLine(string.Join(", ", repeatingWords));
    }

    public static void Main()
    {
        string text = "This is is a repeated repeated word test.";
        FindRepeatingWords(text);
    }
}
