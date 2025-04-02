namespace CSHARP32.Models
{
	public class DVD : Artikel
	{
		public override decimal TotaleWaarde()
		{
			return AantalStuks * Prijs;
		}
	}
}
