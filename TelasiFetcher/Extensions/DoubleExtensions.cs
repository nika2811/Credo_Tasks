namespace TelasiFetcher.Extensions;

public static class DoubleExtensions
{
    public static double ToDouble(this string input)
    {
        Double.TryParse(input, out var number);
        return number;
    }
}