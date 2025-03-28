namespace CSHARP31
{
	public class Varken : Dier
	{
		public Varken(int gewicht) : base(gewicht) { }

		public override string Geluid()
		{
			return "Oink oink!";
		}
	}
}
