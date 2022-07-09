using Microsoft.EntityFrameworkCore;

namespace Selfitness.Library.DbModels
{
    public class SelfitnessDbContext : DbContext
    {
        public DbSet<User> User { get; set; } = null!;

        public SelfitnessDbContext(DbContextOptions options) : base(options) { }
    }
}
