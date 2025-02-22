using System;
using System.Text.RegularExpressions;

public class IPAddressValidator
{
    public static string ValidateIPAddress(string ipAddress)
    {
        string pattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

        if (Regex.IsMatch(ipAddress, pattern))
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
        Console.WriteLine(ValidateIPAddress("192.168.1.1"));  
        Console.WriteLine(ValidateIPAddress("256.100.50.25")); 
        Console.WriteLine(ValidateIPAddress("192.168.1"));     
    }
}
