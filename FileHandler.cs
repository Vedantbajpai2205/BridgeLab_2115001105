using System;
using System.IO;

class FileHandler
{
    public static void Main()
    {
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";

        try
        {
            if (File.Exists(sourceFile))
            {
                using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                {
                    using (FileStream destinationStream = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                    {
                        int byteRead;
                        while ((byteRead = sourceStream.ReadByte()) != -1)
                        {
                            destinationStream.WriteByte((byte)byteRead);
                        }
                    }
                }

                Console.WriteLine("File copied successfully.");
            }
            else
            {
                Console.WriteLine("Source file does not exist.");
            }
        }
        catch (IOException ioEx)
        {
            Console.WriteLine("I/O error occurred: " + ioEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("unexpected error occurred: " + ex.Message);
        }
    }
}
