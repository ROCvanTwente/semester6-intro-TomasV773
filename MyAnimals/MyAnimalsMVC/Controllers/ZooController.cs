using AnimalWorld;
using Microsoft.AspNetCore.Mvc;
using MyAnimalsMVC.Models;
using System.Linq;

public class ZooController : Controller
{
	public IActionResult Index()
	{
		var viewModel = Zoo.Animals.Select(animal => new AnimalViewModel
		{
			Name = animal.Name,
			Position = $"{animal.Position.X}, {animal.Position.Y}",
			Sound = animal.Sound
		}).ToList();

		return View(viewModel);
	}

	[HttpPost]
	public IActionResult MoveAnimal(string animalName, Direction direction, int step)
	{
		var animal = Zoo.Animals.FirstOrDefault(a => a.Name == animalName);
		if (animal != null)
		{
			animal.Move(direction, step);
		}

		var viewModel = Zoo.Animals.Select(a => new AnimalViewModel
		{
			Name = a.Name,
			Position = $"{a.Position.X}, {a.Position.Y}",
			Sound = a.Sound
		}).ToList();

		return View("Index", viewModel);
	}

}
