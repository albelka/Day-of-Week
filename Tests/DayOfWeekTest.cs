using Xunit;

namespace DayFinder.Objects
{
  public class DayOfWeekTest
  {
    // [Fact]
    // public void DayFinder_SeparateYear_year()
    // {
    //   string date = "2016";
    //   int dateInt = int.Parse(date);
    //   string month = "01";
    //   int monthInt = int.Parse(month);
    //   DayOfWeek newDayOfWeek = new DayOfWeek(0,monthInt,dateInt,0);
    //
    //   Assert.Equal("15", newDayOfWeek.DayFinder());
    // }
    // [Fact]
    // public void DayFinder_ShiftYear_year()
    // {
    //   string date = "2016";
    //   string month = "01";
    //   int monthInt = int.Parse(month);
    //   int dateInt = int.Parse(date);
    //   DayOfWeek newDayOfWeek = new DayOfWeek(0,monthInt,dateInt,0);
    //
    //   Assert.Equal("15", newDayOfWeek.DayFinder());
    // }
    [Fact]
    public void DayFinder_ShiftMonth_month()
    {
      string date = "2016";
      string month = "1";
      int monthInt = int.Parse(month);
      int dateInt = int.Parse(date);
      DayOfWeek newDayOfWeek = new DayOfWeek(0,monthInt,dateInt,0);

      Assert.Equal("11", newDayOfWeek.DayFinder());
    }
  }
}
