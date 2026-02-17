using StaticEnumIndexer.Helpers;
using StaticEnumIndexer.Models;

namespace StaticEnumIndexer.Services;

internal class ProductService
{
    private static Product[] Products = [];

    public void Add(Product product)
    {
        Array.Resize(ref Products, Products.Length + 1);
        Products[Products.Length - 1] = product;
    }

    public void GetAll()
    {
        foreach (var product in Products)
        {
            Console.WriteLine($"Id: {product.Id} Name: {product.Name} Price: {product.Price}");
        }
    }

    public Product this[string name]
    {
        get
        {
            foreach (var item in Products)
            {
                if (item.Name == name)
                    return item;
            }
            return null;
        }
    }
}
