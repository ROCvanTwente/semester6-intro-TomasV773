using AnimalWorld;
using System.Drawing;

public class Animal : IAnimal
{
	private static Random _random = new Random();

	public string Name { get; set; }
	public Point Position { get; set; }
	public string Sound { get; set; } 

	public Animal(string name, string sound)
	{
		Name = name;
		Sound = sound;
		Position = new Point(_random.Next(0, 1001), _random.Next(0, 1001));
	}


	public void Move(Direction direction, int step)
	{
		switch (direction)
		{
			case Direction.Up:
				Position = new Point(Position.X, Position.Y - step);
				break;
			case Direction.Down:
				Position = new Point(Position.X, Position.Y + step);
				break;
			case Direction.Left:
				Position = new Point(Position.X - step, Position.Y);
				break;
			case Direction.Right:
				Position = new Point(Position.X + step, Position.Y);
				break;
		}

	}
}
