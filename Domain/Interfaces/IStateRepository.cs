using LandmarkApi.Domain.Entities;

namespace LandmarkApi.Domain.Interfaces;

public interface IStateRepository
{
    Task<State?> GetByIdAsync(int id);
    Task<IEnumerable<State>> GetAllAsync();
}
