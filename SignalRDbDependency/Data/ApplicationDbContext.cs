using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SignalRDbDependency.Models;

namespace SignalRDbDependency.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Customer> Customer { get; set; }
		public DbSet<Product> Product { get; set; }
		public DbSet<Sale> Sale { get; set; }
    }
}
