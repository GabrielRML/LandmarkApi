using LandmarkApi.Application.DTOs;
using LandmarkApi.Application.Interfaces;
using LandmarkApi.Domain.Interfaces;

namespace LandmarkApi.Application.Services;

public class CityService : ICityService
{
    private readonly ICityRepository _repository;

    public CityService(ICityRepository repository)
    {
        _repository = repository;
    }

    public async Task<CityDto?> GetByIdAsync(int id)
    {
        var city = await _repository.GetByIdAsync(id);
        return city == null ? null : MapToDto(city);
    }

    public async Task<IEnumerable<CityDto>> GetAllAsync()
    {
        var cities = await _repository.GetAllAsync();
        return cities.Select(MapToDto);
    }

    public async Task<IEnumerable<CityDto>> GetByStateIdAsync(int stateId)
    {
        var cities = await _repository.GetByStateIdAsync(stateId);
        return cities.Select(MapToDto);
    }

    private static CityDto MapToDto(Domain.Entities.City city)
    {
        return new CityDto
        {
            Id = city.Id,
            Name = city.Name,
            IbgeCode = city.IbgeCode,
            StateId = city.StateId,
            StateName = city.State?.Name ?? string.Empty,
            StateAcronym = city.State?.Acronym ?? string.Empty
        };
    }
}
