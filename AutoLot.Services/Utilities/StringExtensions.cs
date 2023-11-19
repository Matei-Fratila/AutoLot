namespace AutoLot.Services.Utilities;
public static class StringExtensions
{
    public static string RemoveController(this string original)
        => original.Replace("Controller", string.Empty, StringComparison.OrdinalIgnoreCase);

    public static string RemoveAsyncSuffix(this string original)
        => original.Replace("Async", string.Empty, StringComparison.OrdinalIgnoreCase);

    public static string RemovePageModelSuffix(this string original)
        => original.Replace("PageModel", string.Empty, StringComparison.OrdinalIgnoreCase);
}
