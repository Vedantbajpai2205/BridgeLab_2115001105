using System;
using System.Text;
using System.Diagnostics;

class Concatenation 
{
    static void Main(string[] args)
    {
        int N = 1000000;

        var stopwatch = Stopwatch.StartNew();
        string result = "";
        for (int i = 0; i < N; i++)
        {
            result += "a";
        }
        stopwatch.Stop();
        Console.WriteLine("String Concatenation Time: " + stopwatch.ElapsedMilliseconds + " ms");

        stopwatch.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < N; i++)
        {
            sb.Append("a");
        }
        stopwatch.Stop();
        Console.WriteLine("StringBuilder Concatenation Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
