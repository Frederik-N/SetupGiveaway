using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Giveaways> Giveaways { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=GiveawayDb;Trusted_Connection=True;");
    }
}
