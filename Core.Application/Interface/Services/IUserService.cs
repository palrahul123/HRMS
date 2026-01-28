using Core.Application.DTOs.UserProfile;
using Core.Domain;
using System.Linq.Expressions;

namespace Core.Application.Interface.Services
{
    public interface IUserService
    {
        Task<UserResponseDto> GetByIdAsync(int id);
        Task<IEnumerable<UserResponseDto>> GetAllAsync();
        Task<IEnumerable<UserResponseDto>> FindAsync(Expression<Func<User, bool>> predicate);
        Task AddAsync(CreateUserDto entity);
        Task Update(UpdateUserDto entity);
        Task Delete(int Id);
        Task<AuthenticationResponse> GetDetailByEmailandPassword(LoginRequestDto requestDto);
    }
}
