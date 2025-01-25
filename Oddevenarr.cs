using System;

class Oddeven
{
	//method for print odd and even
    static void Main()
    {
        Console.Write("Enter a natural number: ");
		int number = int.Parse(Console.ReadLine());
        if ( number > 0)
        {
            int[] oddNumbers = new int[number / 2 + 1];
            int[] evenNumbers = new int[number / 2 + 1];

            int oddIndex = 0;
            int evenIndex = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[evenIndex++] = i; 
                }
                else
                {
                    oddNumbers[oddIndex++] = i; 
                }
            }

            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.Write(oddNumbers[i] + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Even numbers:");
            for (int i = 0; i < evenIndex; i++)
            {
                Console.Write(evenNumbers[i] + " \n");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a natural number greater than 0.");
        }
    }
}