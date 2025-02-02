using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public Book()
    {
        Title = "Unknown Title";
        Author = "Unknown Author";
        Price = 0.0;
    }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: " + Price);
    }
}

class Bookoops
{
    static void Main()
    {
        Book book1 = new Book();
        book1.DisplayInfo();

        Console.WriteLine();

        Book book2 = new Book("1984", "George Orwell", 15.99);
        book2.DisplayInfo();
    }
}
