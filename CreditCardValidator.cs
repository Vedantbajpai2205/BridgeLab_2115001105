using System;
using System.Text.RegularExpressions;

public class CreditCardValidator
{
    public static string ValidateCreditCard(string cardNumber)
    {
        string pattern = @"^(4\d{15}|5\d{15})$"; 

        if (Regex.IsMatch(cardNumber, pattern))
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
        Console.WriteLine(ValidateCreditCard("4111111111111111"));  
        Console.WriteLine(ValidateCreditCard("5111111111111111"));  
        Console.WriteLine(ValidateCreditCard("411111111111"));      
        Console.WriteLine(ValidateCreditCard("6111111111111111"));  
    }
}
