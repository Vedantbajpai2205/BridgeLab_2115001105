using System;

namespace TimeZonesAndDateTimeOffset
{
    class TimeZone
    {
        static void Main(string[] args)
        {
            DateTimeOffset currentUtcTime = DateTimeOffset.UtcNow;

            DisplayTimeInTimeZone(currentUtcTime, "GMT", "UTC");

            DisplayTimeInTimeZone(currentUtcTime, "IST", "India Standard Time");

            DisplayTimeInTimeZone(currentUtcTime, "PST", "Pacific Standard Time");

            Console.ReadLine(); 
        }

        static void DisplayTimeInTimeZone(DateTimeOffset currentUtcTime, string timeZoneAbbreviation, string timeZoneId)
        {
			bool timeZoneFound = false;

			foreach (TimeZoneInfo tz in TimeZoneInfo.GetSystemTimeZones())
			{
				if (tz.Id == timeZoneId)
				{
					timeZoneFound = true;
					break;  
				}
			}

			if (timeZoneFound)
			{
				TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

                DateTimeOffset timeInZone = TimeZoneInfo.ConvertTime(currentUtcTime, timeZone);

                Console.WriteLine("Current time in " + timeZoneAbbreviation + ": " + timeInZone.ToString("yyyy-MM-dd HH:mm:ss"));
			}
            else
            {
                Console.WriteLine("Time zone " + timeZoneId + " not found.");
            }
        }
    }
}
