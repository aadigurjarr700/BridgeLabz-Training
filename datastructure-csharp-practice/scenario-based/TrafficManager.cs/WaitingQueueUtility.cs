class WaitingQueueUtility
{
    int[] queue;
    int front = 0, rear = -1, size = 0;

    public WaitingQueueUtility(int capacity)
    {
        queue = new int[capacity];
    }

    public bool IsEmpty() => size == 0;
    public bool IsFull() => size == queue.Length;

    public void Enqueue(int data)
    {
        if (IsFull())
        {
            Console.WriteLine("Waiting queue full");
            return;
        }
        queue[++rear] = data;
        size++;
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Waiting queue empty");
            return -1;
        }
        size--;
        return queue[front++];
    }

    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("No waiting vehicles");
            return;
        }

        Console.Write("Waiting Queue: ");
        for (int i = front; i <= rear; i++)
            Console.Write(queue[i] + " ");
        Console.WriteLine();
    }
}
