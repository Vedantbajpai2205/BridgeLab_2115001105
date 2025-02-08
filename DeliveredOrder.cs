using System;

public class Order
{
    public string OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    public Order(string orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order placed on " + OrderDate.ToShortDateString();
    }
}

public class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }

    public ShippedOrder(string orderId, DateTime orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order shipped with tracking number: " + TrackingNumber;
    }
}

public class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate { get; set; }

    public DeliveredOrder(string orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order delivered on: " + DeliveryDate.ToShortDateString();
    }
    public static void Main(string[] args)
    {
        Order order = new Order("O12345", DateTime.Now);
        ShippedOrder shippedOrder = new ShippedOrder("O12346", DateTime.Now.AddDays(-1), "TN98765");
        DeliveredOrder deliveredOrder = new DeliveredOrder("O12347", DateTime.Now.AddDays(-2), "TN98766", DateTime.Now);

        Console.WriteLine(order.GetOrderStatus());
        Console.WriteLine(shippedOrder.GetOrderStatus());
        Console.WriteLine(deliveredOrder.GetOrderStatus());
    }
}
