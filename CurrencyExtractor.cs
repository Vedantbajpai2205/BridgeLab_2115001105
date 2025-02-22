using System;
using System.Text.RegularExpressions;

public class CurrencyExtractor
{
    public static void ExtractCurrencies(string text)
    {
        var matches = Regex.Matches(text, @"\$\s?\d+(\.\d{2})?");
        foreach (var match in matches)
        {
            Console.Write(match + ", ");
        }
    }

    public static void Main()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";
        ExtractCurrencies(text);
    }
}
