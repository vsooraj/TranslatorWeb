using Ivedix.Translator.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ivedix.Translator.Web.Data.Repositories
{
    public class PlatformRepository : IPlatformRepository
    {
        private readonly AppDbContext _appDbContext;

        public PlatformRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddPlatform(Platform model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _appDbContext.Platforms;
        }

        public Platform GetPlatformById(int platformId)
        {
            return _appDbContext.Platforms.FirstOrDefault(x => x.Id == platformId); ;
        }
    }
}
