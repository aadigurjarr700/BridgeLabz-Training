using System;
using System.Collections.Generic;

class MyQueue
{
    // Stack for adding elements
    Stack<int> stack1 = new Stack<int>();

    // Stack for removing elements
    Stack<int> stack2 = new Stack<int>();

    // Enqueue operation
    public void Enqueue(int value)
    {
        stack1.Push(value);
    }

    // Dequeue operation
    public int Dequeue()
    {
        // Move elements only when stack2 is empty
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        // Queue is empty
        if (stack2.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }

        return stack2.Pop();
    }

    // Peek front element
    public int Peek()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        if (stack2.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }

        return stack2.Peek();
    }

    // Check if queue is empty
    public bool IsEmpty()
    {
        return stack1.Count == 0 && stack2.Count == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyQueue queue = new MyQueue();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine("Dequeue: " + queue.Dequeue()); // 10
        Console.WriteLine("Peek: " + queue.Peek());       // 20
        Console.WriteLine("Dequeue: " + queue.Dequeue()); // 20
        Console.WriteLine("Is Queue Empty? " + queue.IsEmpty());

        queue.Enqueue(40);
        Console.WriteLine("Dequeue: " + queue.Dequeue()); // 30
    }
}
