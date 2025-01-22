using System;

class Choclates
{
	//method for distribute the chocolates
	public static void divideChoc()
	{
		Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the total number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

       
        if (numberOfChildren == 0)
        {
            Console.WriteLine("Number of children cannot be zero.");
        }
        else
        {
            // Calculate chocolates each child gets and the remaining chocolates
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;
			
			Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild + "and the number of remaining chocolates is " + remainingChocolates);
		}
	}
	static void Main(string[] args)
    {
        Choclates.divideChoc();
    }
}