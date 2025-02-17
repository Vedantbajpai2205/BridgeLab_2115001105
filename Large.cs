using System;
using System.Diagnostics;
using System.IO;

class Large
{
    static void Main(string[] args)
    {
        string filePath = "file.txt";

        var stopwatch = Stopwatch.StartNew();
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.Read() != -1)
            {
                //reading character 
            }
        }
        stopwatch.Stop();
        Console.WriteLine("StreamReader Time: " + stopwatch.ElapsedMilliseconds + " ms");

        stopwatch.Restart();
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[1024 * 1024];
            int bytesRead;
            while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
			{
				//processing bytes
			}
        }
        stopwatch.Stop();
        Console.WriteLine("FileStream Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
