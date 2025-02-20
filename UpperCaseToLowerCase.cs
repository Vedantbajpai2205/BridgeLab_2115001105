using System;
using System.IO;
using System.Text;

class UpperCaseToLowerCase
{
    static void Main(string[] args)
    {
        string inputFile = "input.txt";
        string outputFile = "output.txt";

        if (!File.Exists(inputFile))
        {
            Console.WriteLine("Input file does not exist.");
            return;
        }

        try
        {
            using (FileStream fsRead = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            using (BufferedStream bsRead = new BufferedStream(fsRead))
            using (StreamReader reader = new StreamReader(bsRead, Encoding.UTF8))
            {
                using (FileStream fsWrite = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                using (BufferedStream bsWrite = new BufferedStream(fsWrite))
                using (StreamWriter writer = new StreamWriter(bsWrite, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string modifiedLine = line.ToLower();
                        writer.WriteLine(modifiedLine);
                    }

                    Console.WriteLine("File processing completed successfully.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
