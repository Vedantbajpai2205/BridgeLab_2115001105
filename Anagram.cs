using System;

class Anagram
{
    static void Main()
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();
        
        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        bool result = AreAnagrams(str1, str2);

        if (result)
        {
            Console.WriteLine("The strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The strings are not anagrams.");
        }
    }

    static bool AreAnagrams(string str1, string str2)
    {
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();

        if (str1.Length != str2.Length)
        {
            return false;
        }

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();
        
        Array.Sort(arr1);
        Array.Sort(arr2);

        return new string(arr1) == new string(arr2);
    }
}
