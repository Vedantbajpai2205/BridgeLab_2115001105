using System;
using System.Collections.Generic;

public abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public Product(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    public int ProductId
    {
        get { return productId; }
    }

    public string Name
    {
        get { return name; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public abstract double CalculateDiscount();

    public double GetFinalPrice()
    {
        double discount = CalculateDiscount();
        double tax = 0;
        if (this is ITaxable taxableProduct)
        {
            tax = taxableProduct.CalculateTax();
        }

        return price + tax - discount;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product ID: " + productId + ", Name: " + name + ", Price: " + price);
    }
}

public class Electronics : Product, ITaxable
{
    public Electronics(int productId, string name, double price) 
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.10; // 10% discount on electronics
    }

    public double CalculateTax()
    {
        return Price * 0.18; // 18% tax on electronics
    }

    public string GetTaxDetails()
    {
        return "18% tax on electronics with a price of " + Price;
    }
}

public class Clothing : Product, ITaxable
{
    public Clothing(int productId, string name, double price) 
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.15; // 15% discount on clothing
    }

    public double CalculateTax()
    {
        return Price * 0.12; // 12% tax on clothing
    }

    public string GetTaxDetails()
    {
        return "12% tax on clothing with a price of " + Price;
    }
}

public class Groceries : Product
{
    public Groceries(int productId, string name, double price) 
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.05; // 5% discount on groceries
    }
}

public interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

class Program2
{
    static void Main(string[] args)
    {
        Electronics laptop = new Electronics(101, "Laptop", 1500);
        Clothing mobile = new Clothing(102, "Mobile", 1000);
        Groceries watch = new Groceries(103, "Watch", 200);

        List<Product> products = new List<Product> { laptop, mobile, watch };

        foreach (Product product in products)
        {
            product.DisplayProductDetails();
            Console.WriteLine("Final Price (Price + Tax - Discount): " + product.GetFinalPrice());
            if (product is ITaxable taxableProduct)
            {
                Console.WriteLine("Tax Details: " + taxableProduct.GetTaxDetails());
            }
            Console.WriteLine();
        }
    }
}
