// ComicReader.Services/ComicDbContext.cs
using Microsoft.EntityFrameworkCore;
using ComicReader.Models;

namespace ComicReader.Services
{
    public class ComicDbContext : DbContext
    {
        public DbSet<Comic> Comics { get; set; }
        public DbSet<Chapter> Chapters { get; set; }

        public ComicDbContext(DbContextOptions<ComicDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comic>()
                .HasMany(c => c.Chapters)
                .WithOne()
                .HasForeignKey("ComicId");
        }
    }
}