using System.Collections.Generic;
using System;

namespace DayFinder.Objects
{
	public class DayOfWeek
	{
		public int Day {get; set;}
		public int Month {get; set;}
		public int Year {get; set;}


		public DayOfWeek(int day, int month, int year, int century)
		{
			this.Day = day;
			this.Month = month;
			this.Year = year;

		}

		public string DayFinder()
		{
			string yearString = this.Year.ToString();

			string yearEnd = yearString.Substring(2,2);
			string yearStart = yearString.Substring(0,2);
			string yearEndNew = "";
			if (this.Month == 1 || this.Month == 2)
			{
					int yearEndInt = int.Parse(yearEnd);
					yearEndInt = yearEndInt - 1;
					yearEndNew = yearEndInt.ToString();
			}
			return yearEndNew;
		}
	}
}
