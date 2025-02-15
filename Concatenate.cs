using System;
using System.Text;

class Concatenate
{
    static void Main()
    {
        string[] inputArray = Console.ReadLine().Split();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < inputArray.Length; i++)
        {
            sb.Append(inputArray[i]);
        }

        for (int i = 0; i < sb.Length; i++)
        {
            Console.Write(sb[i]);
        }
    }
}
