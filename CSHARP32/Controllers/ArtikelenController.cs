using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSHARP32.Data;
using CSHARP32.Models;
using System.Linq;
using System.Threading.Tasks;

namespace CSHARP32.Controllers
{
	public class ArtikelenController : Controller
	{
		private readonly ApplicationDbContext _context;

		public ArtikelenController(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var cds = await _context.CDs.ToListAsync();
			var dvds = await _context.DVDs.ToListAsync();
			var artikelen = cds.Cast<Artikel>().Concat(dvds);
			return View(artikelen);
		}

		public async Task<IActionResult> WijzigVoorraad(int id, int nieuwAantal)
		{
			var artikel = await _context.CDs.FindAsync(id) as Artikel ?? await _context.DVDs.FindAsync(id) as Artikel;
			if (artikel == null) return NotFound();

			artikel.AantalStuks = nieuwAantal;
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}
	}
}
