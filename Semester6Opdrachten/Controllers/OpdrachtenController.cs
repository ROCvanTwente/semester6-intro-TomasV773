using Microsoft.AspNetCore.Mvc;
using Semester6Opdrachten.ExtensionMethods;

namespace Semester6Opdrachten.Controllers
{
	public class OpdrachtenController : Controller
	{
		[HttpGet]
		public IActionResult ExtensionMethods()
		{
			return View();
		}

		[HttpPost]
		public IActionResult ExtensionMethods(string inputWord)
		{
			ViewBag.IsPalindrome = !string.IsNullOrEmpty(inputWord) && inputWord.IsPalindrome();
			return View((object)inputWord);
		}
	}
}
