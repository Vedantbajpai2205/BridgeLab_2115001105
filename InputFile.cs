using System;
using System.IO;

class InputFile
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            string ageInput = Console.ReadLine();
            int age;
            while (!int.TryParse(ageInput, out age))
            {
                Console.WriteLine("Invalid input. Please enter a valid age:");
                ageInput = Console.ReadLine();
            }

            Console.WriteLine("Please enter your favorite programming language:");
            string favoriteLanguage = Console.ReadLine();

            string filePath = "user_info.txt";

            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Favorite Programming Language: " + favoriteLanguage);
                writer.WriteLine(); 
            }

            Console.WriteLine("Your information has been saved to the file.");
        }
        catch (IOException ioEx)
        {
            Console.WriteLine("I/O error occurred: " + ioEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error occurred: " + ex.Message);
        }
    }
}
