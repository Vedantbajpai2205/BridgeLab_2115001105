using System;
using System.IO;

class LargeFileReader
{
    public static void ReadFileAndPrintErrors(string filePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                int lineNumber = 1;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine("Line " + lineNumber + ":" + line);
                    }
                    lineNumber++;
                }
            }
        }
        catch (IOException ioEx)
        {
            Console.WriteLine("I/O error occurred: " + ioEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }

    static void Main()
    {
        string filePath = "largefile.txt"; 

        ReadFileAndPrintErrors(filePath);
    }
}
