using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using FarmAndTrace.Model;

namespace FarmAndTrace.DAL
{
    public class FarmAndTraceContext : IdentityDbContext
    {
        // Tables
        public DbSet<Client> Clients { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Product> Products { get; set; }

        public FarmAndTraceContext(DbContextOptions<FarmAndTraceContext> options)
        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}