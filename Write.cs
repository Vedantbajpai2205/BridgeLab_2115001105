using System;
using System.IO;

class Write
{
    static void Main()
    {
        string filePath = "ReadWrite.txt";

        Console.WriteLine("Enter some text (type 'exit' to stop):");

        using (StreamWriter sw = new StreamWriter(filePath))
        {
            string userInput;
            while ((userInput = Console.ReadLine()) != "exit")
            {
                sw.WriteLine(userInput);
            }
        }

        Console.WriteLine("Your input has been written to the file.");
    }
}
