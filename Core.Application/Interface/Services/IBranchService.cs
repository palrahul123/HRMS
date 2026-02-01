using Core.Application.DTOs.BranchDtos;

namespace Core.Application.Interface.Services
{
    public interface IBranchService
    {
        Task<IEnumerable<BranchDto>> GetAllAsync();
        Task<BranchDto?> GetByIdAsync(int id);
        Task<int> CreateAsync(CreateBranchDto dto);
        Task UpdateAsync(UpdateBranchDto dto);
        Task DeleteAsync(int id);
    }
}
