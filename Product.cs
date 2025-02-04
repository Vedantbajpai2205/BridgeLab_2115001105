using System;

class Product
{
	public static double Discount{get; set;}
	public static void UpdateDiscount(double amount)
	{
		if (amount >= 0 && amount <= 100)
        {
            Discount = amount;
			Console.WriteLine("Updated Discount : " + Discount + "%");
        }
        else
        {
            Console.WriteLine("Invalid discount value. Please enter a value between 0 and 100.");
        }
	}
	public string ProductName{get; set;}
	public string Price{get; set;}
	public string Quantity{get; set;}
	private readonly string ProductId;
	public Product(string productname, string price, string quantity, string productid)
	{
		this.ProductName = productname;
		this.Price = price;
		this.Quantity = quantity;
		this.ProductId = productid;
	}
	public void DisplayProductDetails()
	{
		if(this is Product)
		{
			Console.WriteLine("Product Name :" + ProductName);
			Console.WriteLine("Product Price :" + Price);
			Console.WriteLine("Product Quantity :" + Quantity);
			Console.WriteLine("Product Id :" + ProductId);
		}
		else{
			Console.WriteLine("Invalid Data! Please enter a correct deatils.");
		}
	}
	public static void Main(string[] args)
	{
		Product product1 = new Product("Mob","10,000","10","123");
		Product product2 = new Product("laptop","20,000","1","456");
		product1.DisplayProductDetails();
		UpdateDiscount(10);
		Console.WriteLine();
		product2.DisplayProductDetails();
		UpdateDiscount(20);
	}
}