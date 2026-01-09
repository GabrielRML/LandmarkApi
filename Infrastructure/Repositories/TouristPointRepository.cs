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
        return await _context.TouristPoints
            .Include(t => t.City)
                .ThenInclude(c => c.State)
            .FirstOrDefaultAsync(t => t.Id == id);
    }

    public async Task<IEnumerable<TouristPoint>> GetAllAsync()
    {
        return await _context.TouristPoints
            .Include(t => t.City)
                .ThenInclude(c => c.State)
            .ToListAsync();
    }

    public async Task<PagedResultDto<TouristPoint>> GetPagedAsync(int pageNumber, int pageSize, string? name = null, string orderByCreatedAt = "desc")
    {
        var query = _context.TouristPoints
            .Include(t => t.City)
                .ThenInclude(c => c.State)
            .AsQueryable();
        
        if (!string.IsNullOrWhiteSpace(name))
        {
            query = query.Where(t => t.Name.Contains(name));
        }
        
        var totalCount = await query.CountAsync();
        
        query = orderByCreatedAt.ToLower() == "asc" 
            ? query.OrderBy(t => t.CreatedAt) 
            : query.OrderByDescending(t => t.CreatedAt);
        
        var items = await query
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
}
