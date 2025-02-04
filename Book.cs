using System;

class Book
{
		public static string LibraryName {get; set;}
		public static void DisplayLibraryName()
		{
			Console.WriteLine("Library Name :" + LibraryName);
		}
		private readonly string ISBN;
		public string Title;
		public string Author;
		public Book(string isbn, string title, string author)
		{
			this.ISBN = isbn;
			this.Title = title;
			this.Author = author;
		}
		public void DisplayLibraryDetails()
		{
			if(this is Book)
			{
				Console.WriteLine("ISBN :" + ISBN);
				Console.WriteLine("Book Title :" + Title);
				Console.WriteLine("Author :" + Author);
				Console.WriteLine("Library Name :" + LibraryName);
			}
			else
			{
				Console.WriteLine("Invalid Details, Please Enter correct details.");
			}
		}
		public static void Main(string[] args)
		{
			Book.LibraryName = "Yo Library";
			Book author1 = new Book ("12345", "Avengers", "Stan lee");
			Book author2 = new Book ("67890", "DC", "Yash");
			DisplayLibraryName();
			Console.WriteLine();
			author1.DisplayLibraryDetails();
			Console.WriteLine();
			author2.DisplayLibraryDetails();
		}
}