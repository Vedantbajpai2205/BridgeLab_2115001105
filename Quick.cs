using System;

class Quick
{
    static void Main()
    {
        int[] productPrices = { 800, 1300, 400, 500, 200, 250, 900, 1500 };

        Console.WriteLine("Original Product Prices:");
        PrintArray(productPrices);

        QuickSort(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("Sorted Product Prices:");
        PrintArray(productPrices);
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            QuickSort(arr, low, pi - 1);  // recursively left sort
            QuickSort(arr, pi + 1, high); // recursively right sort
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; 
        int i = low - 1; 

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                Swap(arr, i, j); 
            }
        }

        Swap(arr, i + 1, high); 
        return i + 1;  
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
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
