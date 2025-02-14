using System;

class Heap
{
    static void Main()
    {
        int[] salaryDemands = { 3500, 5500, 3000, 4000, 2000, 4500, 6000, 7000 };

        Console.WriteLine("Original Salary :");
        PrintArray(salaryDemands);

        HeapSort(salaryDemands);

        Console.WriteLine("Sorted Salary :");
        PrintArray(salaryDemands);
    }

    static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            Swap(arr, 0, i);

            Heapify(arr, i, 0);
        }
    }

    static void Heapify(int[] arr, int n, int i)
    {
        int large = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[large])
        {
            large = left;
        }

        if (right < n && arr[right] > arr[large])
        {
            large = right;
        }

        if (large != i)
        {
            Swap(arr, i, large);
            Heapify(arr, n, large);
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
        foreach (var salary in arr)
        {
            Console.Write(salary + " ");
        }
        Console.WriteLine();
    }
}
