using System;

// Base class representing a basic order
class Order
{
    public int OrderId;          // Unique order number
    public string OrderDate;     // Date when order was placed

    // Constructor for base order details
    public Order(int orderId, string orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    // Method to return order status
    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }
}

// Second level class representing shipped order
class ShippedOrder : Order
{
    public string TrackingNumber;   // Tracking ID for shipment

    // Constructor initializes order and shipping details
    public ShippedOrder(int orderId, string orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    // Overriding status for shipped order
    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }
}

// Third level class representing delivered order
class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate;   // Date when order was delivered

    // Constructor initializes all previous level data
    public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    // Final status for delivered order
    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }
}

class Program
{
    static void Main()
    {
        // Taking order details from user
        Console.Write("Enter Order ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Order Date: ");
        string orderDate = Console.ReadLine();

        Console.Write("Enter Tracking Number: ");
        string tracking = Console.ReadLine();

        Console.Write("Enter Delivery Date: ");
        string deliveryDate = Console.ReadLine();

        // Creating delivered order object
        DeliveredOrder order = new DeliveredOrder(id, orderDate, tracking, deliveryDate);

        // Displaying order information
        Console.WriteLine("\nOrder Details:");
        Console.WriteLine($"Order ID: {order.OrderId}");
        Console.WriteLine($"Order Date: {order.OrderDate}");
        Console.WriteLine($"Tracking Number: {order.TrackingNumber}");
        Console.WriteLine($"Delivery Date: {order.DeliveryDate}");
        Console.WriteLine($"Current Status: {order.GetOrderStatus()}");
    }
}
