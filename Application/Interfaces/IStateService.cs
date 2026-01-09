using LandmarkApi.Application.DTOs;

namespace LandmarkApi.Application.Interfaces;

public interface IStateService
{
    Task<StateDto?> GetByIdAsync(int id);
    Task<IEnumerable<StateDto>> GetAllAsync();
}
