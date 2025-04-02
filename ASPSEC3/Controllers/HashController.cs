using System.Security.Cryptography;
using System.Text;
using ASPSEC3.Models;
using BCrypt.Net;
using Microsoft.AspNetCore.Mvc;

namespace ASPSEC3.Controllers
{
	public class HashController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View(new HashViewModel());
		}

		[HttpPost]
		public IActionResult HashText(HashViewModel model)
		{
			string hashedValue = string.Empty;

			switch (model.SelectedAlgorithm)
			{
				case "MD5":
					using (var md5 = MD5.Create())
					{
						byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(model.InputText));
						hashedValue = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
					}
					break;
				case "SHA-1":
					using (var sha1 = SHA1.Create())
					{
						byte[] hashBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(model.InputText));
						hashedValue = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
					}
					break;
				case "SHA-256":
					using (var sha256 = SHA256.Create())
					{
						byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(model.InputText));
						hashedValue = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
					}
					break;
				case "SHA-512":
					using (var sha512 = SHA512.Create())
					{
						byte[] hashBytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(model.InputText));
						hashedValue = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
					}
					break;
				case "BCrypt":
					hashedValue = BCrypt.Net.BCrypt.HashPassword(model.InputText);
					break;
				default:
					break;
			}

			model.HashedValue = hashedValue;

			return View("Index", model);
		}
	}
}
