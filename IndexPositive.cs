using System;
using System.Linq;

class IndexPositive
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the list:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the list:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int firstMissingPositive = FindFirstMissingPositive(arr);
        Console.WriteLine("The first missing positive integer is: " + firstMissingPositive);

        Console.WriteLine("Enter the target number to search for:");
        int target = int.Parse(Console.ReadLine());

        int targetIndex = BinarySearch(arr, target);
        if (targetIndex != -1)
        {
            Console.WriteLine("The target number " + target + " is found at index " + targetIndex);
        }
        else
        {
            Console.WriteLine("The target number " + target + " is not found.");
        }
    }

    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] <= 0 || arr[i] > n)
            {
                arr[i] = n + 1;
            }
        }

        for (int i = 0; i < n; i++)
        {
            int val = Math.Abs(arr[i]);
            if (val <= n)
            {
                arr[val - 1] = -Math.Abs(arr[val - 1]);
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                return i + 1;
            }
        }

        return n + 1; 
    }

    static int BinarySearch(int[] arr, int target)
    {
        Array.Sort(arr);

        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid;
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

        return -1; 
    }
}
