using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; }

    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Price = 0.0;
        IsAvailable = true;  
    }

    public Book(string title, string author, double price, bool isAvailable)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = isAvailable;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: " + Price.ToString("F2"));
        Console.WriteLine("Available: " + (IsAvailable ? "Yes" : "No"));
    }

    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;  // Mark the book as not available
            Console.WriteLine("You have successfully borrowed '" + Title + "' by " + Author + ".");
        }
        else
        {
            Console.WriteLine("Sorry, '" + Title + "' is currently unavailable.");
        }
    }

    public void ReturnBook()
    {
        if (!IsAvailable)
        {
            IsAvailable = true; 
            Console.WriteLine("You have successfully returned '" + Title + "' by " + Author + ".");
        }
        else
        {
            Console.WriteLine("The book '" + Title + "' is not borrowed.");
        }
    }
}

class Library
{
    static void Main()
    {
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.99, true);
        
        Console.WriteLine("Book 1 Information:");
        book1.DisplayBookInfo();

        Console.WriteLine("\nAttempting to borrow Book 1:");
        book1.BorrowBook();

        Console.WriteLine("\nAttempting to borrow Book 1 again:");
        book1.BorrowBook();

        Console.WriteLine();

        Console.WriteLine("Returning Book 1:");
        book1.ReturnBook();

        Console.WriteLine("\nAttempting to borrow Book 1 after returning it:");
        book1.BorrowBook();
    }
}
