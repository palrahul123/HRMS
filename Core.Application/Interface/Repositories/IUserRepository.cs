using Core.Domain;
using System.Linq.Expressions;

namespace Core.Application.Interface.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();
        Task<IEnumerable<User>> FindAsync(Expression<Func<User, bool>> predicate);
        Task AddAsync(User entity);
        Task Update(User entity);
        Task Delete(int Id);
        Task<User> GetDetailByEmailandPassword(string email);
    }
}
