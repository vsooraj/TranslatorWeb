using Ivedix.Translator.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ivedix.Translator.Web.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Filegroup> Filegroups { get; set; }
        public DbSet<Key> Keys { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<Platformkey> Platformkeys { get; set; }


    }
}
