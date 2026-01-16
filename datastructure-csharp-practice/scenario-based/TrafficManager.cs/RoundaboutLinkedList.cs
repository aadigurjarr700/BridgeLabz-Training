using System;

namespace TrafficManager;

public class RoundaboutLinkedList
{
    private Node head;
    private int capacity;
    private int count;

    public RoundaboutLinkedList(int capacity)
    {
        this.capacity = capacity;
        count = 0;
    }

    public bool IsFull(){
        return count == capacity;
        
        }
    public bool IsEmpty(){
        return  head == null;
        
        }

    public void AddVehicle(int data)
    {
        if (IsFull())
        {
            Console.WriteLine("Roundabout is FULL");
            return;
        }

        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
        }
        else
        {
            Node temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Next = head;
        }

        count++;
    }

    public void RemoveVehicle()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Roundabout is EMPTY");
            return;
        }

        if (head.Next == head)
        {
            head = null;
        }
        else
        {
            Node temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            head = head.Next;
            temp.Next = head;
        }

        count--;
    }

    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("No vehicles in roundabout");
            return;
        }

        Node temp = head;
        do
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("(CIRCULAR)");
    }
}
