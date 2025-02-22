using System;
using System.Text.RegularExpressions;

public class HexColorValidator
{
    public static string ValidateHexColor(string hexColor)
    {
        if (Regex.IsMatch(hexColor, @"^#[0-9A-Fa-f]{6}$"))
        {
            return "Valid";
        }
        else
        {
            return "Invalid";
        }
    }

    public static void Main()
    {
        Console.WriteLine(ValidateHexColor("#FFA500"));  
        Console.WriteLine(ValidateHexColor("#ff4500")); 
        Console.WriteLine(ValidateHexColor("#123"));   
    }
}
