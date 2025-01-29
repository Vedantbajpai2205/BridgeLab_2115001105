using System;

class Remove
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        Console.Write("Enter the character to remove: ");
        char charToRemove = Console.ReadLine()[0]; 

        string modifiedString = RemoveCharacter(input, charToRemove);

        Console.WriteLine("Modified String: " + modifiedString);
    }

    static string RemoveCharacter(string input, char charToRemove)
    {
        string result = "";

        foreach (char c in input)
        {
            if (c != charToRemove)
            {
                result += c;
            }
        }

        return result;
    }
}
