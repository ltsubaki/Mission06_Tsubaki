using Microsoft.EntityFrameworkCore;

namespace missionSixLilian.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<MovieSub> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
    