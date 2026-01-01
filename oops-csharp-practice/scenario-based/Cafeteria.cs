using System;

class Cafeteria
{
    static void Main()
    {
        // List of food items available in cafeteria
        string[] foodItems =
        {
            "Idli",
            "Dosa",
            "Vada",
            "Poha",
            "Sandwich",
            "Burger",
            "Pizza",
            "Pasta",
            "Tea",
            "Coffee"
        };

        // Price list corresponding to foodItems index
        int[] foodPrices = { 30,40,25,35,50,80,120,100,15,20 };

        // Stores how many times each item is ordered
        int[] orderQuantity = new int[foodItems.Length];

        while(true)
        {
            // Main menu shown to user
            Console.WriteLine("\n===== CAFETERIA MENU =====");
            Console.WriteLine("1. View Food Menu");
            Console.WriteLine("2. Place Order");
            Console.WriteLine("3. Exit and Generate Bill");
            Console.Write("Enter your choice: ");

            int userChoice = int.Parse(Console.ReadLine());

            if(userChoice==1)
            {
                ShowMenu(foodItems,foodPrices);
            }
            else if(userChoice==2)
            {
                TakeOrder(foodItems,orderQuantity);
            }
            else if(userChoice==3)
            {
                GenerateBill(foodItems,foodPrices,orderQuantity);
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }

    // Displays all food items along with prices
    static void ShowMenu(string[] items,int[] prices)
    {
        Console.WriteLine("\n--- Available Items ---");
        for(int i=0;i<items.Length;i++)
        {
            Console.WriteLine(i+" : "+items[i]+" - ₹"+prices[i]);
        }
    }

    // Allows user to select food items to order
    static void TakeOrder(string[] items,int[] quantity)
    {
        Console.Write("Enter item number to order (-1 to finish): ");
        int index=int.Parse(Console.ReadLine());

        while(index!=-1)
        {
            quantity[index]++;
            Console.WriteLine(items[index]+" added to your order.");

            Console.Write("Enter item number to order (-1 to finish): ");
            index=int.Parse(Console.ReadLine());
        }
    }

    // Calculates and displays final bill
    static void GenerateBill(string[] items,int[] prices,int[] quantity)
    {
        Console.WriteLine("\n===== FINAL BILL =====");
        int totalAmount=0;
        bool anyOrder=false;

        for(int i=0;i<items.Length;i++)
        {
            if(quantity[i]>0)
            {
                int itemCost=quantity[i]*prices[i];
                Console.WriteLine(items[i]+" x "+quantity[i]+" = ₹"+itemCost);
                totalAmount+=itemCost;
                anyOrder=true;
            }
        }

        if(!anyOrder)
        {
            Console.WriteLine("No food items were ordered.");
        }
        else
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Total Payable Amount: ₹"+totalAmount);
        }
    }
}
