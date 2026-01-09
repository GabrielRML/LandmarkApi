using LandmarkApi.Domain.Common;
using LandmarkApi.Domain.Entities;

namespace LandmarkApi.Domain.Interfaces;

public interface ITouristPointRepository
{
    Task<TouristPoint?> GetByIdAsync(Guid id);
    Task<IEnumerable<TouristPoint>> GetAllAsync();
    Task<PagedResultDto<TouristPoint>> GetPagedAsync(int pageNumber, int pageSize, string? name = null);
    Task AddAsync(TouristPoint touristPoint);
    Task UpdateAsync(TouristPoint touristPoint);
    Task DeleteAsync(TouristPoint touristPoint);
}
