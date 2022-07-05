using Microsoft.EntityFrameworkCore;

namespace prodet_data_api.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        {
        }

        public DbSet<Country> CountryItems { get; set; } = null!;
    }
}