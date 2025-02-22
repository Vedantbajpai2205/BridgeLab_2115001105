using System;

public class SpaceReplacer
{
    public static string ReplaceMultipleSpaces(string text)
    {
        return System.Text.RegularExpressions.Regex.Replace(text, @"\s+", " ");
    }

    public static void Main()
    {
        string input = "This    is an    example   with   multiple   spaces.";
        string output = ReplaceMultipleSpaces(input);
        Console.WriteLine(output);
    }
}
