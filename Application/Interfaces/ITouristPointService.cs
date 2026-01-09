using LandmarkApi.Application.DTOs;
using LandmarkApi.Domain.Common;

namespace LandmarkApi.Application.Interfaces;

public interface ITouristPointService
{
    Task<TouristPointDto?> GetByIdAsync(Guid id);
    Task<IEnumerable<TouristPointDto>> GetAllAsync();
    Task<PagedResultDto<TouristPointDto>> GetPagedAsync(int pageNumber, int pageSize, string? name = null);
    Task<TouristPointDto> CreateAsync(CreateTouristPointDto createDto);
    Task<TouristPointDto?> UpdateAsync(Guid id, UpdateTouristPointDto updateDto);
    Task<bool> DeleteAsync(Guid id);
}
