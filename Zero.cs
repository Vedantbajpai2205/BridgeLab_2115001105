using System;

class Zero
{
    static void Main()
    {
            double total = 0.0;

            while (true)
            {
                Console.Write("Enter a number: ");
                double userInput = double.Parse(Console.ReadLine());

                // Check if the user entered 0
                if (userInput == 0)
                {
                    break;
                }
                total += userInput;
            }
			
            Console.WriteLine("The total sum is " + total);
    }
}