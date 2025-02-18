using System;
using System.Collections.Generic;

public abstract class WarehouseItem
{
    public string Name { get; set; }
    public double Price { get; set; }

    public WarehouseItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayItem();
}

public class Electronics : WarehouseItem
{
    public string Brand { get; set; }

    public Electronics(string name, double price, string brand) : base(name, price)
    {
        Brand = brand;
    }

    public override void DisplayItem()
    {
        Console.WriteLine("Electronics : Name: " + Name + ", Price: " + Price.ToString() + ", Brand: " + Brand);
    }
}

public class Groceries : WarehouseItem
{
    public string ExpiryDate { get; set; }

    public Groceries(string name, double price, string expiryDate) : base(name, price)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayItem()
    {
        Console.WriteLine("Groceries : Name: " + Name + ", Price: " + Price.ToString() + ", Expiry Date: " + ExpiryDate);
    }
}

public class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(string name, double price, string material) : base(name, price)
    {
        Material = material;
    }

    public override void DisplayItem()
    {
        Console.WriteLine("Furniture : Name: " + Name + ", Price: " + Price.ToString() + ", Material: " + Material);
    }
}

public class Storage<T> where T : WarehouseItem
{
    private List<T> items;

    public Storage()
    {
        items = new List<T>();
    }

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayAllItems()
    {
        Console.WriteLine("Displaying all items in the warehouse:");
        foreach (var item in items)
        {
            item.DisplayItem();
        }
    }
}

class Program1
{
    static void Main()
    {
        Electronics laptop = new Electronics("Laptop", 799.99, "BrandXYZ");
        Groceries mobile = new Groceries("Mobile", 100.99, "2025-12-22");
        Furniture desk = new Furniture("Desk", 149.99, "Wood");

        Storage<WarehouseItem> warehouse = new Storage<WarehouseItem>();

        warehouse.AddItem(laptop);
        warehouse.AddItem(mobile);
        warehouse.AddItem(desk);

        warehouse.DisplayAllItems();
    }
}
