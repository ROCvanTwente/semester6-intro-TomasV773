using CSHARP31.DierenLibrary;
using CSHARP31;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP31MVC.Controllers
{
	public class DierenController : Controller
	{
		public IActionResult Index()
		{
			var dieren = new List<Dier>
			{
				new Hond(25),
				new Kip(3),
				new Varken(100)
			};

			return View(dieren);
		}
	}
}
