using System;

namespace BookDetails
{
    class Book
    {
        // Attributes (properties) of the Book class
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        // Constructor to initialize the Book object
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        // Method to display the book details
        public void DisplayDetails()
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Price: " + Price.ToString("C"));  // Display price in currency format
        }
    }

    class HandleBook
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.99);

            book1.DisplayDetails();
        }
    }
}
