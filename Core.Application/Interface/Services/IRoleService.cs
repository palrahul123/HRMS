using Core.Application.DTOs.RoleDtos;

namespace Core.Application.Interface.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleDto>> GetAllAsync();
        Task<RoleDto?> GetByIdAsync(int id);
        Task<int> CreateAsync(CreateRoleDto dto);
        Task UpdateAsync(UpdateRoleDto dto);
        Task DeleteAsync(int id);
    }
}
