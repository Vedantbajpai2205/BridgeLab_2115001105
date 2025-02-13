using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    public static bool HasPairWithSum(int[] arr, int target)
    {
        HashSet<int> seenNumbers = new HashSet<int>();

        foreach (int num in arr)
        {
            int complement = target - num;

            if (seenNumbers.Contains(complement))
            {
                return true; 
            }

            seenNumbers.Add(num);
        }

        return false;  
    }

    static void Main()
    {
        int[] arr = { 10, 15, 3, 7 };
        int target = 16;

        if (HasPairWithSum(arr, target))
        {
            Console.WriteLine("There exists a pair with the given sum.");
        }
        else
        {
            Console.WriteLine("No pair exists with the given sum.");
        }
    }
}
