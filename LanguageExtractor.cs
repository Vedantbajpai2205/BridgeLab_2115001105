using System;
using System.Text.RegularExpressions;

public class LanguageExtractor
{
    public static void ExtractLanguages(string text)
    {
        var matches = Regex.Matches(text, @"\b(Java|Python|JavaScript|Go|C\+\+|C#|Ruby|Swift|PHP|Kotlin|Rust|Scala)\b");
        foreach (var match in matches)
        {
            Console.Write(match + ", ");
        }
    }

    public static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        ExtractLanguages(text);
    }
}
