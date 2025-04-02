using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
	public enum Direction
	{
		Up,
		Down,
		Left,
		Right
	}

	public interface IAnimal
	{
		void Move(Direction direction, int step);
		Point Position { get; set; }
		string Name { get; set; }
		string Sound { get; set; }
	}

}
