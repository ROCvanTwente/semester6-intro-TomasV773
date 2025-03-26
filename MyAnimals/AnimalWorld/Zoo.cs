using AnimalWorld;

public class Zoo
{
	public static List<IAnimal> Animals { get; set; } = new List<IAnimal>();

	static Zoo()
	{
		Animals.Add(new Animal("Hond", "Woef!"));
		Animals.Add(new Animal("Kat", "Miauw!"));
		Animals.Add(new Animal("Vogel", "Fluit!"));
		Animals.Add(new Animal("Leeuw", "Roar!"));
		Animals.Add(new Animal("Olifant", "Toeter!"));
	}
}
