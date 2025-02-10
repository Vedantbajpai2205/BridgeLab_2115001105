using System;

abstract class FoodItem
{
    protected string itemName;
    protected double price;
    protected int quantity;

    public FoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    public string GetItemDetails()
    {
        return "Item Name: " + itemName + ", Price: " + price + ", Quantity: " + quantity;
    }

    public abstract double CalculateTotalPrice();
}

interface IDiscountable
{
    void ApplyDiscount(double discount);
    string GetDiscountDetails();
}

class VegItem : FoodItem, IDiscountable
{
    private double discount;

    public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) {}

    public override double CalculateTotalPrice()
    {
        double total = price * quantity;
        return total + (total * 0.05);
    }

    public void ApplyDiscount(double discount)
    {
        this.discount = discount;
    }

    public string GetDiscountDetails()
    {
        return "Discount Applied: " + discount + "%";
    }
}

class NonVegItem : FoodItem, IDiscountable
{
    private double discount;

    public NonVegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) {}

    public override double CalculateTotalPrice()
    {
        double total = price * quantity;
        return total + (total * 0.1);
    }

    public void ApplyDiscount(double discount)
    {
        this.discount = discount;
    }

    public string GetDiscountDetails()
    {
        return "Discount Applied: " + discount + "%";
    }
}

class Program6
{
    public static void Main(string[] args)
    {
        FoodItem[] foodItems = new FoodItem[]
        {
            new VegItem("Paneer Butter Masala", 200, 2),
            new NonVegItem("Chicken Biryani", 300, 1)
        };

        foreach (FoodItem foodItem in foodItems)
        {
            Console.WriteLine(foodItem.GetItemDetails());
            Console.WriteLine("Total Price: " + foodItem.CalculateTotalPrice());

            if (foodItem is IDiscountable discountableItem)
            {
                discountableItem.ApplyDiscount(10); 
                Console.WriteLine(discountableItem.GetDiscountDetails());
            }

            Console.WriteLine();
        }
    }
}
