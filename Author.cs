using System;

public class Book
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}

public class Author : Book
{
    public string Name { get; set; }
    public string Bio { get; set; }

    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear)
    {
        Name = name;
        Bio = bio;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author: " + Name);
        Console.WriteLine("Bio: " + Bio);
    }
    public static void Main(string[] args)
    {
        Author author = new Author("Adventure", 2003, "Yash", "Yash is an experienced writer of adventure novels.");

        author.DisplayInfo();
    }
}
