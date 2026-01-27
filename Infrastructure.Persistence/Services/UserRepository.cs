using Core.Domain;
using Infrastructure.Persistence.Interfaces;

namespace Infrastructure.Persistence.Services
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDBContext dBContext) : base(dBContext)
        {

        }

        public async Task<User> GetDetailByEmailandPassword(string email)
        {
            User? user = _context.users.Where(r => r.Email == email).FirstOrDefault();
            return user;
        }
    }
}
