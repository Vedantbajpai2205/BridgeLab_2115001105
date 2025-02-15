using System;

class Specific
{
    static void Main()
    {
        Console.WriteLine("Enter the number of sentences:");
        int n = int.Parse(Console.ReadLine());

        string[] sentences = new string[n];

        Console.WriteLine("Enter the sentences:");

        for (int i = 0; i < n; i++)
        {
            sentences[i] = Console.ReadLine();
        }

        Console.WriteLine("Enter the word to search for:");
        string wordToFind = Console.ReadLine();

        string result = FindFirstSentenceContainingWord(sentences, wordToFind);

        if (result != null)
        {
            Console.WriteLine("The first sentence containing the word is: " + result);
        }
        else
        {
            Console.WriteLine("No sentence contains the word '" + wordToFind + "'.");
        }
    }

    static string FindFirstSentenceContainingWord(string[] sentences, string word)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].ToLower().Contains(word.ToLower()))  // Case-insensitive check without StringComparison.OrdinalIgnoreCase
            {
                return sentences[i];
            }
        }
        return null; // Return null if no sentence contains the word
    }
}
