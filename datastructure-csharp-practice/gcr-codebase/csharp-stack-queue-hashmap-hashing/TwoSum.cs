using System;
using System.Collections.Generic;

class TwoSum
{
    // Function to return indices of two numbers that add up to target
    public static int[] FindTwoSum(int[] nums, int target)
    {
        // Dictionary to store number and its index
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int required = target - nums[i];

            // Check if required number already exists
            if (map.ContainsKey(required))
            {
                return new int[] { map[required], i };
            }

            // Store current number with its index
            // Avoid duplicate key exception
            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }

        // No solution found
        return new int[] { -1, -1 };
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSum.FindTwoSum(nums, target);

        if (result[0] != -1)
        {
            Console.WriteLine("Indices found: " + result[0] + ", " + result[1]);
        }
        else
        {
            Console.WriteLine("No valid pair found");
        }
    }
}
