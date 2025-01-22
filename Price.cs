using System;

class Price
{
	//Method for find the total price of an item
	public static void findtotalPrice()
	{
		
		Console.Write("Enter the unit price of the item: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate the total price
        double totalPrice = unitPrice * quantity;
		
		Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
	}
    static void Main(string[] args)
    {
        Price.findtotalPrice();
    }
}