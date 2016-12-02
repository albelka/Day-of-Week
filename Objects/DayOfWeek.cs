using System.Collections.Generic;
using System;

namespace DayFinder.Objects
{
	public class DayOfWeek
	{
		public int Day {get; set;}
		public double Month {get; set;}
		public int Year {get; set;}


		public DayOfWeek( int day, double month, int year)
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
			double yearStartInt = int.Parse(yearStart);
			string yearEndNew = "";
			string result = "";
			double yearEndInt = 0;
			if (this.Month == 1 || this.Month == 2)
			{
					yearEndInt = int.Parse(yearEnd);
					yearEndInt = yearEndInt - 1;
					yearEndNew = yearEndInt.ToString();
			}
			this.Month = (this.Month -2) % 12;
			if(this.Month <= 0)
			{
				this.Month += 12;
			}
			string monthString = this.Month.ToString();
			double phrase1 = Math.Floor(2.6*this.Month - .2);
			double phrase2 = Math.Floor(yearEndInt/4);
			double phrase3 = Math.Floor((yearStartInt)/4);
		  double math = (this.Day + phrase1 + (yearEndInt) + phrase2 + phrase3 - (2*(yearStartInt)))%7;
			Console.WriteLine("this.Day" + this.Day);
			Console.WriteLine("this.Month" + this.Month);
			Console.WriteLine("yearEndInt" + yearEndInt);
			Console.WriteLine("yearStartInt" + yearStartInt);
			Console.WriteLine(math);

			if(math < 0)
			{
				math +=7;
			}
				Console.WriteLine(math);
				if(math == 0)
				{
					result = "Sunday";
				}
				else if(math == 1)
				{
					result = "Monday";
				}
				else if(math == 2)
				{
					result = "Tuesday";
				}
				else if(math == 3)
				{
					result = "Wednesday";
				}
				else if(math == 4)
				{
					result = "Thursday";
				}
				else if(math == 5)
				{
					result = "Friday";
				}
				else if(math == 6)
				{
					result = "Saturday";
				}

			return result;
		}
	}
}
