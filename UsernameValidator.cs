using System;
using System.Text.RegularExpressions;

public class UsernameValidator
{
    public static string ValidateUsername(string username)
    {
        if (Regex.IsMatch(username, @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$"))
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
        Console.WriteLine(ValidateUsername("user_123"));
        Console.WriteLine(ValidateUsername("123user"));
        Console.WriteLine(ValidateUsername("us"));
    }
}
