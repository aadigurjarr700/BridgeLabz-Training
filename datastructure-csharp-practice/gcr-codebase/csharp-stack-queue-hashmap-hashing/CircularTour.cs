using System;

class CircularTour
{
    // Function to find starting petrol pump index
    public static int FindStartingPump(int[] petrol, int[] distance)
    {
        int totalPetrol = 0;
        int currentPetrol = 0;
        int startIndex = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            int balance = petrol[i] - distance[i];

            totalPetrol += balance;
            currentPetrol += balance;

            // If petrol becomes negative, move start point
            if (currentPetrol < 0)
            {
                startIndex = i + 1;
                currentPetrol = 0;
            }
        }

        // If total petrol is enough, return start index
        return (totalPetrol >= 0) ? startIndex : -1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] petrol = { 6, 3, 7 };
        int[] distance = { 4, 6, 3 };

        int start = CircularTour.FindStartingPump(petrol, distance);

        if (start != -1)
            Console.WriteLine("Start at petrol pump index: " + start);
        else
            Console.WriteLine("No possible circular tour");
    }
}
