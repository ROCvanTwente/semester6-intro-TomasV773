using AnimalWorld;

namespace MyAnimalsMVC.Models
{
	public class AnimalViewModel
	{
		public string Name { get; set; }
		public string Sound { get; set; }
		public string Position { get; set; }
		public Direction Direction { get; set; }
		public int Step { get; set; }
	}

}
