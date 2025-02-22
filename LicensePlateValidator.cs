using System;
using System.Text.RegularExpressions;

public class LicensePlateValidator
{
    public static string ValidateLicensePlate(string licensePlate)
    {
        if (Regex.IsMatch(licensePlate, @"^[A-Z]{2}\d{4}$"))
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
        Console.WriteLine(ValidateLicensePlate("AB1234"));  
        Console.WriteLine(ValidateLicensePlate("A12345"));  
    }
}
