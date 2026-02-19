// See https://aka.ms/new-console-template for more information
using CargoTask.Enums;
using CargoTask.Interfaces;
using CargoTask.Models;
using CargoTask.Services;

Customer customer = new Customer("John Doe", "New York");
Courier courier = new Courier("Jane Smith");

CargoOrder order = new CargoOrder(customer.Id, 2, 100.0);

ICargoService cargoService = new CargoService();

cargoService.AddCustomer(customer);
cargoService.AddCourier(courier);

cargoService.CreateOrder(order);

