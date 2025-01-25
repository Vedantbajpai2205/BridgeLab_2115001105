using System;

class Positivenegative
{
	//method for check positive, negative and even or odd
    static void Main()
    {
        int[] numbers = new int[5];
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number: " + (i+1) + "\n");
            int num = int.Parse(Console.ReadLine());
            numbers[i] = num;
        }
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number " + number + " is positive and even.");
                }
                else
                {
                    Console.WriteLine("The number " + number + " is positive and odd.");
                }
            }
            else if (number < 0)
            {
                Console.WriteLine("The number " + number + " is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        int firstElement = numbers[0];
        int lastElement = numbers[numbers.Length - 1];

        if (firstElement == lastElement)
        {
            Console.WriteLine("The first and last elements are equal.");
        }
        else if (firstElement > lastElement)
        {
            Console.WriteLine("The first element is greater than the last element.");
        }
        else
        {
            Console.WriteLine("The first element is less than the last element.");
        }
    }
}
