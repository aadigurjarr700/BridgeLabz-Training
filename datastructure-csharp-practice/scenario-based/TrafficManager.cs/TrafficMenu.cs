using System;

namespace TrafficManager;
public class TrafficMenu : IRoundaboutManager
{
    private RoundaboutLinkedList roundabout;
    private WaitingQueueUtility queue;

    public TrafficMenu(int roundCap, int queueCap)
    {
        roundabout = new RoundaboutLinkedList(roundCap);
        queue = new WaitingQueueUtility(queueCap);
    }

    public  void EnterVehicle(int vehicleNo)
    {
        if (!roundabout.IsFull())
        {
            roundabout.AddVehicle(vehicleNo);
            Console.WriteLine("Vehicle entered roundabout");
        }
        else
        {
            queue.Enqueue(vehicleNo);
            Console.WriteLine("Vehicle added to waiting queue");
        }
    }

    public  void ExitVehicle()
    {
        roundabout.RemoveVehicle();

        if (!queue.IsEmpty())
        {
            int v = queue.Dequeue();
            roundabout.AddVehicle(v);
            Console.WriteLine("Vehicle moved from queue to roundabout");
        }
    }

    public  void ShowTrafficStatus()
    {
        Console.WriteLine("\n--- Traffic Status ---");
        roundabout.Display();
        queue.Display();
    }
}
