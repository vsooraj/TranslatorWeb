using Ivedix.Translator.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ivedix.Translator.Web.Data.Repositories
{
    public class MockPlatformRepository : IPlatformRepository
    {
        private List<Platform> _platforms;

        public MockPlatformRepository()
        {
            if (_platforms == null)
            {
                InitializePlatforms();
            }

        }

        private void InitializePlatforms()
        {
            _platforms = new List<Platform>
                {

                    new Platform{Id=1,Name="Windows" },
                    new Platform{Id=2,Name="IOS" },
                    new Platform{Id=3,Name="Android" },
                    new Platform{Id=4,Name="Blackberry" }

                };
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _platforms;
        }

        public Platform GetPlatformById(int platformId)
        {
            return _platforms.FirstOrDefault(x => x.Id == platformId);
        }

        public void AddPlatform(Platform model)
        {
            _platforms.Add(model);
        }
    }
}
