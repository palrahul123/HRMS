namespace Core.Application.Interface
{
    public interface IServiceRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> CreateAsync(T dto);
        Task<T> UpdateAsync(T dto);
        Task DeleteAsync(int id);
    }
}
