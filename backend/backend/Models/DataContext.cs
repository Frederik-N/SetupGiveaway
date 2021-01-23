using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }
        public DbSet<Giveaway> Giveaways { get; set; }

    }
}
