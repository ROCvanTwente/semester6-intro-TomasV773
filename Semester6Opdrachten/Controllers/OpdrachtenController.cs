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
		public IActionResult CheckPalindrome(string inputWord)
		{
			ViewBag.IsPalindrome = !string.IsNullOrEmpty(inputWord) && inputWord.IsPalindrome();
			return View("ExtensionMethods", (object)inputWord);
		}

		[HttpPost]
		public IActionResult CheckCurrency(decimal amount, CurrencyCountry country)
		{
			ViewBag.CurrencyExample = amount.ToCurrencyString(country);
			return View("ExtensionMethods");
		}

		[HttpPost]
		public IActionResult CheckEvenNumber(string inputNumber)
		{
			if (int.TryParse(inputNumber, out int number))
			{
				ViewBag.IsEven = number.IsEven();
			}
			else
			{
				ViewBag.IsEven = false; 
			}
			return View("ExtensionMethods");
		}

		[HttpPost]
		public IActionResult FirstCharToUpper(string inputString)
		{
			ViewBag.FirstCharToUpper = inputString?.FirstCharToUpper();
			return View("ExtensionMethods");
		}
	}
}
