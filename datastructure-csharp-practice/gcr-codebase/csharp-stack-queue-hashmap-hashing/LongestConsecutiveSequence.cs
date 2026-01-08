using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    public static int FindLongestSequence(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        HashSet<int> set = new HashSet<int>();

        // Add all elements to the set
        foreach (int num in nums)
        {
            set.Add(num);
        }

        int longest = 0;

        foreach (int num in set)
        {
            // Check if it's the start of a sequence
            if (!set.Contains(num - 1))
            {
                int current = num;
                int length = 1;

                // Count consecutive numbers
                while (set.Contains(current + 1))
                {
                    current++;
                    length++;
                }

                // Update longest length
                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };

        int result = LongestConsecutiveSequence.FindLongestSequence(nums);

        Console.WriteLine("Length of longest consecutive sequence: " + result);
    }
}
