using LandmarkApi.Domain.Entities;
using LandmarkApi.Domain.Interfaces;
using LandmarkApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LandmarkApi.Infrastructure.Repositories;

public class CityRepository : ICityRepository
{
    private readonly ApplicationDbContext _context;

    public CityRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<City?> GetByIdAsync(int id)
    {
        return await _context.Cities
            .Include(c => c.State)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<City>> GetAllAsync()
    {
        return await _context.Cities
            .Include(c => c.State)
            .OrderBy(c => c.Name)
            .ToListAsync();
    }
}
