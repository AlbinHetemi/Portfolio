
using Portfolio.Models;
using Portfolio.Repositories;

namespace Portfolio.Services
{
    public  class ProfileService : IProfile
    {
        private readonly DbContext dbContext;

        public ProfileService(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Profile getProfile()
        {
            return dbContext.profile;
        }
    }
}
