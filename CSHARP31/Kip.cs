namespace CSHARP31
{
	namespace DierenLibrary
	{
		public class Kip : Dier
		{
			public Kip(int gewicht) : base(gewicht) { }

			public override string Geluid()
			{
				return "Tok tok!";
			}
		}
	}

}
