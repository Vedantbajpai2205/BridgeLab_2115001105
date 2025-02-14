using System;

class Insertion
{
    static void Main()
    {
        int[] employeeId = { 1234, 4567, 7890, 5678, 2468, 3579, 1122 };

        Console.WriteLine("Original EmpId:");
        PrintArray(employeeId);

        InsertionSort(employeeId);

        Console.WriteLine("Sorted EmpId:");
        PrintArray(employeeId);
    }

    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int current = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > current)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = current;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var id in arr)
        {
            Console.Write(id + " ");
        }
        Console.WriteLine();
    }
}
