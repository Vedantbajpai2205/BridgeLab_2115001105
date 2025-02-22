using System;
using System.Text.RegularExpressions;

public class SSNValidator
{
    public static string ValidateSSN(string ssn)
    {
        string pattern = @"^\d{3}-\d{2}-\d{4}$";

        if (Regex.IsMatch(ssn, pattern))
        {
            return $"✅ \"{ssn}\" is valid";
        }
        else
        {
            return $"❌ \"{ssn}\" is invalid";
        }
    }

    public static void Main()
    {
        Console.WriteLine(ValidateSSN("123-45-6789")); 
        Console.WriteLine(ValidateSSN("123456789")); 
    }
}
