using Core.Domain;

namespace Infrastructure.Persistence.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> GetDetailByEmailandPassword(string email);
    }
}
