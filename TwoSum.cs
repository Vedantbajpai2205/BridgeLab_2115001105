using System;
using System.Collections.Generic;

class TwoSum
{
    public static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i }; 
            }

            numMap[nums[i]] = i;
        }

        return new int[] { -1, -1 };
    }

    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = FindTwoSum(nums, target);

        if (result[0] != -1)
        {
            Console.WriteLine("Indices: " + result[0] + ", " + result[1]);
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}
