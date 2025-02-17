using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mission6App.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options) //constructor
        {
        } 
        public DbSet<Application> Forms { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                .Property(a => a.Rating)
                .HasConversion(new EnumToStringConverter<MovieRating>()); // ✅ Converts enum to string in DB
        }
    }
}


