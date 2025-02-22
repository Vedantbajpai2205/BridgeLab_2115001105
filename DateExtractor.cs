using System;
using System.Text.RegularExpressions;

public class DateExtractor
{
    public static void ExtractDates(string text)
    {
        var matches = Regex.Matches(text, @"\b\d{2}/\d{2}/\d{4}\b");
        foreach (var match in matches)
        {
            Console.Write(match + ", ");
        }
    }

    public static void Main()
    {
        string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
        ExtractDates(text);
    }
}
