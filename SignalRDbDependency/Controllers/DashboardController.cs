﻿using Microsoft.AspNetCore.Mvc;

namespace SignalRDbDependency.Controllers
{
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
