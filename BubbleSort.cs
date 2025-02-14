using System;

class Bubble
{
    static void Main()
    {
        int[] studentMarks = { 75, 82, 58, 90, 65, 88, 72, 99, 67, 55 };

        Console.WriteLine("Original Marks:");
        PrintArray(studentMarks);

        BubbleSort(studentMarks);

        Console.WriteLine("Sorted Marks:");
        PrintArray(studentMarks);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var mark in arr)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }
}
