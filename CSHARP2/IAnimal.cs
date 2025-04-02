using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2
{
	public interface IAnimal
	{
		string Name { get; set; }
		double Weight { get; set; }
		int Age { get; set; }
		void ChangeName(string newName);
		void ChangeWeight(double newWeight);
		void ChangeAge(int newAge);
		string GetInfo();
	}

	public class Dog : IAnimal
	{
		public string Name { get; set; }
		public double Weight { get; set; }
		public int Age { get; set; }

		public Dog(string name, double weight, int age)
		{
			Name = name;
			Weight = weight;
			Age = age;
		}

		public void ChangeName(string newName) => Name = newName;
		public void ChangeWeight(double newWeight) => Weight = newWeight;
		public void ChangeAge(int newAge) => Age = newAge;
		public string GetInfo() => $"Hond: {Name}, Gewicht: {Weight} kg, Leeftijd: {Age} jaar";
	}

	public class Cat : IAnimal
	{
		public string Name { get; set; }
		public double Weight { get; set; }
		public int Age { get; set; }

		public Cat(string name, double weight, int age)
		{
			Name = name;
			Weight = weight;
			Age = age;
		}

		public void ChangeName(string newName) => Name = newName;
		public void ChangeWeight(double newWeight) => Weight = newWeight;
		public void ChangeAge(int newAge) => Age = newAge;
		public string GetInfo() => $"Kat: {Name}, Gewicht: {Weight} kg, Leeftijd: {Age} jaar";

	}
	public class AnimalController
	{
		private IAnimal _animal;
		private AnimalView _view;

		public AnimalController(IAnimal animal, AnimalView view)
		{
			_animal = animal;
			_view = view;
			_view.DisplayAnimalInfo(_animal.GetInfo());
		}

		public void UpdateAnimal(string name, double weight, int age)
		{
			_animal.ChangeName(name);
			_animal.ChangeWeight(weight);
			_animal.ChangeAge(age);
			_view.DisplayAnimalInfo(_animal.GetInfo());
		}
	}

	public class AnimalView
	{
		public void DisplayAnimalInfo(string info)
		{
			Console.WriteLine(info);
		}
	}
}
