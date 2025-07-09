using Microsoft.EntityFrameworkCore;
using TestAPI.Domain;

namespace TestAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}


    


