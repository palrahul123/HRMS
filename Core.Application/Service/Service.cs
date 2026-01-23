using Core.Application.Interface;
using Core.Application.Interfaces;

namespace Core.Application.Service
{
    public class Service<T, Tdto> : IService<Tdto> where T : class, new() where Tdto : class, new()
    {
        private readonly IRepository<T> _repository;
        private readonly Func<T, Tdto> _entityToDto;
        private readonly Func<Tdto, T> _dtoToEntity;

        public Service(IRepository<T> repository, Func<T, Tdto> entityToDto, Func<Tdto, T> dtoToEntity)
        {
            _repository = repository;
            _entityToDto = entityToDto;
            _dtoToEntity = dtoToEntity;
        }

        public virtual async Task<Tdto> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _entityToDto(entity);
        }

        public virtual async Task<IEnumerable<Tdto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Select(e => _entityToDto(e));
        }

        public virtual async Task<Tdto> CreateAsync(Tdto dto)
        {
            var entity = _dtoToEntity(dto);
            await _repository.AddAsync(entity);
            return _entityToDto(entity);
        }

        public virtual async Task<Tdto> UpdateAsync(Tdto dto)
        {
            var entity = _dtoToEntity(dto);
            await _repository.Update(entity);
            return _entityToDto(entity);
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity != null)
                await _repository.Delete(entity);
        }
    }
}
