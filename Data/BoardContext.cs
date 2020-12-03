using Microsoft.EntityFrameworkCore;
namespace eljaroboard.Data
{
    public class BoardContext : DbContext
    {
        public BoardContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CardComment> CardComments { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Board> Boards { get; set; }
    }
}

