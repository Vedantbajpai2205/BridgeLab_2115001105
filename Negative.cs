using System;

class Negative
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int result = FindFirstNegativeNumber(arr);

        if (result != -1)
        {
            Console.WriteLine("The first negative number is: " + result);
        }
        else
        {
            Console.WriteLine("No negative number found in the array.");
        }
    }

    static int FindFirstNegativeNumber(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                return arr[i];
            }
        }
        return -1; 
    }
}
