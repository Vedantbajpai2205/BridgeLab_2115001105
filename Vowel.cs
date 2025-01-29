using System;

class Vowel
{
	//Method for count vowels in string
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int vowelCount = 0, consonantCount = 0;

        input = input.ToLower();

        foreach (char c in input)
        {
            if (Char.IsLetter(c))
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }

        Console.WriteLine("Vowels: " + vowelCount);
        Console.WriteLine("Consonants: " + consonantCount);
    }
}
