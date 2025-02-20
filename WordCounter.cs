using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordCounter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the file path:");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                Dictionary<string, int> wordCount = new Dictionary<string, int>();
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        string cleanWord = word.ToLower();

                        if (wordCount.ContainsKey(cleanWord))
                        {
                            wordCount[cleanWord]++;
                        }
                        else
                        {
                            wordCount[cleanWord] = 1;
                        }
                    }
                }

                var topWords = wordCount.OrderByDescending(pair => pair.Value).Take(5);

                Console.WriteLine("Top 5 frequent words:");
                int rank = 1;
                foreach (var word in topWords)
                {
                    Console.WriteLine("Rank " + rank + ": " + word.Key + " - " + word.Value + " occurrences");
                    rank++;
                }
            }
        }
        else
        {
            Console.WriteLine("The file does not exist. Please check the file path.");
        }
    }
}
