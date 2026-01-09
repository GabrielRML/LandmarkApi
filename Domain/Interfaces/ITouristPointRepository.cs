using LandmarkApi.Domain.Common;
using LandmarkApi.Domain.Entities;

namespace LandmarkApi.Domain.Interfaces;

public interface ITouristPointRepository
{
    Task<TouristPoint?> GetByIdAsync(Guid id);
    Task<IEnumerable<TouristPoint>> GetAllAsync();
    Task<PagedResultDto<TouristPoint>> GetPagedAsync(int pageNumber, int pageSize);
    Task<IEnumerable<TouristPoint>> GetByCityIdAsync(int cityId);
    Task<TouristPoint?> GetWithCityAsync(Guid id);
    Task<PagedResultDto<TouristPoint>> GetPagedByCityIdAsync(int cityId, int pageNumber, int pageSize);
    Task AddAsync(TouristPoint touristPoint);
    Task UpdateAsync(TouristPoint touristPoint);
    Task DeleteAsync(TouristPoint touristPoint);
    Task<bool> ExistsAsync(Guid id);
}
