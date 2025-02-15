using System;
using System.IO;

class Word
{
    static void Main()
    {
        string filePath = "Occurence.txt";
        string wordToFind = "myWord"; 
        int wordCount = 0;

        if (File.Exists(filePath))
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    wordCount += CountWordOccurrences(line, wordToFind);
                }
            }
            Console.WriteLine("The word '" + wordToFind + "' appeared " + wordCount + " times.");
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }

    static int CountWordOccurrences(string line, string word)
    {
        int count = 0;
        int index = 0;
        
        while ((index = line.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            index += word.Length;
        }

        return count;
    }
}
