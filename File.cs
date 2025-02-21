using System;
using System.IO;

class File
{
    static void Main()
    {
        string filePath = "data.txt";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string fileContent = reader.ReadToEnd();
                Console.WriteLine("File Contents:");
                Console.WriteLine(fileContent);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
