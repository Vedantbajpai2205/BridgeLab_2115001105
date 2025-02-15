using System;
using System.Diagnostics;
using System.Text;

class Compare
{
    static void Main()
    {
        int iterations = 100000;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("Yash");
        }

        stopwatch.Stop();
        Console.WriteLine("StringBuilder time: " + stopwatch.ElapsedMilliseconds + " ms");

        stopwatch.Restart();

        string result = "";
        for (int i = 0; i < iterations; i++)
        {
            result += "Yash";
        }

        stopwatch.Stop();
        Console.WriteLine("String concatenation time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
