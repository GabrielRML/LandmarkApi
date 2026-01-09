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
        return await _context.States.FindAsync(id);
    }

    public async Task<IEnumerable<State>> GetAllAsync()
    {
        return await _context.States.ToListAsync();
    }

    public async Task<State?> GetByAcronymAsync(string acronym)
    {
        return await _context.States
            .FirstOrDefaultAsync(s => s.Acronym == acronym);
    }

    public async Task<IEnumerable<State>> GetStatesWithCitiesAsync()
    {
        return await _context.States
            .Include(s => s.Cities)
            .ToListAsync();
    }

    public async Task AddAsync(State state)
    {
        await _context.States.AddAsync(state);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(State state)
    {
        _context.States.Update(state);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(State state)
    {
        _context.States.Remove(state);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _context.States.AnyAsync(s => s.Id == id);
    }
}
