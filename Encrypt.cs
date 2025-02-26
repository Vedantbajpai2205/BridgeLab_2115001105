using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

public class CsvEncryptionDecryption
{
    private static readonly string EncryptionKey = "your-encryption-key";

    public static string Encrypt(string plainText)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(EncryptionKey.PadRight(32, ' '));
            aesAlg.IV = new byte[16];
            using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }
    }

    public static string Decrypt(string cipherText)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(EncryptionKey.PadRight(32, ' '));
            aesAlg.IV = new byte[16];
            using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
            {
                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }
    }

    public static void WriteCsvWithEncryption(string filePath, List<Employee> employees)
    {
        using (var writer = new StreamWriter(filePath))
        using (var csv = new CsvWriter(writer, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
        {
            csv.WriteRecords(employees);
        }
    }

    public static List<Employee> ReadCsvWithDecryption(string filePath)
    {
        var employees = new List<Employee>();
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
        {
            while (csv.Read())
            {
                var employee = csv.GetRecord<Employee>();
                employee.Email = Decrypt(employee.Email);
                employee.Salary = Decrypt(employee.Salary);
                employees.Add(employee);
            }
        }
        return employees;
    }
}

public class Employee
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Salary { get; set; }
}
