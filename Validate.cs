using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "employees.csv";
        ValidateCSVData(filePath);
    }

    static void ValidateCSVData(string filePath)
    {
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) 
            {
                var values = lines[i].Split(',');

                if (values.Length == 5) 
                {
                    string email = values[3];
                    string phoneNumber = values[4];

                    bool isEmailValid = IsValidEmail(email);
                    bool isPhoneNumberValid = IsValidPhoneNumber(phoneNumber);

                    if (!isEmailValid || !isPhoneNumberValid)
                    {
                        Console.WriteLine($"Invalid record at line {i + 1}: {lines[i]}");
                        if (!isEmailValid)
                        {
                            Console.WriteLine($"  Error: Invalid email format - {email}");
                        }
                        if (!isPhoneNumberValid)
                        {
                            Console.WriteLine($"  Error: Invalid phone number format - {phoneNumber}");
                        }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    static bool IsValidEmail(string email)
    {
        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, emailPattern);
    }

    static bool IsValidPhoneNumber(string phoneNumber)
    {
        return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
    }
}
