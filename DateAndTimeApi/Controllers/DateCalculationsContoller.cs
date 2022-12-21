using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class DateCalculationsController : Controller
{
    [HttpGet("current-date")]
    public IActionResult CurrentDate()
    {
        var currentDate = DateCalculations.CurrentDate();
        return Ok(currentDate);
    }

    [HttpGet("current-london-date")]
    public IActionResult CurrentLondonDate()
    {
        var currentLondonDate = DateCalculations.CurrentLondonDate();
        return Ok(currentLondonDate);
    }

    [HttpGet("days-between")]
    public IActionResult DaysBetween(DateTime startDate, DateTime endDate)
    {
        var daysBetween = DateCalculations.DaysBetween(startDate, endDate);
        return Ok(daysBetween);
    }

    [HttpGet("is-leap-year")]
    public IActionResult IsLeapYear(int year)
    {
        var isLeapYear = DateCalculations.IsLeapYear(year);
        return Ok(isLeapYear);
    }

    [HttpGet("first-day-of-previous-month")]
    public IActionResult FirstDayOfPreviousMonth()
    {
        var firstDayOfPreviousMonth = DateCalculations.FirstDayOfPreviousMonth();
        return Ok(firstDayOfPreviousMonth);
    }

    [HttpGet("last-day-of-previous-month")]
    public IActionResult LastDayOfPreviousMonth()
    {
        var lastDayOfPreviousMonth = DateCalculations.LastDayOfPreviousMonth();
        return Ok(lastDayOfPreviousMonth);
    }

    [HttpGet("current-week-day")]
    public IActionResult CurrentWeekDay()
    {
        var currentWeekDay = DateCalculations.CurrentWeekDay();
        return Ok(currentWeekDay);
    }
}