using System;

class Replace
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        
        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();
        
        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();
       
        string modifiedSentence = ReplaceWord(sentence, oldWord, newWord);
        
        Console.WriteLine("Modified Sentence: " + modifiedSentence);
    }

    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        if (string.IsNullOrEmpty(oldWord) || string.IsNullOrEmpty(sentence))
        {
            return sentence;
        }

        string result = "";  
        int i = 0;  

        while (i < sentence.Length)
        {
            if (i + oldWord.Length <= sentence.Length && MatchWord(sentence, i, oldWord))
            {
                result += newWord;
                i += oldWord.Length;
            }
            else
            {
                result += sentence[i];
                i++;
            }
        }

        return result;
    }

    // Method to check if a word matches the sentence starting at a given index
    static bool MatchWord(string sentence, int index, string word)
    {
        for (int j = 0; j < word.Length; j++)
        {
            if (sentence[index + j] != word[j])
            {
                return false;
            }
        }
        return true;
    }
}
