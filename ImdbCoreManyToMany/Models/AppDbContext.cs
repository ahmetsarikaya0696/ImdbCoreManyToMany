using Microsoft.EntityFrameworkCore;

namespace ImdbCoreManyToMany.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre>  Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .Property(x => x.Rating)
                .HasPrecision(3,1);
        }
    }
}
