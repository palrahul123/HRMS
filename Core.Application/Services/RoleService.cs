using AutoMapper;
using Core.Application.DTOs.RoleDtos;
using Core.Application.Interface.Repositories;
using Core.Application.Interface.Services;
using Core.Domain;

namespace Core.Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _repository;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RoleDto>> GetAllAsync()
        {
            var roles = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<RoleDto>>(roles);
        }

        public async Task<RoleDto?> GetByIdAsync(int id)
        {
            var role = await _repository.GetByIdAsync(id);
            return role == null ? null : _mapper.Map<RoleDto>(role);
        }

        public async Task<int> CreateAsync(CreateRoleDto dto)
        {
            var role = _mapper.Map<Role>(dto);
            await _repository.AddAsync(role);
            return role.Id;
        }

        public async Task UpdateAsync(UpdateRoleDto dto)
        {
            var role = await _repository.GetByIdAsync(dto.Id);
            if (role == null)
                throw new Exception("Role not found");

            role.RoleName = dto.RoleName;
            await _repository.UpdateAsync(role);
        }

        public async Task DeleteAsync(int id)
        {
            var role = await _repository.GetByIdAsync(id);
            if (role == null)
                throw new Exception("Role not found");

            await _repository.DeleteAsync(role);
        }
    }
}
