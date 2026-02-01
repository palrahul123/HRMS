using Core.Application.DTOs.CompanyDtos;

namespace Core.Application.Interface.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyDto>> GetAllAsync();
        Task<CompanyDto?> GetByIdAsync(int id);
        Task<int> CreateAsync(CreateCompanyDto dto);
        Task UpdateAsync(UpdateCompanyDto dto);
        Task DeleteAsync(int id);
    }
}
