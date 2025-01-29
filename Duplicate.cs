using System;

class Duplicate{
    static void Main()
    {
       
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
      
        string result = RemoveDuplicates(input);
        
        Console.WriteLine("String without duplicates: " + result);
    }
	//method for check duplicate in given string
    static string RemoveDuplicates(string str)
    {
        bool[] seen = new bool[256]; 
        string result = "";
       
        foreach (char c in str)
        {
            if (!seen[c])
            {
                result += c;
                seen[c] = true;
            }
        }
        
        return result;
    }
}
