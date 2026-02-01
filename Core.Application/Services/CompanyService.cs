using AutoMapper;
using Core.Application.DTOs.CompanyDtos;
using Core.Application.Interface.Repositories;
using Core.Application.Interface.Services;
using Core.Domain;

namespace Core.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _repository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CompanyDto>> GetAllAsync()
        {
            var companies = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<CompanyDto>>(companies);
        }

        public async Task<CompanyDto?> GetByIdAsync(int id)
        {
            var company = await _repository.GetByIdAsync(id);
            return company == null ? null : _mapper.Map<CompanyDto>(company);
        }

        public async Task<int> CreateAsync(CreateCompanyDto dto)
        {
            var company = _mapper.Map<Company>(dto);
            await _repository.AddAsync(company);
            return company.Id;
        }

        public async Task UpdateAsync(UpdateCompanyDto dto)
        {
            var company = await _repository.GetByIdAsync(dto.Id);
            if (company == null)
                throw new Exception("Company not found");

            _mapper.Map(dto, company);
            await _repository.UpdateAsync(company);
        }

        public async Task DeleteAsync(int id)
        {
            var company = await _repository.GetByIdAsync(id);
            if (company == null)
                throw new Exception("Company not found");

            await _repository.DeleteAsync(company);
        }
    }
}
