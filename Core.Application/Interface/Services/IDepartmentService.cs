using Core.Application.DTOs.DepartmentDtos;

namespace Core.Application.Interface.Services;

public interface IDepartmentService
{
    Task<IEnumerable<DepartmentDto>> GetAllAsync();
    Task<DepartmentDto?> GetByIdAsync(int id);
    Task<int> CreateAsync(CreateDepartmentDto dto);
    Task UpdateAsync(UpdateDepartmentDto dto);
    Task DeleteAsync(int id);
}

