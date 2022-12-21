using System.Globalization;

namespace TelasiFetcher.Extensions;

public static class DateExtensions
{
    public static DateTime ToDate(this string input, string format)
    {
        DateTime.TryParseExact(input, format, null, DateTimeStyles.None, out var date);
        return date;
    }
}