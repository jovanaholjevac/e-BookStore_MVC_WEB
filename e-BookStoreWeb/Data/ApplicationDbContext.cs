using e_BookStoreWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace e_BookStoreWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        public DbSet<Category> Categories { get; set; } //za kreiranje tabele u BP

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Sci-fi", DisplayOrder = 1 },
                new Category { Id = 3, Name = "History", DisplayOrder = 1 }
                );
        }

    }
}
