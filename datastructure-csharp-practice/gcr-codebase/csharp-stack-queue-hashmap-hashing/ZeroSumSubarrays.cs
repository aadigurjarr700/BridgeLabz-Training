using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    // Function to find and print all zero sum subarrays
    public static void FindSubarrays(int[] arr)
    {
        // Dictionary to store cumulative sum and list of indices
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

        int sum = 0;

        // To handle subarrays starting from index 0
        map[0] = new List<int> { -1 };

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            // If sum already exists, zero-sum subarray found
            if (map.ContainsKey(sum))
            {
                foreach (int startIndex in map[sum])
                {
                    Console.WriteLine("Subarray found from index " +
                        (startIndex + 1) + " to " + i);
                }
            }

            // Store current index for this sum
            if (!map.ContainsKey(sum))
                map[sum] = new List<int>();

            map[sum].Add(i);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 3, 4, -7, 1, 3, -4, -2, -2 };

        Console.WriteLine("Zero Sum Subarrays:");
        ZeroSumSubarrays.FindSubarrays(arr);
    }
}
