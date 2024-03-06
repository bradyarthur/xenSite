// Define event types
public class OrderPlacedEvent { /* Event data */ }
public class OrderProcessedEvent { /* Event data */ }
public class InventoryUpdatedEvent { /* Event data */ }

// Event producers
public class OrderService
{
    public event EventHandler<OrderPlacedEvent> OrderPlaced;

    public void PlaceOrder(Order order)
    {
        // Logic to place order
        OnOrderPlaced(new OrderPlacedEvent(/* Event data */));
    }

    protected virtual void OnOrderPlaced(OrderPlacedEvent e)
    {
        OrderPlaced?.Invoke(this, e);
    }
}

public class Order
{
}

public class InventoryService
{
    public event EventHandler<InventoryUpdatedEvent> InventoryUpdated;

    public void UpdateInventory(Order order)
    {
        // Logic to update inventory
        OnInventoryUpdated(new InventoryUpdatedEvent(/* Event data */));
    }

    protected virtual void OnInventoryUpdated(InventoryUpdatedEvent e)
    {
        InventoryUpdated?.Invoke(this, e);
    }
}

// Event consumers
public class NotificationService
{
    public void Subscribe(OrderService orderService)
    {
        orderService.OrderPlaced += (sender, e) =>
        {
            // Logic to send order confirmation notifications
        };
    }
}

public class InventoryManagementService
{
    public void Subscribe(OrderService orderService, InventoryService inventoryService)
    {
        orderService.OrderPlaced += (sender, e) =>
        {
            // Logic to update inventory
        };

        inventoryService.InventoryUpdated += (sender, e) =>
        {
            // Logic to manage inventory
        };
    }
}

// Usage
class ProgramX
{
    static void Main(string[] args)
    {
        var orderService = new OrderService();
        var inventoryService = new InventoryService();
        var notificationService = new NotificationService();
        var inventoryManagementService = new InventoryManagementService();

        notificationService.Subscribe(orderService);
        inventoryManagementService.Subscribe(orderService, inventoryService);

        // Example: Place an order
        orderService.PlaceOrder(new Order());
    }
}
