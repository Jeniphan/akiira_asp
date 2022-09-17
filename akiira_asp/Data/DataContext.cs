using akiira_asp.Models;
using Microsoft.EntityFrameworkCore;

namespace akiira_asp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Movie> movies => Set<Movie>();
    }
}
