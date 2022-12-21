using System;
using System.Globalization;

public class DateCalculations
{
    private static readonly TimeZoneInfo TbilisiTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Georgian Standard Time");
    private static readonly TimeZoneInfo LondonTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");

    public static string CurrentDate()
    {
        DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.Now, TbilisiTimeZone);
        return currentTime.ToString("yyyy-MM-dd HH:mm");
    }

    public static string CurrentLondonDate()
    {
        DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.Now, LondonTimeZone);
        return currentTime.ToString("yyyy-MM-dd HH:mm");
    }

    public static int DaysBetween(DateTime startDate, DateTime endDate)
    {
        TimeSpan timeSpan = endDate - startDate;
        return timeSpan.Days;
    }

    public static bool IsLeapYear(int year)
    {
        return DateTime.IsLeapYear(year);
    }

    public static string FirstDayOfPreviousMonth()
    {
        DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.Now, TbilisiTimeZone);
        DateTime firstDayOfPreviousMonth = new DateTime(currentTime.Year, currentTime.Month, 1).AddMonths(-1);
        return firstDayOfPreviousMonth.ToString("yyyy-MM-dd");
    }

    public static string LastDayOfPreviousMonth()
    {
        DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.Now, TbilisiTimeZone);
        DateTime lastDayOfPreviousMonth = new DateTime(currentTime.Year, currentTime.Month, 1).AddDays(-1);
        return lastDayOfPreviousMonth.ToString("yyyy-MM-dd");
    }

    public static string CurrentWeekDay()
    {
        DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.Now, TbilisiTimeZone);
        CultureInfo cultureInfo = new CultureInfo("ka-GE");
        return cultureInfo.DateTimeFormat.GetDayName(currentTime.DayOfWeek);
    }
}








