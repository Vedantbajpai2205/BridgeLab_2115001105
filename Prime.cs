using System;

class Prime
{
	//method for check num is prime or not
    static void Main()
    {
        Console.Write("Enter a number to check if it is prime: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 1)
        {
			//Assume
            bool isPrime = true; 

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false; 
                    break; 
                }
            }

            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }
        else
        {
            Console.WriteLine("please enter the number greater than 1"); 
        }
    }
}