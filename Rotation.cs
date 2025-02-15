using System;

class Rotation
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the rotated sorted array:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the rotated sorted array:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int rotationPoint = FindRotationPoint(arr);

        Console.WriteLine("The rotation point index of the smallest element is: " + rotationPoint);
    }

    static int FindRotationPoint(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        if (arr[left] < arr[right])
        {
            return 0;
        }

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] > arr[mid + 1])
            {
                return mid + 1;
            }
            else if (arr[mid] < arr[left])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}
