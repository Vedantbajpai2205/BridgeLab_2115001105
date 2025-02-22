using System;
using System.Text.RegularExpressions;

public class LinkExtractor
{
    public static void ExtractLinks(string text)
    {
        var matches = Regex.Matches(text, @"https?://[a-zA-Z0-9-./?=&%]+");
        foreach (var match in matches)
        {
            Console.Write(match + ", ");
        }
    }

    public static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org for more info.";
        ExtractLinks(text);
    }
}

