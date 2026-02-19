using CargoTask.Enums;

namespace CargoTask.Models;
internal class CargoOrder
{
    private static int ID;
    public int Id { get; }

    public int CustomerId { get; set; }
    public int CourierId { get; set; }
    public double TotalPrice { get; set; }
    public DateTime CreatedAt { get; set; }
    public OrderStatus Status { get; private set; }
    public CargoOrder(int customerId, int courierId, double totalPrice)
    {
        ID++;
        Id = ID;
        CustomerId = customerId;
        CourierId = courierId;
        TotalPrice = totalPrice;
        CreatedAt = DateTime.Now;
        Status = OrderStatus.Created;
    }

    public void UpdateStatus(OrderStatus newStatus)
    {
        if(Status == OrderStatus.Cancelled || Status == OrderStatus.Delivered)
        {
            throw new InvalidOperationException("Cannot update status of a cancelled or delivered order.");
        }
        Status = newStatus;
    }
}
