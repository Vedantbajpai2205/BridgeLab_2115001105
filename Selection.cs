using System;

class Selection
{
    static void Main()
    {
        int[] examScores = { 85, 92, 78, 90, 88, 65, 75, 99 };

        Console.WriteLine("Original Scores:");
        PrintArray(examScores);

        SelectionSort(examScores);

        Console.WriteLine("Sorted Scores:");
        PrintArray(examScores);
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                Swap(arr, i, minIndex);
            }
        }
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var score in arr)
        {
            Console.Write(score + " ");
        }
        Console.WriteLine();
    }
}
