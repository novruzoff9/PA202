namespace StaticEnumIndexer.Helpers;

internal static class ProductHelper
{
    public static decimal CalcPrice(this Product product)
    {
        return product.Price * product.Stock;
    }
}
