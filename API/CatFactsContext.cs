using Microsoft.EntityFrameworkCore;

namespace API
{
    public class CatFactsContext : DbContext
    {
        public DbSet<CatFact> CatFacts { get; set; }

        public CatFactsContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=CatFacts.db");
        }
    }
}
