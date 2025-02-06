using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return "'" + Title + "' by " + Author;
    }
}

class Library
{
    public List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void ShowBooks()
    {
        Console.WriteLine("Books in the library: ");
        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
    }
    static void Main()
    {
        Book book1 = new Book("2002", "Yash");
        Book book2 = new Book("2003", "Vedant");
        Book book3 = new Book("2004", "Raghav");

        Library library1 = new Library();
        Library library2 = new Library();
		Library library3 = new Library();

        library1.AddBook(book1);
        library2.AddBook(book2);
        library3.AddBook(book3);

        library1.ShowBooks();
        library2.ShowBooks();
		library3.ShowBooks();

        Console.WriteLine("\nIndependent Books:");
        Console.WriteLine(book1);
        Console.WriteLine(book2);
        Console.WriteLine(book3);
    }
}
