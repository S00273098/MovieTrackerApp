using MovieTrackerApp.Models;
using System.Data.Entity;
using MovieTrackerApp.Models;

public class AppDbContext : DbContext
{
    public AppDbContext() : base("MovieDb")
    {
    }

    public DbSet<Movie> Movies { get; set; }
}