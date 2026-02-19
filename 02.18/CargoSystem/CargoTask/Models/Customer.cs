namespace CargoTask.Models;
internal class Customer
{
    private static int ID;
    public int Id { get; }
    public string Name { get; set; }
    public string City { get; set; }
    public Customer(string name, string city)
    {
        ID++;
        Id = ID;
        Name = name;
        City = city;
    }
}
