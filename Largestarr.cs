using System;

class Largest
{
	//method to find the largest and second largest of an element
    static void Main()
    {
        int maxDigits = 10;
        int[] digits = new int[maxDigits];
        int index = 0;

        Console.WriteLine("Enter a number: ");
        long number;
        
        while (!long.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number.");
        }

        while (number > 0 && index < maxDigits)
        {
            digits[index] = (int)(number % 10); 
            number /= 10;
            index++;
        }

        int largest = -1;
        int secondLargest = -1;

        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest; 
                largest = digits[i]; 
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        if (largest != -1 && secondLargest != -1)
        {
            Console.WriteLine("The largest digit is: " + largest);
            Console.WriteLine("The second largest digit is: " + secondLargest);
        }
        else
        {
            Console.WriteLine("Not enough distinct digits in the number.");
        }
    }
}
