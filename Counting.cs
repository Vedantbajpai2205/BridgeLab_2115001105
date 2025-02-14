using System;

class Counting
{
    static void Main()
    {
        int[] studentAges = { 15, 18, 12, 14, 13, 10, 17, 16, 14, 15, 11 };

        Console.WriteLine("Original Student Ages:");
        PrintArray(studentAges);

        CountingSort(studentAges);

        Console.WriteLine("Sorted Student Ages:");
        PrintArray(studentAges);
    }

    static void CountingSort(int[] arr)
    {
        int minAge = 10;  
        int maxAge = 18; 

        int[] count = new int[maxAge - minAge + 1];

        foreach (var age in arr)
        {
            count[age - minAge]++;
        }

        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }

        int[] result = new int[arr.Length];

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int age = arr[i];
            result[count[age - minAge] - 1] = age;
            count[age - minAge]--;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = result[i];
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var age in arr)
        {
            Console.Write(age + " ");
        }
        Console.WriteLine();
    }
}
