using System;
using System.Collections.Generic;

class SlidingWindow
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums.Length == 0 || k == 0)
            return new int[0];

        int n = nums.Length;
        int[] result = new int[n - k + 1];

        // Deque to store indices
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            // Remove indices that are out of current window
            if (deque.Count > 0 && deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            // Remove smaller elements from the back
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
            {
                deque.RemoveLast();
            }

            // Add current index
            deque.AddLast(i);

            // Store result once first window is complete
            if (i >= k - 1)
            {
                result[i - k + 1] = nums[deque.First.Value];
            }
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;

        int[] maxValues = SlidingWindow.MaxSlidingWindow(nums, k);

        Console.WriteLine("Sliding Window Maximum:");
        foreach (int val in maxValues)
        {
            Console.Write(val + " ");
        }
    }
}
