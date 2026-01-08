using System;
using System.Collections.Generic;

class StackSorter
{
    // Function to sort the stack
    public static void SortStack(Stack<int> stack)
    {
        // Base case: empty stack
        if (stack.Count == 0)
            return;

        // Remove top element
        int top = stack.Pop();

        // Sort the remaining stack
        SortStack(stack);

        // Insert the removed element at correct position
        InsertInSortedOrder(stack, top);
    }

    // Helper function to insert element in sorted order
    private static void InsertInSortedOrder(Stack<int> stack, int value)
    {
        // If stack is empty or top element is smaller, push value
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }

        // Remove top element
        int temp = stack.Pop();

        // Recursive call
        InsertInSortedOrder(stack, value);

        // Put the element back
        stack.Push(temp);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(30);
        stack.Push(10);
        stack.Push(50);
        stack.Push(20);

        Console.WriteLine("Before Sorting:");
        PrintStack(stack);

        StackSorter.SortStack(stack);

        Console.WriteLine("\nAfter Sorting (Ascending Order):");
        PrintStack(stack);
    }

    // Utility method to print stack
    static void PrintStack(Stack<int> stack)
    {
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
