using HomesFullStack.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace HomesFullStack.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Home> Homes { get; set; }
    }
}
