namespace StaticEnumIndexer.Helpers;

internal static class StringHelper
{
    public static char GetLastLetter(this string str)
    {
        return str[str.Length - 1];
    }

    public static string Elave(this string str, params string[] elaveler)
    {
        foreach (var item in elaveler)
        {
            str = str + " " + item;
        }
        return str;
    }
}
