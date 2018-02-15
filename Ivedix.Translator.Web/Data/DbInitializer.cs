using Ivedix.Translator.Web.Models;
using System.Linq;

namespace Ivedix.Translator.Web.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                context.AddRange
                (
                    new Platform { Id = 1, Name = "Windows" },
                    new Platform { Id = 2, Name = "IOS" },
                    new Platform { Id = 3, Name = "Android" },
                    new Platform { Id = 4, Name = "Blackberry" }
                );
                context.SaveChanges();
            }

        }
    }
}
