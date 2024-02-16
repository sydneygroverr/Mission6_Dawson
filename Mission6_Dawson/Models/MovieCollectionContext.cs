using Microsoft.EntityFrameworkCore;

namespace Mission6_Dawson.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base (options)  //constructor 
        { 
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
