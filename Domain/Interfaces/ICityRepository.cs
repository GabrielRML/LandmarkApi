using LandmarkApi.Domain.Entities;

namespace LandmarkApi.Domain.Interfaces;

public interface ICityRepository
{
    Task<City?> GetByIdAsync(int id);
    Task<IEnumerable<City>> GetAllAsync();
}
