namespace CSHARP32.Models
{
	public class CD : Artikel
	{
		public int AantalLiedjes { get; set; }

		public override decimal TotaleWaarde()
		{
			return AantalStuks * Prijs;
		}
	}
}
