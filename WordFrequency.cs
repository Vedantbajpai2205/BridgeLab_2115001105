using System;
using System.Collections.Generic;
using System.IO;

    class WordFrequency
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file path:");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                Dictionary<string, int> wordFrequency = CountWordFrequency(filePath);

                Console.WriteLine("Word frequencies:");
                foreach (var entry in wordFrequency)
                {
                    Console.WriteLine(entry.Key + " : " + entry.Value);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        static Dictionary<string, int> CountWordFrequency(string filePath)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] words = line.Split(new[] { ' ', '\t', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    string normalizedWord = word.ToLower();

                    if (wordFrequency.ContainsKey(normalizedWord))
                    {
                        wordFrequency[normalizedWord]++;
                    }
                    else
                    {
                        wordFrequency[normalizedWord] = 1;
                    }
                }
            }

            return wordFrequency;
        }
    }
