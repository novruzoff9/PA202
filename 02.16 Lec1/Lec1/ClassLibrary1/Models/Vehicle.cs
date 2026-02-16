namespace ClassLibrary1.Models;

public class Vehicle
{
    internal protected string Name { get; set; }
}


public class Car : Vehicle
{
    public Car()
    {
        Name = "dsad";
    }
}