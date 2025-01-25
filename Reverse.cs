using System;

class Reverse
{
	//method for reverse the program
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        int[] digits = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            digits[i] = int.Parse(input[i].ToString());
        }

        int[] reversedDigits = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversedDigits[i] = digits[digits.Length - 1 - i];
        }

        Console.Write("Reversed number: ");
        foreach (int digit in reversedDigits)
        {
            Console.WriteLine(digit);
        }
    }
}
