using System;
using System.Collections.Generic;

class StockSpan
{
    public static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];

        // Stack to store indices of days
        Stack<int> stack = new Stack<int>();

        // First day span is always 1
        span[0] = 1;
        stack.Push(0);

        for (int i = 1; i < n; i++)
        {
            // Remove days with price less than or equal to current
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            // If stack becomes empty, price is higher than all previous days
            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

            // Push current day index
            stack.Push(i);
        }

        return span;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };

        int[] result = StockSpan.CalculateSpan(prices);

        Console.WriteLine("Stock Prices:");
        foreach (int price in prices)
        {
            Console.Write(price + " ");
        }

        Console.WriteLine("\n\nStock Span:");
        foreach (int val in result)
        {
            Console.Write(val + " ");
        }
    }
}
