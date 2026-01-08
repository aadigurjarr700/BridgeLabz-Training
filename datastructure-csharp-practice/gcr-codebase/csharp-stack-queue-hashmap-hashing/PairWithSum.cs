using System;
using System.Collections.Generic;

class PairWithSum
{
    // Function to check if a pair exists
    public static bool HasPair(int[] arr, int target)
    {
        // Set to store visited elements
        HashSet<int> visited = new HashSet<int>();

        foreach (int num in arr)
        {
            int required = target - num;

            // If required number is already seen, pair exists
            if (visited.Contains(required))
            {
                Console.WriteLine("Pair found: " + num + " and " + required);
                return true;
            }

            // Store current number
            visited.Add(num);
        }

        // No pair found
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 8, 7, 2, 5, 3, 1 };
        int target = 10;

        bool result = PairWithSum.HasPair(arr, target);

        if (!result)
        {
            Console.WriteLine("No pair found with the given sum");
        }
    }
}
