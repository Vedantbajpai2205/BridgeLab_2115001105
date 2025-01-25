using System;

class Arrsum
{
	//method for sum all the digits in array
    static void Main()
    {
        double[] numbers = new double[10];
        double total = 0.0; 
        int index = 0; 

        Console.WriteLine("Enter up to 10 numbers enter 0 or a negative number to stop:");

        while (true)
        {
            Console.Write("Enter number " + (index + 1 ) + " :" );
            int input = int.Parse(Console.ReadLine());
                if (input <= 0)
                {
                    break;
                }

                numbers[index] = input;
                index++;

                if (index == 10)
                {
                    break;
                }
        }

        for (int i = 0; i < index; i++)
        {
            total += numbers[i];
        }

        Console.WriteLine("\nYou entered the following numbers:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("\nThe total sum of the numbers is: " + total);
    }
}
