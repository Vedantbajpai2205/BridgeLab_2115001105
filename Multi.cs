using System;

class Multi
{
	//method for print table 6 to 9
    static void Main()
    {
        Console.Write("Enter a number to generate its multiplication table 6 to 9: ");
        int number = int.Parse(Console.ReadLine());
            int[] multiplicationResult = new int[4];

            for (int i = 6; i <= 9; i++)
            {
                multiplicationResult[i - 6] = number * i;
            }

            Console.WriteLine("Multiplication table for " + number + " from 6 to 9:");
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + multiplicationResult[i - 6]);
            }
        }
}
