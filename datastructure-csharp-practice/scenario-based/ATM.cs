using System;

class ATM
{
    static void Main()
    {
        Console.Write("Enter amount to withdraw: ₹");
        int amount = int.Parse(Console.ReadLine());

        int choice;
        do
        {
            Console.WriteLine("\n--- ATM Menu ---");
            Console.WriteLine("1. All Notes Available");
            Console.WriteLine("2. Remove ₹500 Note");
            Console.WriteLine("3. Limited Notes (Fallback Scenario)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int[] notesA = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
                    Dispense(amount, notesA);
                    break;

                case 2:
                    int[] notesB = { 200, 100, 50, 20, 10, 5, 2, 1 };
                    Dispense(amount, notesB);
                    break;

                case 3:
                    int[] notesC = { 200, 100, 50 };
                    Dispense(amount, notesC);
                    break;

                case 4:
                    Console.WriteLine("Thank you for using ATM.");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
        while (choice != 4);
    }

    static void Dispense(int amount, int[] notes)
    {
        int remaining = amount;
        int totalNotes = 0;

        Console.WriteLine("\nDispensing Notes:");

        foreach (int note in notes)
        {
            int count = remaining / note;
            if (count > 0)
            {
                Console.WriteLine("₹" + note + " x " + count);
                remaining -= note * count;
                totalNotes += count;
            }
        }

        if (remaining == 0)
        {
            Console.WriteLine("Total Notes: " + totalNotes);
        }
        else
        {
            Console.WriteLine("⚠ Exact change not possible");
            Console.WriteLine("Remaining Amount: ₹" + remaining);
            Console.WriteLine("Notes Dispensed: " + totalNotes);
        }
    }
}