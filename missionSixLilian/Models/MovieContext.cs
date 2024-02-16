using Microsoft.EntityFrameworkCore;

namespace missionSixLilian.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<MovieSub> MovieSubmissions { get; set; }
    }
}
