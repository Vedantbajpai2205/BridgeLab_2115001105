using System;
using System.IO;
using System.Diagnostics;

class FileCopy
{
    private static void CopyFileUsingBufferedStream(string sourceFile, string destinationFile)
    {
        using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
        using (FileStream destinationStream = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedSourceStream = new BufferedStream(sourceStream))
        using (BufferedStream bufferedDestinationStream = new BufferedStream(destinationStream))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = bufferedSourceStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                bufferedDestinationStream.Write(buffer, 0, bytesRead);
            }
        }
    }

    private static void CopyFileUsingUnBufferedStream(string sourceFile, string destinationFile)
    {
        using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
        using (FileStream destinationStream = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                destinationStream.Write(buffer, 0, bytesRead);
            }
        }
    }

    public static void Main()
    {
        string sourceFile = "source.txt";  
        string destinationFileBuffered = "destination_buffered.txt";
        string destinationFileUnBuffered = "destination_unbuffered.txt";

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        CopyFileUsingBufferedStream(sourceFile, destinationFileBuffered);
        stopwatch.Stop();
        Console.WriteLine("BufferedStream copy time: " + stopwatch.ElapsedMilliseconds + "ms");

        stopwatch.Restart();
        CopyFileUsingUnBufferedStream(sourceFile, destinationFileUnBuffered);
        stopwatch.Stop();
        Console.WriteLine("Unbuffered FileStream copy time: " + stopwatch.ElapsedMilliseconds + "ms");
    }
}
