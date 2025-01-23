using System;

class Greatest
{
	//method for finding the greatest factor
    static void Main()
    {
      
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int greatestFactor = 1;

        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0) 
            {
                greatestFactor = i;
                break; 
            }
        }
        Console.WriteLine("The greatest factor of " + number + " beside itself is : " + greatestFactor);
    }
}