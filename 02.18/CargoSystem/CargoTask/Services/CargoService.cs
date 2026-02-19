using CargoTask.Enums;
using CargoTask.Interfaces;
using CargoTask.Models;

namespace CargoTask.Services;
internal class CargoService : ICargoService
{
    private static Courier[] Couriers = [];
    private static Customer[] Customers = [];
    private static CargoOrder[] Orders = [];

    public void AddCourier(Courier courier)
    {
        Array.Resize(ref Couriers, Couriers.Length + 1);
        Couriers[^1] = courier;
    }

    public void AddCustomer(Customer customer)
    {
        Array.Resize(ref Customers, Customers.Length + 1);
        Customers[^1] = customer;
    }

    public void CompleteOrder(int id)
    {
        CargoOrder currOrder = null;
        foreach (var order in Orders)
        {
            if(order.Id == id)
            {
                currOrder = order;
                break;
            }
        }
        if (currOrder == null) 
            throw new Exception("Order not found");

        currOrder.UpdateStatus(OrderStatus.Delivered);
        int courierId = currOrder.CourierId;
        foreach (var courier in Couriers)
        {
            if(courier.Id == courierId)
            {
                courier.IsAvialable = true;
                break;
            }
        }
    }

    public void CreateOrder(CargoOrder order)
    {
        int customerId = order.CustomerId;
        bool customerExists = false;
        foreach (var customer in Customers)
        {
            if(customer.Id == customerId)
            {
                customerExists = true;
                break;
            }
        }
        if (!customerExists) 
            throw new Exception("Customer not found");

        int courierId = order.CourierId;
        bool courierExists = false;
        foreach (var courier in Couriers)
        {
            if(courier.Id == courierId && courier.IsAvialable)
            {
                courierExists = true;
                courier.IsAvialable = false;
                break;
            }
        }
        if (!courierExists) 
            throw new Exception("Courier not found or not available");

        Array.Resize(ref Orders, Orders.Length + 1);
        Orders[^1] = order;
    }
}
