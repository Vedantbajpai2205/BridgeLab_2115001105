using System;

class Multiplication
{
    static void Main()
    {
        // method for print the multiplication table
        Console.Write("Enter a number to generate its multiplication table: ");
		int number = int.Parse(Console.ReadLine());
        
            int[] multiplicationTable = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                multiplicationTable[i - 1] = number * i;
            }

            Console.WriteLine("Multiplication table for number:");
            for (int i = 0; i < multiplicationTable.Length; i++)
            {
                Console.WriteLine(number + " * " + (i + 1) + " = " + (multiplicationTable[i]));
            }
    }
}
