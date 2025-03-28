namespace CSHARP31
{
		public abstract class Dier
		{
			public int Gewicht { get; set; }

			protected Dier(int gewicht)
			{
				Gewicht = gewicht;
			}

			public abstract string Geluid();
		}
}
