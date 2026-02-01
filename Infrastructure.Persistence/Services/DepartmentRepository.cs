using Core.Application.Interface.Repositories;
using Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Services;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly ApplicationDBContext _context;

    public DepartmentRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Department>> GetAllAsync()
    {
        return await _context.Departments
            .Include(x => x.Branch)
            .Include(x => x.Company)
            .ToListAsync();
    }

    public async Task<Department?> GetByIdAsync(int id)
    {
        return await _context.Departments
            .Include(x => x.Branch)
            .Include(x => x.Company)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddAsync(Department department)
    {
        await _context.Departments.AddAsync(department);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Department department)
    {
        _context.Departments.Update(department);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Department department)
    {
        _context.Departments.Remove(department);
        await _context.SaveChangesAsync();
    }
}

