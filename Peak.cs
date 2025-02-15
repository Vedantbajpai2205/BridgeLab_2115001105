using System;

class Peak
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int peakIndex = FindPeakElement(arr);

        Console.WriteLine("The peak element is: " + arr[peakIndex]);
    }

    static int FindPeakElement(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if ((mid == 0 || arr[mid - 1] <= arr[mid]) && (mid == arr.Length - 1 || arr[mid + 1] <= arr[mid]))
            {
                return mid;
            }
            else if (mid > 0 && arr[mid - 1] > arr[mid])
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
