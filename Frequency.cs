using System;

class Frequency
{
	//method for count the frequency
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int[] frequency = new int[10];

        foreach (char digitChar in input)
        {
            if (char.IsDigit(digitChar))
            {
                int digit = digitChar - '0';  
                frequency[digit]++;          
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return; 
            }
        }

        Console.WriteLine("\nFrequency of digits in the number:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + " : " + frequency[i] + " time's");
            }
        }
    }
}
