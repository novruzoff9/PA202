namespace AbstractClass.Models;

internal sealed class Worker : Person
{
    public decimal Salary { get; set; }

    public override void Role()
    {
        Console.WriteLine("Isicidir");
    }
}