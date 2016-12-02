using Nancy;
using System.Collections.Generic;
using DayFinder.Objects;

namespace DayFinder
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				return View["index.cshtml"];
			};
			Post["/"] = _ =>
			{
				int day = int.Parse(Request.Form["day"]);
				double month = double.Parse(Request.Form["month"]);
				int year = int.Parse(Request.Form["year"]);
				DayOfWeek newDayOfWeek = new DayOfWeek(day, month, year);
				string result = newDayOfWeek.DayFinder();
				return View["index.cshtml", result];
			};
		}
	}
}
