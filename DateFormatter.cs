using System;
using System.Globalization;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        if (string.IsNullOrEmpty(inputDate))
            throw new ArgumentException("Input date cannot be null or empty.");

        DateTime parsedDate;
        if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
        {
            return parsedDate.ToString("dd-MM-yyyy");
        }
        else
        {
            throw new FormatException("Invalid date format.");
        }
    }
}
