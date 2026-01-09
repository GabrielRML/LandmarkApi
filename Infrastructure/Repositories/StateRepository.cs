using LandmarkApi.Domain.Entities;
using LandmarkApi.Domain.Interfaces;
using LandmarkApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LandmarkApi.Infrastructure.Repositories;

public class StateRepository : IStateRepository
{
    private readonly ApplicationDbContext _context;

    public StateRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<State?> GetByIdAsync(int id)
    {
        return await _context.States
            .FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<IEnumerable<State>> GetAllAsync()
    {
        return await _context.States
            .OrderBy(s => s.Name)
            .ToListAsync();
    }
}
