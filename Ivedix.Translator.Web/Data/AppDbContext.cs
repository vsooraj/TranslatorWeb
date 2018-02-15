using Ivedix.Translator.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Ivedix.Translator.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
