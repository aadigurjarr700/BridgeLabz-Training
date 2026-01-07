using System;

// Node class for Singly Linked List
class InventoryNode
{
    // Item details
    public int ItemId;
    public string ItemName;
    public int Quantity;
    public double Price;

    // Pointer to next node
    public InventoryNode Next;

    // Constructor
    public InventoryNode(int itemId, string itemName, int quantity, double price)
    {
        ItemId = itemId;
        ItemName = itemName;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

// Inventory Linked List class
class InventoryLinkedList
{
    private InventoryNode head;

    // Add item at beginning
    public void AddAtBeginning(int id, string name, int qty, double price)
    {
        InventoryNode newNode = new InventoryNode(id, name, qty, price);
        newNode.Next = head;
        head = newNode;
    }

    // Add item at end
    public void AddAtEnd(int id, string name, int qty, double price)
    {
        InventoryNode newNode = new InventoryNode(id, name, qty, price);

        if (head == null)
        {
            head = newNode;
            return;
        }

        InventoryNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = newNode;
    }

    // Add item at specific position
    public void AddAtPosition(int position, int id, string name, int qty, double price)
    {
        if (position <= 1)
        {
            AddAtBeginning(id, name, qty, price);
            return;
        }

        InventoryNode temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        InventoryNode newNode = new InventoryNode(id, name, qty, price);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    // Remove item by Item ID
    public void RemoveByItemId(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty");
            return;
        }

        if (head.ItemId == id)
        {
            head = head.Next;
            Console.WriteLine("Item removed successfully");
            return;
        }

        InventoryNode temp = head;
        while (temp.Next != null && temp.Next.ItemId != id)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Item not found");
        }
        else
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Item removed successfully");
        }
    }

    // Update quantity by Item ID
    public void UpdateQuantity(int id, int newQty)
    {
        InventoryNode temp = head;

        while (temp != null)
        {
            if (temp.ItemId == id)
            {
                temp.Quantity = newQty;
                Console.WriteLine("Quantity updated successfully");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Item not found");
    }

    // Search by Item ID
    public void SearchById(int id)
    {
        InventoryNode temp = head;

        while (temp != null)
        {
            if (temp.ItemId == id)
            {
                DisplayItem(temp);
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Item not found");
    }

    // Search by Item Name
    public void SearchByName(string name)
    {
        InventoryNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.ItemName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                DisplayItem(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Item not found");
    }

    // Calculate total inventory value
    public void CalculateTotalValue()
    {
        double total = 0;
        InventoryNode temp = head;

        while (temp != null)
        {
            total += temp.Price * temp.Quantity;
            temp = temp.Next;
        }

        Console.WriteLine("Total Inventory Value: " + total);
    }

    // Sort inventory by Item Name
    public void SortByName(bool ascending)
    {
        for (InventoryNode i = head; i != null; i = i.Next)
        {
            for (InventoryNode j = i.Next; j != null; j = j.Next)
            {
                int compare = string.Compare(i.ItemName, j.ItemName, true);

                if ((ascending && compare > 0) || (!ascending && compare < 0))
                {
                    SwapData(i, j);
                }
            }
        }
    }

    // Sort inventory by Price
    public void SortByPrice(bool ascending)
    {
        for (InventoryNode i = head; i != null; i = i.Next)
        {
            for (InventoryNode j = i.Next; j != null; j = j.Next)
            {
                if ((ascending && i.Price > j.Price) || (!ascending && i.Price < j.Price))
                {
                    SwapData(i, j);
                }
            }
        }
    }

    // Display all inventory items
    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty");
            return;
        }

        InventoryNode temp = head;
        while (temp != null)
        {
            DisplayItem(temp);
            temp = temp.Next;
        }
    }

    // Helper method to swap node data
    private void SwapData(InventoryNode a, InventoryNode b)
    {
        (a.ItemId, b.ItemId) = (b.ItemId, a.ItemId);
        (a.ItemName, b.ItemName) = (b.ItemName, a.ItemName);
        (a.Quantity, b.Quantity) = (b.Quantity, a.Quantity);
        (a.Price, b.Price) = (b.Price, a.Price);
    }

    // Helper method to display item
    private void DisplayItem(InventoryNode item)
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Item ID   : " + item.ItemId);
        Console.WriteLine("Item Name : " + item.ItemName);
        Console.WriteLine("Quantity  : " + item.Quantity);
        Console.WriteLine("Price     : " + item.Price);
    }
}

// Main class
class Program
{
    static void Main()
    {
        InventoryLinkedList inventory = new InventoryLinkedList();

        inventory.AddAtEnd(101, "Laptop", 5, 60000);
        inventory.AddAtEnd(102, "Mouse", 20, 500);
        inventory.AddAtBeginning(103, "Keyboard", 10, 1500);

        Console.WriteLine("All Inventory Items:");
        inventory.DisplayAll();

        Console.WriteLine("\nUpdate Quantity:");
        inventory.UpdateQuantity(101, 7);

        Console.WriteLine("\nSearch by Name:");
        inventory.SearchByName("Mouse");

        Console.WriteLine("\nTotal Inventory Value:");
        inventory.CalculateTotalValue();

        Console.WriteLine("\nSort by Price (Ascending):");
        inventory.SortByPrice(true);
        inventory.DisplayAll();

        Console.WriteLine("\nRemove Item ID 102:");
        inventory.RemoveByItemId(102);

        Console.WriteLine("\nFinal Inventory:");
        inventory.DisplayAll();
    }
}
