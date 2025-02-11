using System;

class Book
{
    public string BookTitle;
    public string Author;
    public string Genre;
    public int BookID;
    public bool AvailabilityStatus;
    public Book Next;
    public Book Prev;
}

class LibraryManagementSystem
{
    private Book head;

    public void AddAtBeginning(string bookTitle, string author, string genre, int bookID, bool availabilityStatus)
    {
        Book newBook = new Book
        {
            BookTitle = bookTitle,
            Author = author,
            Genre = genre,
            BookID = bookID,
            AvailabilityStatus = availabilityStatus,
            Next = head,
            Prev = null
        };

        if (head != null)
        {
            head.Prev = newBook;
        }
        head = newBook;
    }

    public void AddAtEnd(string bookTitle, string author, string genre, int bookID, bool availabilityStatus)
    {
        Book newBook = new Book
        {
            BookTitle = bookTitle,
            Author = author,
            Genre = genre,
            BookID = bookID,
            AvailabilityStatus = availabilityStatus
        };

        if (head == null)
        {
            head = newBook;
        }
        else
        {
            Book temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newBook;
            newBook.Prev = temp;
        }
    }

    public void AddAtPosition(string bookTitle, string author, string genre, int bookID, bool availabilityStatus, int position)
    {
        Book newBook = new Book
        {
            BookTitle = bookTitle,
            Author = author,
            Genre = genre,
            BookID = bookID,
            AvailabilityStatus = availabilityStatus
        };

        if (position == 0)
        {
            AddAtBeginning(bookTitle, author, genre, bookID, availabilityStatus);
            return;
        }

        Book temp = head;
        for (int i = 0; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp != null)
        {
            newBook.Next = temp.Next;
            newBook.Prev = temp;
            if (temp.Next != null)
            {
                temp.Next.Prev = newBook;
            }
            temp.Next = newBook;
        }
    }

    public void RemoveByBookID(int bookID)
    {
        if (head == null) return;

        if (head.BookID == bookID)
        {
            head = head.Next;
            if (head != null)
            {
                head.Prev = null;
            }
            return;
        }

        Book temp = head;
        while (temp != null && temp.BookID != bookID)
        {
            temp = temp.Next;
        }

        if (temp != null)
        {
            if (temp.Next != null)
            {
                temp.Next.Prev = temp.Prev;
            }
            if (temp.Prev != null)
            {
                temp.Prev.Next = temp.Next;
            }
        }
    }

    public Book SearchByBookTitle(string bookTitle)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.BookTitle == bookTitle)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public Book SearchByAuthor(string author)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.Author == author)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public void UpdateAvailabilityStatus(int bookID, bool newStatus)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.BookID == bookID)
            {
                temp.AvailabilityStatus = newStatus;
                return;
            }
            temp = temp.Next;
        }
    }

    public void DisplayAllBooksForward()
    {
        Book temp = head;
        while (temp != null)
        {
            Console.WriteLine("Book Title: " + temp.BookTitle + ", Author: " + temp.Author + ", Genre: " + temp.Genre + ", Book ID: " + temp.BookID + ", Availability: " + temp.AvailabilityStatus);
            temp = temp.Next;
        }
    }

    public void DisplayAllBooksReverse()
    {
        if (head == null) return;

        Book temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        while (temp != null)
        {
            Console.WriteLine("Book Title: " + temp.BookTitle + ", Author: " + temp.Author + ", Genre: " + temp.Genre + ", Book ID: " + temp.BookID + ", Availability: " + temp.AvailabilityStatus);
            temp = temp.Prev;
        }
    }

    public int CountTotalBooks()
    {
        int count = 0;
        Book temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        return count;
    }
    static void Main(string[] args)
    {
        LibraryManagementSystem library = new LibraryManagementSystem();

        library.AddAtBeginning("Avenger", "Stan Lee", "Comic", 101, true);
        library.AddAtEnd("1984", "Yash", "Book", 102, true);
        library.AddAtEnd("Marvel", "Tom", "Novel", 103, false);
        library.AddAtPosition("365", "Mosim", "Romance", 104, true, 2);

        Console.WriteLine("All books in the library Forward order:");
        library.DisplayAllBooksForward();

        Console.WriteLine("All books in the library Reverse order:");
        library.DisplayAllBooksReverse();

        Console.WriteLine("Total number of books: " + library.CountTotalBooks());

        Console.WriteLine("Searching for book by title '1984':");
        Book foundBookByTitle = library.SearchByBookTitle("1984");
        if (foundBookByTitle != null)
        {
            Console.WriteLine("Found: " + foundBookByTitle.BookTitle + ", Author: " + foundBookByTitle.Author);
        }

        Console.WriteLine("Searching for book by author 'Stan Lee':");
        Book foundBookByAuthor = library.SearchByAuthor("Stan Lee");
        if (foundBookByAuthor != null)
        {
            Console.WriteLine("Found: " + foundBookByAuthor.BookTitle + ", Author: " + foundBookByAuthor.Author);
        }

        Console.WriteLine("Updating availability status of book ID 103 to available (true):");
        library.UpdateAvailabilityStatus(103, true);

        Console.WriteLine("All books after availability update Forward order:");
        library.DisplayAllBooksForward();

        Console.WriteLine("Removing book with Book ID 102:");
        library.RemoveByBookID(102);
        Console.WriteLine("All books after removal Forward order:");
        library.DisplayAllBooksForward();
    }
}
