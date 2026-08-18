using AsianStoreInventory.Models;
using Microsoft.EntityFrameworkCore;


namespace AsianStoreInventory.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }



        public DbSet<Product> Products => Set<Product>();
        public DbSet<Sale> Sales => Set<Sale>();
        public DbSet<User> Users => Set<User>();
    }
}