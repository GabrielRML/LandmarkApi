using LandmarkApi.Domain.Entities;

namespace LandmarkApi.Domain.Interfaces;

public interface IStateRepository
{
    Task<State?> GetByIdAsync(int id);
    Task<IEnumerable<State>> GetAllAsync();
    Task<State?> GetByAcronymAsync(string acronym);
    Task<IEnumerable<State>> GetStatesWithCitiesAsync();
    Task AddAsync(State state);
    Task UpdateAsync(State state);
    Task DeleteAsync(State state);
    Task<bool> ExistsAsync(int id);
}
