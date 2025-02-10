using System;

abstract class LibraryItem
{
    protected string itemId;
    protected string title;
    protected string author;

    public LibraryItem(string itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    public string GetItemDetails()
    {
        return "Item ID: " + itemId + ", Title: " + title + ", Author: " + author;
    }

    public abstract int GetLoanDuration();
}

interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

class Book : LibraryItem, IReservable
{
    public Book(string itemId, string title, string author) : base(itemId, title, author) {}

    public override int GetLoanDuration()
    {
        return 10;
    }

    public void ReserveItem()
    {
        Console.WriteLine("The book has been reserved.");
    }

    public bool CheckAvailability()
    {
        return true;
    }
}

class Magazine : LibraryItem, IReservable
{
    public Magazine(string itemId, string title, string author) : base(itemId, title, author) {}

    public override int GetLoanDuration()
    {
        return 5;
    }

    public void ReserveItem()
    {
        Console.WriteLine("The magazine has been reserved.");
    }

    public bool CheckAvailability()
    {
        return true;
    }
}

class DVD : LibraryItem, IReservable
{
    public DVD(string itemId, string title, string author) : base(itemId, title, author) {}

    public override int GetLoanDuration()
    {
        return 3;
    }

    public void ReserveItem()
    {
        Console.WriteLine("The DVD has been reserved.");
    }

    public bool CheckAvailability()
    {
        return true;
    }
}

class Program5
{
    public static void Main(string[] args)
    {
        LibraryItem[] items = new LibraryItem[]
        {
            new Book("B001", "C# Programming", "Yash "),
            new Magazine("M001", "Tech", "Raghav "),
            new DVD("D001", "Dsa", "Vedant ")
        };

        foreach (LibraryItem item in items)
        {
            Console.WriteLine(item.GetItemDetails());
            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");
        }
    }
}
