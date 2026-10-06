using GameStore.Data.Domain;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<Developer> Developers { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;
        public DbSet<GameTag> GameTags { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Card> Cards { get; set; } = null!;
        public DbSet<Purchase> Purchases { get; set; } = null!;
    }
}
