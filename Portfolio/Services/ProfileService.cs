using Portfolio.Models;
using Portfolio.Repositories;

namespace Portfolio.Services
{
    public static class ProfileService : IProfile
    {

        public static Profile getProfile()
        {
            return DbContext.Profile2();
        }
    }
}
