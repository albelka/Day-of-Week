using Xunit;

namespace DayFinder.Objects
{
  public class DayOfWeekTest
  {
    [Fact]
    public void DayFinder_ShiftYear_year()
    {
      string date = "2016";
      int dateInt = int.Parse(date);
      DayOfWeek newDayOfWeek = new DayOfWeek(0,0,dateInt,0);

      Assert.Equal("16", newDayOfWeek.DayFinder());
    }

  }
}
