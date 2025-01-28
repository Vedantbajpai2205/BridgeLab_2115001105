using System;

class Sum5
{
    // Method to calculate the sum of first n natural numbers
    static int SumOfNaturalNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i; 
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = SumOfNaturalNumbers(n);
        Console.WriteLine("The sum of the first " + n + " natural numbers is: " + result);
    }
}