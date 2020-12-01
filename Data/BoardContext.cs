using Microsoft.EntityFrameworkCore;
namespace eljaroboard.Data
{
    public class BoardContext : DbContext
    {
        public BoardContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Card> Users { get; set; }

    }
}

