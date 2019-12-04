using GamerProfileWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace GamerProfileWebApplication.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
        : base(options)
        { 
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
