using System;

class Merge1
{
    static void Main()
    {
        int[] bookPrices = { 99, 199, 299, 399, 129, 499, 599, 249 };

        Console.WriteLine("Original Books Price:");
        PrintArray(bookPrices);

        MergeSort(bookPrices, 0, bookPrices.Length - 1);

        Console.WriteLine("Sorted Books Price:");
        PrintArray(bookPrices);
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(arr, left, middle);
            MergeSort(arr, middle + 1, right);

            Merge(arr, left, middle, right);
        }
    }

    static void Merge(int[] arr, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        Array.Copy(arr, left, leftArr, 0, n1);
        Array.Copy(arr, middle + 1, rightArr, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (leftArr[i] <= rightArr[j])
            {
                arr[k] = leftArr[i];
                i++;
            }
            else
            {
                arr[k] = rightArr[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            arr[k] = leftArr[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            arr[k] = rightArr[j];
            j++;
            k++;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var price in arr)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine();
    }
}
