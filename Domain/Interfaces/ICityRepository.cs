using LandmarkApi.Domain.Entities;

namespace LandmarkApi.Domain.Interfaces;

public interface ICityRepository
{
    Task<City?> GetByIdAsync(int id);
    Task<IEnumerable<City>> GetAllAsync();
    Task<IEnumerable<City>> GetCitiesByStateIdAsync(int stateId);
    Task<City?> GetCityWithTouristPointsAsync(int id);
    Task AddAsync(City city);
    Task UpdateAsync(City city);
    Task DeleteAsync(City city);
    Task<bool> ExistsAsync(int id);
}
