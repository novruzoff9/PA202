namespace AbstractClass.Models;

internal abstract class Person
{
    public string Name { get; set; }

    public void Age()
    {
        Console.WriteLine("18 yasi var");
    }

    public abstract void Role();
}
