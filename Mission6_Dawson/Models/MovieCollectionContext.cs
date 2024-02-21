using Microsoft.EntityFrameworkCore;

namespace Mission6_Dawson.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base (options)  //constructor 
        { 
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Family" },
                new Category { CategoryId = 2, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Television" },
                new Category { CategoryId = 5, CategoryName = "VHS" },
                new Category { CategoryId = 6, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 7, CategoryName = "Comedy" },
                new Category { CategoryId = 8, CategoryName = "Miscellaneous" }

                );
        }
    }
}
