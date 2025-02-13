using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    public static List<List<int>> FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> SumMap = new Dictionary<int, List<int>>();
        int Sum = 0;
        List<List<int>> result = new List<List<int>>();

        SumMap[0] = new List<int> { -1 };

        for (int i = 0; i < arr.Length; i++)
        {
            Sum += arr[i];

            if (SumMap.ContainsKey(Sum))
            {
                foreach (int startIndex in SumMap[Sum])
                {
                    List<int> subarray = new List<int>();
                    for (int j = startIndex + 1; j <= i; j++)
                    {
                        subarray.Add(arr[j]);
                    }
                    result.Add(subarray);
                }

               SumMap[Sum].Add(i);
            }
            else
            {
               SumMap[Sum] = new List<int> { i };
            }
        }

        return result;
    }

    static void Main()
    {
        int[] arr = { 8, -3, 3, -1, 4, -2, 5 };
        
        List<List<int>> subarrays = FindZeroSumSubarrays(arr);
        
        Console.WriteLine("Subarrays with zero sum:");
        foreach (var subarray in subarrays)
        {
            Console.WriteLine("[" + string.Join(", ", subarray) + "]");
        }
    }
}
