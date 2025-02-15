using System;
using System.IO;

class Convert
{
    static void Main()
    {
        string filePath = "Character.bin";

        if (File.Exists(filePath))
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                int character;
                while ((character = sr.Read()) != -1)
                {
                    Console.Write((char)character);
                }
            }
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }
}
