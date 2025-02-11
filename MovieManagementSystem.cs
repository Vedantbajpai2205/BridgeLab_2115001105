using System;

class Movie
{
    public string Title;
    public string Director;
    public int YearOfRelease;
    public double Rating;
    public Movie Next;
    public Movie Prev;
}

class MovieManagementSystem
{
    Movie head;

    public void AddAtBeginning(string title, string director, int yearOfRelease, double rating)
    {
        Movie newMovie = new Movie();
        newMovie.Title = title;
        newMovie.Director = director;
        newMovie.YearOfRelease = yearOfRelease;
        newMovie.Rating = rating;

        if (head == null)
        {
            head = newMovie;
        }
        else
        {
            newMovie.Next = head;
            head.Prev = newMovie;
            head = newMovie;
        }
    }

    public void AddAtEnd(string title, string director, int yearOfRelease, double rating)
    {
        Movie newMovie = new Movie();
        newMovie.Title = title;
        newMovie.Director = director;
        newMovie.YearOfRelease = yearOfRelease;
        newMovie.Rating = rating;

        if (head == null)
        {
            head = newMovie;
        }
        else
        {
            Movie temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newMovie;
            newMovie.Prev = temp;
        }
    }

    public void AddAtPosition(string title, string director, int yearOfRelease, double rating, int position)
    {
        Movie newMovie = new Movie();
        newMovie.Title = title;
        newMovie.Director = director;
        newMovie.YearOfRelease = yearOfRelease;
        newMovie.Rating = rating;

        if (position == 0)
        {
            AddAtBeginning(title, director, yearOfRelease, rating);
            return;
        }

        Movie temp = head;
        for (int i = 0; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp != null)
        {
            newMovie.Next = temp.Next;
            if (temp.Next != null)
            {
                temp.Next.Prev = newMovie;
            }
            newMovie.Prev = temp;
            temp.Next = newMovie;
        }
    }

    public void RemoveByTitle(string title)
    {
        if (head == null) return;
        
        if (head.Title == title)
        {
            head = head.Next;
            if (head != null) head.Prev = null;
            return;
        }

        Movie temp = head;
        while (temp != null && temp.Title != title)
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
    public Movie SearchByDirectorOrRating(string director = null, double? rating = null)
    {
        Movie temp = head;
        while (temp != null)
        {
            if ((director != null && temp.Director == director) || (rating.HasValue && temp.Rating == rating))
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public void DisplayForward()
    {
        Movie temp = head;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.YearOfRelease + ", Rating: " + temp.Rating);
            temp = temp.Next;
        }
    }

    public void DisplayReverse()
    {
        if (head == null) return;

        Movie temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.YearOfRelease + ", Rating: " + temp.Rating);
            temp = temp.Prev;
        }
    }

    public void UpdateRating(string title, double newRating)
    {
        Movie movie = SearchByDirectorOrRating(director: null, rating: null);
        if (movie != null && movie.Title == title)
        {
            movie.Rating = newRating;
        }
    }
    static void Main(string[] args)
    {
        MovieManagementSystem system = new MovieManagementSystem();

        system.AddAtBeginning("Avengers", "Yash", 2010, 8.8);
        system.AddAtEnd("Marvel", "Yash", 2008, 9.0);
        system.AddAtPosition("Haunted", "Yash", 2014, 8.6, 1);

        Console.WriteLine("Movies in forward order:");
        system.DisplayForward();

        Console.WriteLine("Movies in reverse order:");
        system.DisplayReverse();

        system.UpdateRating("Avengers", 9.2);
        Console.WriteLine("After updating rating:");
        system.DisplayForward();

        system.RemoveByTitle("Haunted");
        Console.WriteLine("After removal:");
        system.DisplayForward();

        Movie foundMovie = system.SearchByDirectorOrRating(director: "Yash", rating: null);
        if (foundMovie != null)
        {
            Console.WriteLine("Found Movie: " + foundMovie.Title + ", Director: " + foundMovie.Director + ", Year: " + foundMovie.YearOfRelease + ", Rating: " + foundMovie.Rating);
        }
        else
        {
            Console.WriteLine("Movie not found.");
        }
    }
}
