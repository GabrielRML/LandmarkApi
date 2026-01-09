using LandmarkApi.Application.DTOs;

namespace LandmarkApi.Application.Interfaces;

public interface ICityService
{
    Task<CityDto?> GetByIdAsync(int id);
    Task<IEnumerable<CityDto>> GetAllAsync();
    Task<IEnumerable<CityDto>> GetByStateIdAsync(int stateId);
}
