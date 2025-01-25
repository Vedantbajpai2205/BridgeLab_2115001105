using System;

class Youngest
{
	//method for Find the youngest and tallest among 3 friends
    static void Main()
    {
        int maxDigits = 10;
        int[] digits = new int[maxDigits];
        int index = 0;

        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter age for friend " + (i + 1) + " (Amar, Akbar, Anthony): ");
            while (true)
            {
				int age = int.Parse(Console.ReadLine());
                if (age > 0)
                {
                    ages[i] = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive age.");
                }
            }

            Console.WriteLine("Enter height for friend " + (i + 1) + " (Amar, Akbar, Anthony): ");
            while (true)
            {
				double height = double.Parse(Console.ReadLine());
                if (height > 0)
                {
                    heights[i] = height;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive height.");
                }
            }
        }

        int youngestIndex = 0;
        int tallestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }

            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        string[] friends = { "Amar", "Akbar", "Anthony" };
		
        Console.WriteLine("\nThe youngest friend is " + friends[youngestIndex] + " with age " + ages[youngestIndex]);
        Console.WriteLine("The tallest friend is " + friends[tallestIndex] + " with height " +  heights[tallestIndex] + " meters.");


        Console.WriteLine("\nEnter a number to find the largest and second largest digits: ");
        long number;

        while (!long.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number.");
        }

        while (number > 0)
        {
            if (index == maxDigits) 
            {
              
                maxDigits += 10;
                int[] tempArray = new int[maxDigits];

               
                Array.Copy(digits, tempArray, digits.Length);

                digits = tempArray;
            }

            digits[index] = (int)(number % 10); // Get the last digit
            number /= 10; // Remove the last digit from the number
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
            Console.WriteLine("\nThe largest digit is: " + largest);
            Console.WriteLine("The second largest digit is: " + secondLargest);
        }
        else
        {
            Console.WriteLine("Not enough distinct digits in the number.");
        }
    }
}
