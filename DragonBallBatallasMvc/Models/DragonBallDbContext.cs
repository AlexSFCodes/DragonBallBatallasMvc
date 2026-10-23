using System.Data.Entity;

namespace DragonBallBatallasMvc.Models
{
    public class DragonBallDbContext : DbContext
    {
        public DragonBallDbContext() : base("name=DragonBallDbContext") { }

        public DbSet<Guerrero> Guerreros { get; set; }
        public DbSet<Batalla> Batallas { get; set; }
    }
}