using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    public static int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;

        HashSet<int> numSet = new HashSet<int>();
        foreach (var num in nums)
        {
            numSet.Add(num);
        }

        int longestStreak = 0;

        foreach (var num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }

    static void Main()
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };

        int result = LongestConsecutive(nums);
        Console.WriteLine("Length of the longest consecutive sequence: " + result);
    }
}
