using Microsoft.EntityFrameworkCore;
using Slugify;

namespace AulaRazorPages.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options)
     : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }

        public override int SaveChanges()
        {
            var addedOrModifiedEntities = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach (var entityEntry in addedOrModifiedEntities)
            {
                if (entityEntry.Entity is Movie movie)
                {
                    if (string.IsNullOrEmpty(movie.Name))
                    {
                        continue; // Skip if Name is null or empty
                    }

                   // movie.PermaLink = _slugHelper.GenerateSlug(movie.Name);
                }
            }

            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var addedOrModifiedEntities = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach (var entityEntry in addedOrModifiedEntities)
            {
                if (entityEntry.Entity is Movie movie)
                {
                    if (string.IsNullOrEmpty(movie.Name))
                    {
                        continue; // Skip if Name is null or empty
                    }

                   // movie.PermaLink = _slugHelper.GenerateSlug(movie.Name);
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasIndex(m => m.PermaLink)
                .IsUnique(); // Ensures that Permalinks are unique
        }
    }
}