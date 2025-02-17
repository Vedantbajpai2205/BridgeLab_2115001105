using System;
using System.Diagnostics;

class Sorting
{
    static void Main(string[] args)
    {
        int N = 1000000;
        Random random = new Random();
        int[] data = new int[N];
        for (int i = 0; i < N; i++)
        {
            data[i] = random.Next();
        }

        var stopwatch = Stopwatch.StartNew();
        BubbleSort((int[])data.Clone());
        stopwatch.Stop();
        Console.WriteLine("Bubble Sort Time: " + stopwatch.ElapsedMilliseconds + " ms");

        stopwatch.Restart();
        MergeSort((int[])data.Clone(), 0, N - 1);
        stopwatch.Stop();
        Console.WriteLine("Merge Sort Time: " + stopwatch.ElapsedMilliseconds + " ms");

        stopwatch.Restart();
        QuickSort((int[])data.Clone(), 0, N - 1);
        stopwatch.Stop();
        Console.WriteLine("Quick Sort Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
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

        for (int i = 0; i < n1; i++)
            leftArr[i] = arr[left + i];
        for (int i = 0; i < n2; i++)
            rightArr[i] = arr[middle + 1 + i];

        int i1 = 0, i2 = 0, i = left;
        while (i1 < n1 && i2 < n2)
        {
            if (leftArr[i1] <= rightArr[i2])
            {
                arr[i] = leftArr[i1];
                i1++;
            }
            else
            {
                arr[i] = rightArr[i2];
                i2++;
            }
            i++;
        }

        while (i1 < n1)
        {
            arr[i] = leftArr[i1];
            i1++;
            i++;
        }

        while (i2 < n2)
        {
            arr[i] = rightArr[i2];
            i2++;
            i++;
        }
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }
}
