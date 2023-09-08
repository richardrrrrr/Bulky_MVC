using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;


namespace BulkyWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "ACtion", DisplayOreder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOreder = 2 },
                new Category { Id = 3, Name = "History", DisplayOreder = 3 }
                );
        }
    }
}
