using System;

class Discount
{
	//Method for Calculate the discount and the final amount
	public static void discountAmount()
	{
		double fee = 125000;
        double discountPercent = 10;
        double discount = (discountPercent / 100) * fee;
        double discountedFee = fee - discount;
		Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + discountedFee);
	}
    static void Main(string[] args)
    {
        Discount.discountAmount();
    }
}