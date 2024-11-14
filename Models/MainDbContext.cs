using Microsoft.EntityFrameworkCore;

namespace test_backend.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
    }
}
