using blogger_server.Model;
using Microsoft.EntityFrameworkCore;

namespace blogger_server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }
    }
}
