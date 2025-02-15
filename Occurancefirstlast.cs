using System;

class Occurancefirstlast
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the sorted array:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the sorted array:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the target element to search for:");
        int target = int.Parse(Console.ReadLine());

        int firstOccurrence = FindFirstOccurrence(arr, target);
        int lastOccurrence = FindLastOccurrence(arr, target);

        if (firstOccurrence == -1)
        {
            Console.WriteLine("Target element not found in the array.");
        }
        else
        {
            Console.WriteLine("First occurrence of " + target + " is at index " + firstOccurrence);
            Console.WriteLine("Last occurrence of " + target + " is at index " + lastOccurrence);
        }
    }

    static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int firstOccurrence = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                firstOccurrence = mid;
                right = mid - 1; 
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return firstOccurrence;
    }

    static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int lastOccurrence = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                lastOccurrence = mid;
                left = mid + 1;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return lastOccurrence;
    }
}
