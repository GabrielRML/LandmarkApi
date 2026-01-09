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
        return await _context.Cities.FindAsync(id);
    }

    public async Task<IEnumerable<City>> GetAllAsync()
    {
        return await _context.Cities.ToListAsync();
    }

    public async Task<IEnumerable<City>> GetCitiesByStateIdAsync(int stateId)
    {
        return await _context.Cities
            .Where(c => c.StateId == stateId)
            .ToListAsync();
    }

    public async Task<City?> GetCityWithTouristPointsAsync(int id)
    {
        return await _context.Cities
            .Include(c => c.TouristPoints)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task AddAsync(City city)
    {
        await _context.Cities.AddAsync(city);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(City city)
    {
        _context.Cities.Update(city);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(City city)
    {
        _context.Cities.Remove(city);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _context.Cities.AnyAsync(c => c.Id == id);
    }
}
