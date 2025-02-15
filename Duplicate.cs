using System;
using System.Collections.Generic;
using System.Text;

class Duplicate
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        HashSet<char> seen = new HashSet<char>();

        for (int i = 0; i < input.Length; i++)
        {
            if (!seen.Contains(input[i]))
            {
                sb.Append(input[i]);
                seen.Add(input[i]);
            }
        }

        for (int i = 0; i < sb.Length; i++)
        {
            Console.Write(sb[i]);
        }
    }
}
