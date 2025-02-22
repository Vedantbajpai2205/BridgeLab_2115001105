using System;
using System.Text.RegularExpressions;

public class CapitalizedWordsExtractor
{
    public static void ExtractCapitalizedWords(string text)
    {
        var matches = Regex.Matches(text, @"\b[A-Z][a-z]*\b");
        foreach (var match in matches)
        {
            Console.Write(match + ", ");
        }
    }

    public static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        ExtractCapitalizedWords(text);
    }
}
