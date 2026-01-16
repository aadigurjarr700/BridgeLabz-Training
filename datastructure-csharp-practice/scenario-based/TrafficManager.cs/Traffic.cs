using System;

namespace TrafficManager;

class Traffic
{
    static void Main()
    {
        TrafficMenu traffic = new TrafficMenu(5, 5);

        int choice;
        do
        {
            Console.WriteLine("\n--- TRAFFIC MENU ---");
            Console.WriteLine("1. Enter Vehicle");
            Console.WriteLine("2. Exit Vehicle");
            Console.WriteLine("3. Show Traffic Status");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Vehicle Number: ");
                    int v = int.Parse(Console.ReadLine());
                    traffic.EnterVehicle(v);
                    break;

                case 2:
                    traffic.ExitVehicle();
                    break;

                case 3:
                    traffic.ShowTrafficStatus();
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 0);
    }
}
