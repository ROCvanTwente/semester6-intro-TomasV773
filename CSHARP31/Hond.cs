namespace CSHARP31
{
	public class Hond : Dier
	{
		public Hond(int gewicht) : base(gewicht) { }

		public override string Geluid()
		{
			return "Woef woef!";
		}
	}
}
