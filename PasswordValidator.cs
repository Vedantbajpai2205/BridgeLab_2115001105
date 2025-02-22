using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (string.IsNullOrEmpty(password))
            return false;

        bool hasUppercase = password.Any(char.IsUpper);
        bool hasDigit = password.Any(char.IsDigit);
        bool isLongEnough = password.Length >= 8;

        return hasUppercase && hasDigit && isLongEnough;
    }
}
