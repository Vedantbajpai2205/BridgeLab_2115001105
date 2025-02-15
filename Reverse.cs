using System;
using System.Text;

class Reverse
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }

        for (int i = 0; i < sb.Length; i++)
        {
            Console.Write(sb[i]);
        }
    }
}
