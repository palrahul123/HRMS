using AutoMapper;
using Core.Application.DTOs.BranchDtos;
using Core.Application.Interface.Repositories;
using Core.Application.Interface.Services;
using Core.Domain;

namespace Core.Application.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _repository;
        private readonly IMapper _mapper;

        public BranchService(IBranchRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BranchDto>> GetAllAsync()
        {
            var branches = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<BranchDto>>(branches);
        }

        public async Task<BranchDto?> GetByIdAsync(int id)
        {
            var branch = await _repository.GetByIdAsync(id);
            return branch == null ? null : _mapper.Map<BranchDto>(branch);
        }

        public async Task<int> CreateAsync(CreateBranchDto dto)
        {
            var branch = _mapper.Map<Branch>(dto);
            await _repository.AddAsync(branch);
            return branch.Id;
        }

        public async Task UpdateAsync(UpdateBranchDto dto)
        {
            var branch = await _repository.GetByIdAsync(dto.Id);
            if (branch == null)
                throw new Exception("Branch not found");

            _mapper.Map(dto, branch);
            await _repository.UpdateAsync(branch);
        }

        public async Task DeleteAsync(int id)
        {
            var branch = await _repository.GetByIdAsync(id);
            if (branch == null)
                throw new Exception("Branch not found");

            await _repository.DeleteAsync(branch);
        }
    }
}
