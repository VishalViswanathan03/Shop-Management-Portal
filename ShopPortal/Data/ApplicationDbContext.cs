using Microsoft.EntityFrameworkCore;
using ShopPortal.Models.Entity;

namespace ShopPortal.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Items> Items  { get; set; }
    }
}
