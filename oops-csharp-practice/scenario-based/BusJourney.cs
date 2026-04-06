using System;

class BusJourney
{
    // This method tracks the bus distance stop by stop
    public void TrackRoute()
    {
        int totalDistance = 0;   // total distance travelled

        // Take distance per stop from user
        Console.Write("Enter distance between each stop (in km): ");
        int distancePerStop = int.Parse(Console.ReadLine());

        Console.WriteLine("\n🚍 Bus Route Distance Tracker Started");

        while(true)
        {
            // Bus moves to the next stop
            totalDistance += distancePerStop;

            Console.WriteLine("\nBus has reached the next stop.");
            Console.WriteLine("Distance covered so far: " + totalDistance + " km");

            // Ask passenger decision
            Console.Write("Do you want to get off here? (yes/no): ");
            string answer = Console.ReadLine().ToLower();

            // If passenger wants to exit
            if(answer == "yes")
            {
                Console.WriteLine("You got off the bus. Safe journey!");
                break;
            }
        }

        // Final message
        Console.WriteLine("\nJourney ended.");
        Console.WriteLine("Total distance travelled: " + totalDistance + " km");
    }
}

class Program
{
    static void Main()
    {
        // Create object of BusJourney class
        BusJourney journey = new BusJourney();

        // Start tracking the bus route
        journey.TrackRoute();
    }
}
