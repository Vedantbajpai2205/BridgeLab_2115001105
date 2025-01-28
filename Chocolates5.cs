using System;

class Chocolates5
{
    // Method to find how many chocolates each child gets and the remaining chocolates
    public static int[] DivideChocolates(int numberOfChocolates, int numberOfChildren)
    {
        if (numberOfChildren == 0)
        {
            Console.WriteLine("Error: Number of children cannot be zero.");
            return new int[] { 0, 0 };
        }
        
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        return new int[] { chocolatesPerChild, remainingChocolates };
    }

    static void Main()
    {
        Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        int[] result = DivideChocolates(numberOfChocolates, numberOfChildren);
        
        if (numberOfChildren != 0)
        {
            Console.WriteLine("Each child will get: " + result[0] + " chocolates");
            Console.WriteLine("Remaining chocolates: " + result[1]);
        }
    }
}
