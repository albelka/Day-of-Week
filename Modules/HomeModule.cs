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
		}
	}
}
