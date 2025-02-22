using System;
using System.IO;

public class FileProcessor
{
    public void WriteToFile(string filename, string content)
    {
        try
        {
            File.WriteAllText(filename, content);
        }
        catch (IOException ex)
        {
            throw new IOException("An error occurred while writing to the file.", ex);
        }
    }

    public string ReadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                throw new IOException("File not found.");
            }
            return File.ReadAllText(filename);
        }
        catch (IOException ex)
        {
            throw new IOException("An error occurred while reading from the file.", ex);
        }
    }
}
