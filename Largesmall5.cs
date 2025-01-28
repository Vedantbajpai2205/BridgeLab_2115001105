using System;

class Largesmall5
{
    // Method to find the smallest and largest of three numbers
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest, largest;
    
        if (number1 <= number2 && number1 <= number3)
        {
            smallest = number1;
        }
        else if (number2 <= number1 && number2 <= number3)
        {
            smallest = number2;
        }
        else
        {
            smallest = number3;
        }
        
        if (number1 >= number2 && number1 >= number3)
        {
            largest = number1;
        }
        else if (number2 >= number1 && number2 >= number3)
        {
            largest = number2;
        }
        else
        {
            largest = number3;
        }

        return new int[] { smallest, largest };
    }

    static void Main()
    {
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int[] result = FindSmallestAndLargest(number1, number2, number3);
      
        Console.WriteLine("The smallest number is: " + result[0]);
        Console.WriteLine("The largest number is: " + result[1]);
    }
}
