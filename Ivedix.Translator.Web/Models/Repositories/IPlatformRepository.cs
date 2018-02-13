using System.Collections.Generic;

namespace Ivedix.Translator.Web.Models.Repositories
{
    public interface IPlatformRepository
    {
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int PlatformId);
        void AddPlatform(Platform model);
    }
}
