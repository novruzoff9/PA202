using CargoTask.Models;

namespace CargoTask.Interfaces;
internal interface ICargoService
{
    void AddCustomer(Customer customer);
    void AddCourier(Courier courier);
    void CreateOrder(CargoOrder order);
    void CompleteOrder(int id);
}
