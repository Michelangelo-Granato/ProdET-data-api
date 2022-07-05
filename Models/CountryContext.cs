using Microsoft.EntityFrameworkCore;
using prodet_data_api.Models;

namespace TodoApi.Models
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