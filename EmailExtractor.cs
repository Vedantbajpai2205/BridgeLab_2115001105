using System;
using System.Text.RegularExpressions;

public class EmailExtractor
{
    public static void ExtractEmails(string text)
    {
        var matches = Regex.Matches(text, @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");
        foreach (var match in matches)
        {
            Console.WriteLine(match.ToString());
        }
    }

    public static void Main()
    {
        string text = "Contact us at support@example.com and info@company.org";
        ExtractEmails(text);
    }
}
