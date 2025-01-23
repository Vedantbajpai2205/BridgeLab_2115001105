using System;

namespace HarshadNumberCheck
{
    class Harshad
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int originalNumber = number;
            int sum = 0;

            while (originalNumber != 0)
            {
                int digit = originalNumber % 10;
                sum += digit;
                originalNumber /= 10;
            }

            if (number % sum == 0)
            {
                Console.WriteLine(number + " is a Harshad Number.");
            }
            else
            {
                Console.WriteLine(number + " is not a Harshad Number.");
            }
        }
    }
}