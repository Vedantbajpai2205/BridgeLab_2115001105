using System;

class Fizzbuzzwhile
{
	//method for print fizz multiple of and buzz mulltiple of 5 and fizzbuzz for both using while loop
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int num;
            num = int.Parse(Console.ReadLine());

            if (num > 0) 
            {
                int i = 1; 

                while (i <= num)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }

                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }

                    i++;
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
    }
}
