using System;

public class BookCategory { }
public class ClothingCategory { }

public class Product<T> where T : class
{
    public string Name { get; set; }
    public double Price { get; set; }
    public T Category { get; set; }

    public Product(string name, double price, T category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public override string ToString()
    {
		return Name + " (" + Category.GetType().Name + ") - " + Price.ToString("F2");
    }
}

public static class Marketplace
{
    public static void ApplyDiscount<T>(Product<T> product, double percentage) where T : class
    {
        if (percentage < 0 || percentage > 100)
        {
            throw new ArgumentException("Discount percentage must be between 0 and 100.");
        }

        double discountAmount = product.Price * (percentage / 100);
        product.Price -= discountAmount;

        Console.WriteLine("Discount applied: " + percentage + "% on " + product.Name + ". New price: " + product.Price.ToString("F2"));
    }
}

class Program2
{
    static void Main()
    {
        var book = new Product<BookCategory>("DSA", 22, new BookCategory());
        var shirt = new Product<ClothingCategory>("Capgemini T-Shirt", 21, new ClothingCategory());

        Console.WriteLine("Before Discount:");
        Console.WriteLine(book);
        Console.WriteLine(shirt);

        Marketplace.ApplyDiscount(book, 10);
        Marketplace.ApplyDiscount(shirt, 15);

        Console.WriteLine("After Discount:");
        Console.WriteLine(book);
        Console.WriteLine(shirt);
    }
}
