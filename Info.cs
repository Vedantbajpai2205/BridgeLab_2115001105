using System;
using System.IO;

class Info
{
    static void Main()
    {
        try
        {
            using (StreamReader sr = new StreamReader("info.txt"))
            {
                string firstLine = sr.ReadLine();
                Console.WriteLine(firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}
