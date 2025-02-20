using System;
using System.IO;

class ImageConvert
{
    public static void ConvertImageToByteArray(string sourceImagePath, string destinationImagePath)
    {
        try
        {
            byte[] imageBytes;
            using (FileStream sourceStream = new FileStream(sourceImagePath, FileMode.Open, FileAccess.Read))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    sourceStream.CopyTo(memoryStream);
                    imageBytes = memoryStream.ToArray(); // Convert MemoryStream to byte array
                }
            }

            using (FileStream destinationStream = new FileStream(destinationImagePath, FileMode.Create, FileAccess.Write))
            {
                destinationStream.Write(imageBytes, 0, imageBytes.Length);
            }

            Console.WriteLine("Image has been successfully copied to the new file.");
        }
        catch (IOException ioEx)
        {
            Console.WriteLine("I/O error occurred: " + ioEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }

    static void Main()
    {
        string sourceImagePath = "source_image.jpg"; 
        string destinationImagePath = "destination_image.jpg"; 

        ConvertImageToByteArray(sourceImagePath, destinationImagePath);
    }
}
