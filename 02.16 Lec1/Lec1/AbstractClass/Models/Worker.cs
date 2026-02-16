namespace AbstractClass.Models;

internal class Worker : Person
{
    public decimal Salary { get; set; }

    public override void Role()
    {
        Console.WriteLine("Isicidir");
    }
}
