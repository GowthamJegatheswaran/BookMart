using Microsoft.EntityFrameworkCore;
using Store.Models;

namespace Store.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public  DbSet<Category> Categories { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Gowtham", RollNo = 007 },
                new Category { Id = 2, Name = "Prabhu", RollNo = 006 },
                new Category { Id = 3, Name = "Kalai", RollNo = 010 }
                );

        }

    }

}
