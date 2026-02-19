namespace CargoTask.Models;
internal class Courier
{
    private static int ID;
    public int Id { get; }
    public string Name { get; set; }
    public bool IsAvialable { get; set; }
    public Courier(string name)
    {
        ID++;
        Id = ID;
        Name = name;
        IsAvialable = true;
    }
}
