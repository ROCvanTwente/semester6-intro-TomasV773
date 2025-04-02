using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSHARP32.Models
{
	public abstract class Artikel
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Titel { get; set; }

		[Required]
		[Column(TypeName = "decimal(10,2)")]
		public decimal Prijs { get; set; }

		[Required]
		public int AantalStuks { get; set; }

		public abstract decimal TotaleWaarde();
	}
}
