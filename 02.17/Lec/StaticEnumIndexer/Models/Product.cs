using StaticEnumIndexer.Enums;

namespace StaticEnumIndexer.Models;

internal class Product
{
    public static int ID;
    public int Id { get; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public ProductStatus Status { get; set; }

    public Product()
    {
        ID++;
        Id = ID;
        //Console.WriteLine("Adi contstuctor ise dusdu");
    }

    static Product()
    {
        //Console.WriteLine("Static constructor ise dusdu");
    }

    // operator overloading

    public static Product operator +(Product p1, Product p2)
    {
        Product newProduct = new Product()
        {
            Name = p1.Name,
            Price = p1.Price,
            Stock = p1.Stock + p2.Stock
        };
        return newProduct;
    }
    public static Product operator -(Product p1, Product p2)
    {
        Product newProduct = new Product()
        {
            Name = p1.Name,
            Price = p1.Price,
            Stock = p1.Stock - p2.Stock
        };
        return newProduct;
    }

    public static Product operator *(Product p1, Product p2)
    {
        Product newProduct = new Product()
        {
            Name = p1.Name,
            Price = p1.Price,
            Stock = p1.Stock * p2.Stock
        };
        return newProduct;
    }

    public static bool operator >(Product p1, Product p2)
    {
        return p1.Price > p2.Price;
    }

    public static bool operator <(Product p1, Product p2)
    {
        return p1.Price < p2.Price;
    }

    public static bool operator ==(Product p1, Product p2)
    {
        return p1.Price == p2.Price;
    }

    public static bool operator !=(Product p1, Product p2)
    {
        return p1.Price != p2.Price;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Price: {Price}, Stock: {Stock}";
    }
}
