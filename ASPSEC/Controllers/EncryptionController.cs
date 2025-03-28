using Microsoft.AspNetCore.Mvc;

namespace ASPSEC.Controllers
{
	public class EncryptionController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Encrypt(string inputText, int key)
		{
			if (string.IsNullOrEmpty(inputText) || key == 0)
			{
				ViewBag.ErrorMessage = "Voer een geldige tekst en sleutel in.";
				return View("Index");
			}

			string encryptedText = EncryptionFunctions.Encrypt(inputText, key);
			ViewBag.EncryptedText = encryptedText;

			return View("Index");
		}

		[HttpPost]
		public IActionResult Decrypt(string encryptedText, int key)
		{
			if (string.IsNullOrEmpty(encryptedText) || key == 0)
			{
				ViewBag.ErrorMessage = "Voer een geldige versleutelde tekst en sleutel in.";
				return View("Index");
			}

			string decryptedText = EncryptionFunctions.Decrypt(encryptedText, key);
			ViewBag.DecryptedText = decryptedText;

			return View("Index");
		}
	}
}
