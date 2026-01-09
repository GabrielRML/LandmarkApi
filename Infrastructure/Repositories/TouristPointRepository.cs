using LandmarkApi.Domain.Common;
using LandmarkApi.Domain.Entities;
using LandmarkApi.Domain.Interfaces;
using LandmarkApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LandmarkApi.Infrastructure.Repositories;

public class TouristPointRepository : ITouristPointRepository
{
    private readonly ApplicationDbContext _context;

    public TouristPointRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<TouristPoint?> GetByIdAsync(Guid id)
    {
        return await _context.TouristPoints.FindAsync(id);
    }

    public async Task<IEnumerable<TouristPoint>> GetAllAsync()
    {
        return await _context.TouristPoints.ToListAsync();
    }

    public async Task<PagedResultDto<TouristPoint>> GetPagedAsync(int pageNumber, int pageSize)
    {
        var totalCount = await _context.TouristPoints.CountAsync();
        
        var items = await _context.TouristPoints
            .OrderBy(t => t.Name)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PagedResultDto<TouristPoint>
        {
            Items = items,
            TotalCount = totalCount,
            PageNumber = pageNumber,
            PageSize = pageSize
        };
    }

    public async Task<IEnumerable<TouristPoint>> GetByCityIdAsync(int cityId)
    {
        return await _context.TouristPoints
            .Where(t => t.CityId == cityId)
            .ToListAsync();
    }

    public async Task<TouristPoint?> GetWithCityAsync(Guid id)
    {
        return await _context.TouristPoints
            .Include(t => t.City)
                .ThenInclude(c => c.State)
            .FirstOrDefaultAsync(t => t.Id == id);
    }

    public async Task<PagedResultDto<TouristPoint>> GetPagedByCityIdAsync(int cityId, int pageNumber, int pageSize)
    {
        var query = _context.TouristPoints.Where(t => t.CityId == cityId);
        
        var totalCount = await query.CountAsync();
        
        var items = await query
            .OrderBy(t => t.Name)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PagedResultDto<TouristPoint>
        {
            Items = items,
            TotalCount = totalCount,
            PageNumber = pageNumber,
            PageSize = pageSize
        };
    }

    public async Task AddAsync(TouristPoint touristPoint)
    {
        await _context.TouristPoints.AddAsync(touristPoint);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TouristPoint touristPoint)
    {
        _context.TouristPoints.Update(touristPoint);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(TouristPoint touristPoint)
    {
        _context.TouristPoints.Remove(touristPoint);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(Guid id)
    {
        return await _context.TouristPoints.AnyAsync(t => t.Id == id);
    }
}
