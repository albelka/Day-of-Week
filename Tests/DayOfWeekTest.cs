using Xunit;

namespace DayFinder.Objects
{
  public class DayOfWeekTest
  {
    // [Fact]
    // public void DayFinder_SeparateYear_year()
    // {
    //   string year = "2016";
    //   int yearInt = int.Parse(year);
    //   string month = "01";
    //   int monthInt = int.Parse(month);
    //   DayOfWeek newDayOfWeek = new DayOfWeek(0,monthInt,yearInt,0);
    //
    //   Assert.Equal("15", newDayOfWeek.DayFinder());
    // }
    // [Fact]
    // public void DayFinder_ShiftYear_year()
    // {
    //   string year = "2016";
    //   string month = "01";
    //   int monthInt = int.Parse(month);
    //   int yearInt = int.Parse(year);
    //   DayOfWeek newDayOfWeek = new DayOfWeek(0,monthInt,yearInt,0);
    //
    //   Assert.Equal("15", newDayOfWeek.DayFinder());
    // }
    // [Fact]
    // public void DayFinder_ShiftMonth_month()
    // {
    //   string year = "2016";
    //   string month = "1";
    //   int monthInt = int.Parse(month);
    //   int yearInt = int.Parse(year);
    //   DayOfWeek newDayOfWeek = new DayOfWeek(0,monthInt,yearInt,0);
    //
    //   Assert.Equal("11", newDayOfWeek.DayFinder());
    // }
    // [Fact]
    // public void DayFinder_DayToNumber_day()
    // {
    //   string year = "2016";
    //   string month = "1";
    //   string dayOfWeek = "Saturday";
    //   int monthInt = int.Parse(month);
    //   int yearInt = int.Parse(year);
    //   DayOfWeek newDayOfWeek = new DayOfWeek(dayOfWeek,monthInt,yearInt,0);
    //
    //   Assert.Equal("6", newDayOfWeek.DayFinder());
    // }
    [Fact]
    public void DayFinder_DateToDay_day()
    {
      string year = "1973";
      string month = "12";
      int dayOfMonth = 2;

      int monthInt = int.Parse(month);
      int yearInt = int.Parse(year);
      DayOfWeek newDayOfWeek = new DayOfWeek(dayOfMonth,monthInt,yearInt);

      Assert.Equal("Sunday", newDayOfWeek.DayFinder());
    }
  }
}
