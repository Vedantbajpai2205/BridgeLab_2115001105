using System;

class Nine
{
	//Method for Calculate the discount and the final amount
	public static void discountAmt()
	{
		
		Console.Write("Enter the Student Fee: ");
        double studentFee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the University Discount Percentage: ");
        double discountPercentage = Convert.ToDouble(Console.ReadLine());
		//calculate the discount
        double discount = (discountPercent / 100) * fee;
		//calculate the discount fee
        double discountedFee = fee - discount;
		Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + discountedFee);
	}
    static void Main(string[] args)
    {
        Nine.discountAmt();
    }
}