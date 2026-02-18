namespace AbstractClass.Models;

internal class Student : Person, IComparable
{
    public double Point { get; set; }

    public int CompareTo(object? obj)
    {
        return this.Name.Length.CompareTo((obj as Student).Name.Length);
    }

    public override void Role()
    {
        Console.WriteLine("Telebedir");
    }

    public override string ToString()
    {
        return $"Name: {this.Name} Point: {this.Point}";
    }
}
