using System;
using System.IO;

class Read
{
    static void Main()
    {
        string filePath = "ReadFile.txt";

        if (File.Exists(filePath))
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }
}
