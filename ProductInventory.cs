using System;

class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }

    public static int TotalProducts = 0;

    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;

        TotalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price.ToString("F2"));
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total number of products created: " + TotalProducts);
    }
}

class ProductInventory
{
    static void Main()
    {
        Product product1 = new Product("Laptop", 999.99);
        Product product2 = new Product("Smartphone", 499.99);
        Product product3 = new Product("Headphones", 89.99);

        Console.WriteLine("Product 1 Details:");
        product1.DisplayProductDetails();
        Console.WriteLine();

        Console.WriteLine("Product 2 Details:");
        product2.DisplayProductDetails();
        Console.WriteLine();

        Console.WriteLine("Product 3 Details:");
        product3.DisplayProductDetails();
        Console.WriteLine();

        Product.DisplayTotalProducts();
    }
}
