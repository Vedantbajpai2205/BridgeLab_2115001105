using System;

class Book
{
    public string ISBN { get; set; }

    protected string Title { get; set; }

    private string Author { get; set; }

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public string GetAuthor()
    {
        return Author;
    }

    public void SetAuthor(string author)
    {
        Author = author;
    }

    public void DisplayBookDetails()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
    }
}

class EBook : Book
{
    public EBook(string isbn, string title, string author)
        : base(isbn, title, author)
    {
    }

    public void DisplayEBookDetails()
    {
        Console.WriteLine("EBook Details:");
        Console.WriteLine("ISBN: " + ISBN); 
        Console.WriteLine("Title: " + Title); 
        Console.WriteLine("Author: " + GetAuthor()); 
    }
}

class Library2
{
    static void Main()
    {
        Book book1 = new Book("978-3-16-148410-0", "C# Programming", "John Doe");

        book1.DisplayBookDetails();
      
        book1.SetAuthor("Jane Smith");
        Console.WriteLine("Updated Author: " + book1.GetAuthor());
        Console.WriteLine();

        EBook ebook1 = new EBook("978-1-23-456789-0", "Learn C# in 24 Hours", "David Johnson");

        ebook1.DisplayEBookDetails();
    }
}
