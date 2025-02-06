using System;
using System.Collections.Generic;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Order> Orders { get; set; }

    public Customer(int customerId, string name, string email)
    {
        CustomerId = customerId;
        Name = name;
        Email = email;
        Orders = new List<Order>();
    }

    public void PlaceOrder(Order order)
    {
        Orders.Add(order);
        order.Customer = this; 
    }

    public string ToStringCustom()
    {
        return "Customer " + Name + " (ID: " + CustomerId + ", Email: " + Email + ")";
    }
}
public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }

    public Product(int productId, string name, decimal price, int stockQuantity)
    {
        ProductId = productId;
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public bool UpdateStock(int quantity)
    {
        if (StockQuantity >= quantity)
        {
            StockQuantity -= quantity;
            return true;
        }
        return false;
    }

    public string ToStringCustom()
    {
        return "Product " + Name + " (ID: " + ProductId + ", Price: $" + Price + ", Stock: " + StockQuantity + ")";
    }
}
public class Order
{
    public int OrderId { get; set; }
    public Customer Customer { get; set; }
    public List<Tuple<Product, int>> Products { get; set; }
    public decimal TotalPrice { get; set; }

    public Order(int orderId, Customer customer)
    {
        OrderId = orderId;
        Customer = customer;
        Products = new List<Tuple<Product, int>>();
        TotalPrice = 0m;
    }

    public void AddProduct(Product product, int quantity)
    {
        if (product.UpdateStock(quantity))
        {
            Products.Add(new Tuple<Product, int>(product, quantity));
            TotalPrice += product.Price * quantity;
        }
        else
        {
            Console.WriteLine("Not enough stock for " + product.Name + ". Order not placed.");
        }
    }

    public string ToStringCustom()
    {
        string productDetails = "";
        foreach (var item in Products)
        {
            productDetails += item.Item1.Name + " x" + item.Item2 + "\n";
        }

        return "Order " + OrderId + " for " + Customer.Name + ":\n" + productDetails + "Total: $" + TotalPrice;
    }
    public static void Main(string[] args)
    {
        var product1 = new Product(1, "Laptop", 1200.00m, 5);
        var product2 = new Product(2, "Mobole", 1000.00m, 10);

        var customer1 = new Customer(1, "Yash", "yash@gmail.com");

        var order1 = new Order(101, customer1);

        order1.AddProduct(product1, 1); 
        order1.AddProduct(product2, 2); 

        customer1.PlaceOrder(order1);

        Console.WriteLine(order1.ToStringCustom());

        Console.WriteLine(product1.ToStringCustom());
        Console.WriteLine(product2.ToStringCustom());
    }
}
