namespace FoSouza.String.Extensions
{
    public static class StringExtensions
    {
        public static string? ClearBarcode(this string barcode)
        {
            if (barcode == string.Empty || string.IsNullOrWhiteSpace(barcode))
                return default;

            return barcode.Replace(".", string.Empty)
                          .Replace("-", string.Empty)
                          .Replace(" ", string.Empty);
        }
    }
}