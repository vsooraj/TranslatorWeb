using Ivedix.Translator.Web.Models;
using System.Collections.Generic;

namespace Ivedix.Translator.Web.Data.Repositories
{
    public interface IPlatformRepository
    {
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int platformId);
        void AddPlatform(Platform model);
    }
}
