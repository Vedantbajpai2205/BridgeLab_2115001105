using System;
using System.Collections.Generic;

public class BadWordCensor
{
    public static string CensorBadWords(string text, List<string> badWords)
    {
        foreach (var word in badWords)
        {
            text = text.Replace(word, "****", StringComparison.OrdinalIgnoreCase);
        }
        return text;
    }

    public static void Main()
    {
        string input = "This is a damn bad example with some stupid words.";
        List<string> badWords = new List<string> { "damn", "stupid" };
        
        string output = CensorBadWords(input, badWords);
        Console.WriteLine(output);
    }
}
