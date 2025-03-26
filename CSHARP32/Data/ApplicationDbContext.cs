using Microsoft.EntityFrameworkCore;
using CSHARP32.Models;

namespace CSHARP32.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<CD> CDs { get; set; }
		public DbSet<DVD> DVDs { get; set; }
	}
}
