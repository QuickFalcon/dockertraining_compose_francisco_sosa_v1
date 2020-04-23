using Microsoft.EntityFrameworkCore;

namespace dockertraining_compose_francisco_sosa_v1.Models
{
    public class Context : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
