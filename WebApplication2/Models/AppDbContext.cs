using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace YourProjectName.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }
    }
}